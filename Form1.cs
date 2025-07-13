using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace michellrps_sd_monitoramento_mqtt
{
    public partial class FormMonitoramentoMQTT : Form
    {
        private string host = "sergioportari.ddns.net";
        private int porta = 1883;
        private string usuario = "testes";
        private string senha = "pepperoni";
        private string topico = "sensores/frutal/dht11";
        private MqttClient cliente;

        public FormMonitoramentoMQTT()
        {
            InitializeComponent();
        }

        private void FormMonitoramentoMQTT_Load(object sender, EventArgs e)
        {
            // Exibe dados de conexão
            textBoxHost.Text = host;
            textBoxPorta.Text = porta.ToString();
            textBoxUsuario.Text = usuario;
            textBoxSenha.Text = senha;
            textBoxTopico.Text = topico;

            // Tenta conectar ao host e inscrever no tópico automaticamente
            this.conectar();
            this.inscrever();
        }

        private void FormMonitoramentoMQTT_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Quando o usuário pressiona o botão de fechar da janela, desconecta do host automaticamente
            this.sair();
        }

        private void timerAtualizacao_Tick(object sender, EventArgs e)
        {
            // Verifica se foi recebida alguma mensagem
            if (Parametros.mensagem == "" || Parametros.leitura == null || float.IsNaN(Parametros.leitura.temperatura) || float.IsNaN(Parametros.leitura.umidade) || string.IsNullOrWhiteSpace(Parametros.leitura.datahora))
            {
                return;
            }

            try
            {
                // Exibe as informações da mensagem
                labelTemperaturaValue.Text = Parametros.leitura.temperatura.ToString() + " °C";
                labelUmidadeValue.Text = Parametros.leitura.umidade.ToString() + " %";
                labelUltimaAtualizacaoValue.Text = DateTime.Parse(Parametros.leitura.datahora).ToString("dd/MM/yyyy HH:mm");

                // Verifica a temperatura
                if (Parametros.leitura.temperatura < 20)
                {
                    labelTemperaturaValue.ForeColor = Color.DeepSkyBlue;
                    labelAlertaTemperatura.ForeColor = Color.DeepSkyBlue;
                    labelAlertaTemperatura.Text = "❄️ Está frio! ❄️";
                }
                else if (Parametros.leitura.temperatura > 30)
                {
                    labelTemperaturaValue.ForeColor = Color.Firebrick;
                    labelAlertaTemperatura.ForeColor = Color.Firebrick;
                    labelAlertaTemperatura.Text = "🔥 Está quente! 🔥";
                }
                else
                {
                    labelTemperaturaValue.ForeColor = Color.SeaGreen;
                    labelAlertaTemperatura.ForeColor = Color.SeaGreen;
                    labelAlertaTemperatura.Text = "🌞 Temperatura normal 🌞";
                }

                // Verifica a umidade
                if (Parametros.leitura.umidade < 20)
                {
                    labelUmidadeValue.ForeColor = Color.Goldenrod;
                    labelAlertaUmidade.ForeColor = Color.Goldenrod;
                    labelAlertaUmidade.Text = "🌵 Umidade baixa! 🌵";
                }
                else if (Parametros.leitura.umidade > 60)
                {
                    labelUmidadeValue.ForeColor = Color.SteelBlue;
                    labelAlertaUmidade.ForeColor = Color.SteelBlue;
                    labelAlertaUmidade.Text = "🌧️ Umidade alta! 🌧️";
                }
                else
                {
                    labelUmidadeValue.ForeColor = Color.SeaGreen;
                    labelAlertaUmidade.ForeColor = Color.SeaGreen;
                    labelAlertaUmidade.Text = "🌼 Umidade normal 🌼";
                }

                // Adiciona as informações à lista de leituras
                listBoxUltimasLeituras.Items.Add("🌡️ Temperatura: " + Parametros.leitura.temperatura.ToString() + " °C; 💧 Umidade: " + Parametros.leitura.umidade.ToString() + " %; 📅 Data e horário: " + DateTime.Parse(Parametros.leitura.datahora).ToString("dd/MM/yyyy HH:mm") + ";");

                // Reinicia as variáveis da mensagem e da leitura
                Parametros.mensagem = "";
                Parametros.leitura = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao exibir as informações da leitura.\nPor favor, tente novamente mais tarde.\n\nMensagem do erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            this.conectar();
        }

        private void buttonInscrever_Click(object sender, EventArgs e)
        {
            this.inscrever();
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            this.desconectar();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.sair();
        }

        private void conectar()
        {
            try
            {
                buttonConectar.Text = "🔌 Conectando";

                cliente = new MqttClient(host, porta, false, null, null, MqttSslProtocols.None);

                cliente.Connect(Guid.NewGuid().ToString(), usuario, senha);

                buttonConectar.Text = "🔌 Conectado";
                buttonConectar.Enabled = false;
                buttonInscrever.Enabled = true;
                buttonDesconectar.Text = "🔌 Desconectar";
                buttonDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao conectar ao host " + host + ".\nPor favor, tente novamente mais tarde.\n\nMensagem do erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void inscrever()
        {
            try
            {
                buttonInscrever.Text = "📝 Inscrevendo";
                cliente.MqttMsgPublishReceived += this.MqttMsgPublishReceived;

                string[] topicos = { topico };
                byte[] nivelQoS = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };

                cliente.Subscribe(topicos, nivelQoS);

                buttonInscrever.Text = "📝 Inscrito";
                buttonInscrever.Enabled = false;
                buttonConectar.Enabled = false;
                buttonDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao inscrever no tópico " + topico + ".\nPor favor, tente novamente mais tarde.\n\nMensagem do erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void desconectar()
        {
            try
            {
                buttonDesconectar.Text = "🔌 Desconectando";

                cliente.Disconnect();

                buttonDesconectar.Text = "🔌 Desconectado";
                buttonDesconectar.Enabled = false;
                buttonConectar.Text = "🔌 Conectar";
                buttonConectar.Enabled = true;
                buttonInscrever.Text = "📝 Inscrever";
                buttonInscrever.Enabled = false;
            } catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao desconectar do host " + host + ".\nPor favor, tente novamente mais tarde.\n\nMensagem do erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void sair()
        {
            Environment.Exit(0);
        }

        private void MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                Parametros.mensagem = Encoding.UTF8.GetString(e.Message);
                Parametros.leitura = JsonConvert.DeserializeObject<Leitura>(Parametros.mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao processar os dados da leitura.\nPor favor, tente novamente mais tarde.\n\nMensagem do erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
