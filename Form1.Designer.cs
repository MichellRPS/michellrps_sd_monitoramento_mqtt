namespace michellrps_sd_monitoramento_mqtt
{
    partial class FormMonitoramentoMQTT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUltimaAtualizacaoKey = new System.Windows.Forms.Label();
            this.labelUltimaAtualizacaoValue = new System.Windows.Forms.Label();
            this.labelTemperaturaKey = new System.Windows.Forms.Label();
            this.labelTemperaturaValue = new System.Windows.Forms.Label();
            this.labelUmidadeKey = new System.Windows.Forms.Label();
            this.labelUmidadeValue = new System.Windows.Forms.Label();
            this.labelAlertaTemperatura = new System.Windows.Forms.Label();
            this.labelAlertaUmidade = new System.Windows.Forms.Label();
            this.timerAtualizacao = new System.Windows.Forms.Timer(this.components);
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.buttonInscrever = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelPorta = new System.Windows.Forms.Label();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTopico = new System.Windows.Forms.Label();
            this.textBoxTopico = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.listBoxUltimasLeituras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUltimaAtualizacaoKey
            // 
            this.labelUltimaAtualizacaoKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUltimaAtualizacaoKey.AutoSize = true;
            this.labelUltimaAtualizacaoKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimaAtualizacaoKey.Location = new System.Drawing.Point(11, 532);
            this.labelUltimaAtualizacaoKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUltimaAtualizacaoKey.Name = "labelUltimaAtualizacaoKey";
            this.labelUltimaAtualizacaoKey.Size = new System.Drawing.Size(184, 20);
            this.labelUltimaAtualizacaoKey.TabIndex = 0;
            this.labelUltimaAtualizacaoKey.Text = "🔄 Última atualização:";
            // 
            // labelUltimaAtualizacaoValue
            // 
            this.labelUltimaAtualizacaoValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUltimaAtualizacaoValue.AutoSize = true;
            this.labelUltimaAtualizacaoValue.Location = new System.Drawing.Point(199, 531);
            this.labelUltimaAtualizacaoValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUltimaAtualizacaoValue.Name = "labelUltimaAtualizacaoValue";
            this.labelUltimaAtualizacaoValue.Size = new System.Drawing.Size(147, 21);
            this.labelUltimaAtualizacaoValue.TabIndex = 1;
            this.labelUltimaAtualizacaoValue.Text = "Por favor, aguarde...";
            // 
            // labelTemperaturaKey
            // 
            this.labelTemperaturaKey.AutoSize = true;
            this.labelTemperaturaKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperaturaKey.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTemperaturaKey.Location = new System.Drawing.Point(107, 144);
            this.labelTemperaturaKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemperaturaKey.Name = "labelTemperaturaKey";
            this.labelTemperaturaKey.Size = new System.Drawing.Size(157, 24);
            this.labelTemperaturaKey.TabIndex = 2;
            this.labelTemperaturaKey.Text = "🌡️ Temperatura";
            // 
            // labelTemperaturaValue
            // 
            this.labelTemperaturaValue.AutoSize = true;
            this.labelTemperaturaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperaturaValue.Location = new System.Drawing.Point(106, 168);
            this.labelTemperaturaValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemperaturaValue.Name = "labelTemperaturaValue";
            this.labelTemperaturaValue.Size = new System.Drawing.Size(0, 29);
            this.labelTemperaturaValue.TabIndex = 3;
            this.labelTemperaturaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUmidadeKey
            // 
            this.labelUmidadeKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUmidadeKey.AutoSize = true;
            this.labelUmidadeKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUmidadeKey.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelUmidadeKey.Location = new System.Drawing.Point(558, 144);
            this.labelUmidadeKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUmidadeKey.Name = "labelUmidadeKey";
            this.labelUmidadeKey.Size = new System.Drawing.Size(121, 24);
            this.labelUmidadeKey.TabIndex = 4;
            this.labelUmidadeKey.Text = "💧 Umidade";
            // 
            // labelUmidadeValue
            // 
            this.labelUmidadeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUmidadeValue.AutoSize = true;
            this.labelUmidadeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUmidadeValue.Location = new System.Drawing.Point(556, 168);
            this.labelUmidadeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUmidadeValue.Name = "labelUmidadeValue";
            this.labelUmidadeValue.Size = new System.Drawing.Size(0, 29);
            this.labelUmidadeValue.TabIndex = 5;
            this.labelUmidadeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlertaTemperatura
            // 
            this.labelAlertaTemperatura.AutoSize = true;
            this.labelAlertaTemperatura.BackColor = System.Drawing.Color.AliceBlue;
            this.labelAlertaTemperatura.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAlertaTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlertaTemperatura.Location = new System.Drawing.Point(107, 199);
            this.labelAlertaTemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlertaTemperatura.Name = "labelAlertaTemperatura";
            this.labelAlertaTemperatura.Size = new System.Drawing.Size(0, 20);
            this.labelAlertaTemperatura.TabIndex = 6;
            this.labelAlertaTemperatura.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelAlertaUmidade
            // 
            this.labelAlertaUmidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlertaUmidade.AutoSize = true;
            this.labelAlertaUmidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlertaUmidade.Location = new System.Drawing.Point(558, 199);
            this.labelAlertaUmidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlertaUmidade.Name = "labelAlertaUmidade";
            this.labelAlertaUmidade.Size = new System.Drawing.Size(0, 20);
            this.labelAlertaUmidade.TabIndex = 7;
            this.labelAlertaUmidade.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timerAtualizacao
            // 
            this.timerAtualizacao.Enabled = true;
            this.timerAtualizacao.Interval = 1000;
            this.timerAtualizacao.Tick += new System.EventHandler(this.timerAtualizacao_Tick);
            // 
            // buttonConectar
            // 
            this.buttonConectar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConectar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonConectar.Location = new System.Drawing.Point(12, 86);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(180, 40);
            this.buttonConectar.TabIndex = 8;
            this.buttonConectar.Text = "🔌 Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDesconectar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDesconectar.Enabled = false;
            this.buttonDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconectar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconectar.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonDesconectar.Location = new System.Drawing.Point(398, 86);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(180, 40);
            this.buttonDesconectar.TabIndex = 9;
            this.buttonDesconectar.Text = "🔌 Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = false;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // buttonInscrever
            // 
            this.buttonInscrever.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInscrever.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInscrever.Enabled = false;
            this.buttonInscrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInscrever.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInscrever.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonInscrever.Location = new System.Drawing.Point(205, 86);
            this.buttonInscrever.Name = "buttonInscrever";
            this.buttonInscrever.Size = new System.Drawing.Size(180, 40);
            this.buttonInscrever.TabIndex = 10;
            this.buttonInscrever.Text = "📝 Inscrever";
            this.buttonInscrever.UseVisualStyleBackColor = false;
            this.buttonInscrever.Click += new System.EventHandler(this.buttonInscrever_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSair.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonSair.Location = new System.Drawing.Point(591, 86);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(180, 40);
            this.buttonSair.TabIndex = 11;
            this.buttonSair.Text = "❌ Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHost.Location = new System.Drawing.Point(8, 9);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(42, 21);
            this.labelHost.TabIndex = 12;
            this.labelHost.Text = "Host";
            // 
            // textBoxHost
            // 
            this.textBoxHost.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHost.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHost.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxHost.Location = new System.Drawing.Point(12, 33);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.ReadOnly = true;
            this.textBoxHost.Size = new System.Drawing.Size(180, 29);
            this.textBoxHost.TabIndex = 13;
            // 
            // labelPorta
            // 
            this.labelPorta.AutoSize = true;
            this.labelPorta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelPorta.Location = new System.Drawing.Point(223, 9);
            this.labelPorta.Name = "labelPorta";
            this.labelPorta.Size = new System.Drawing.Size(47, 21);
            this.labelPorta.TabIndex = 14;
            this.labelPorta.Text = "Porta";
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxPorta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPorta.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPorta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxPorta.Location = new System.Drawing.Point(227, 33);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.ReadOnly = true;
            this.textBoxPorta.Size = new System.Drawing.Size(60, 29);
            this.textBoxPorta.TabIndex = 15;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelUsuario.Location = new System.Drawing.Point(318, 9);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 21);
            this.labelUsuario.TabIndex = 16;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelSenha.Location = new System.Drawing.Point(453, 9);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(53, 21);
            this.labelSenha.TabIndex = 17;
            this.labelSenha.Text = "Senha";
            // 
            // labelTopico
            // 
            this.labelTopico.AutoSize = true;
            this.labelTopico.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTopico.Location = new System.Drawing.Point(587, 9);
            this.labelTopico.Name = "labelTopico";
            this.labelTopico.Size = new System.Drawing.Size(56, 21);
            this.labelTopico.TabIndex = 18;
            this.labelTopico.Text = "Tópico";
            // 
            // textBoxTopico
            // 
            this.textBoxTopico.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxTopico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTopico.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxTopico.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxTopico.Location = new System.Drawing.Point(592, 33);
            this.textBoxTopico.Name = "textBoxTopico";
            this.textBoxTopico.ReadOnly = true;
            this.textBoxTopico.Size = new System.Drawing.Size(180, 29);
            this.textBoxTopico.TabIndex = 19;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSenha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxSenha.Location = new System.Drawing.Point(457, 33);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.ReadOnly = true;
            this.textBoxSenha.Size = new System.Drawing.Size(100, 29);
            this.textBoxSenha.TabIndex = 20;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxUsuario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxUsuario.Location = new System.Drawing.Point(322, 33);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 29);
            this.textBoxUsuario.TabIndex = 21;
            // 
            // listBoxUltimasLeituras
            // 
            this.listBoxUltimasLeituras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUltimasLeituras.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxUltimasLeituras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxUltimasLeituras.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxUltimasLeituras.FormattingEnabled = true;
            this.listBoxUltimasLeituras.ItemHeight = 21;
            this.listBoxUltimasLeituras.Location = new System.Drawing.Point(12, 254);
            this.listBoxUltimasLeituras.Name = "listBoxUltimasLeituras";
            this.listBoxUltimasLeituras.Size = new System.Drawing.Size(760, 254);
            this.listBoxUltimasLeituras.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "📃 Últimas Leituras";
            // 
            // FormMonitoramentoMQTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUltimasLeituras);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxTopico);
            this.Controls.Add(this.labelTopico);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxPorta);
            this.Controls.Add(this.labelPorta);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonInscrever);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.labelAlertaUmidade);
            this.Controls.Add(this.labelAlertaTemperatura);
            this.Controls.Add(this.labelUmidadeValue);
            this.Controls.Add(this.labelUmidadeKey);
            this.Controls.Add(this.labelTemperaturaValue);
            this.Controls.Add(this.labelTemperaturaKey);
            this.Controls.Add(this.labelUltimaAtualizacaoValue);
            this.Controls.Add(this.labelUltimaAtualizacaoKey);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMonitoramentoMQTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento MQTT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMonitoramentoMQTT_FormClosed);
            this.Load += new System.EventHandler(this.FormMonitoramentoMQTT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUltimaAtualizacaoKey;
        private System.Windows.Forms.Label labelUltimaAtualizacaoValue;
        private System.Windows.Forms.Label labelTemperaturaKey;
        private System.Windows.Forms.Label labelTemperaturaValue;
        private System.Windows.Forms.Label labelUmidadeKey;
        private System.Windows.Forms.Label labelUmidadeValue;
        private System.Windows.Forms.Label labelAlertaTemperatura;
        private System.Windows.Forms.Label labelAlertaUmidade;
        private System.Windows.Forms.Timer timerAtualizacao;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Button buttonInscrever;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelPorta;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelTopico;
        private System.Windows.Forms.TextBox textBoxTopico;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.ListBox listBoxUltimasLeituras;
        private System.Windows.Forms.Label label1;
    }
}

