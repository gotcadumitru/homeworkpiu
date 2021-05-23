namespace Firma_Wind_Forms
{
    partial class Form1
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
            this.gpbProgrameStudiu = new System.Windows.Forms.GroupBox();
            this.rdbAvion = new System.Windows.Forms.RadioButton();
            this.rdbTanc = new System.Windows.Forms.RadioButton();
            this.rdbBicicleta = new System.Windows.Forms.RadioButton();
            this.rdbMotocicleta = new System.Windows.Forms.RadioButton();
            this.rdbAutomobil = new System.Windows.Forms.RadioButton();
            this.rdbTrotineta = new System.Windows.Forms.RadioButton();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.rtbAfisare = new System.Windows.Forms.RichTextBox();
            this.txtNumeFirma = new System.Windows.Forms.TextBox();
            this.btnAdaugaFirma = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtLogoUrl = new System.Windows.Forms.TextBox();
            this.lblNumeFirma = new System.Windows.Forms.Label();
            this.txtRaiting = new System.Windows.Forms.TextBox();
            this.lblRaiting = new System.Windows.Forms.Label();
            this.lblNumeLivrator = new System.Windows.Forms.Label();
            this.txtPrenumeLivrator = new System.Windows.Forms.TextBox();
            this.txtNumeLivrator = new System.Windows.Forms.TextBox();
            this.lblPrenumeLivrator = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.btnAdaugaLivrator = new System.Windows.Forms.Button();
            this.timer1 = new System.Timers.Timer();
            this.txtFirmaError = new System.Windows.Forms.Label();
            this.btnAfisareFirme = new System.Windows.Forms.Button();
            this.gpbProgrameStudiu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbProgrameStudiu
            // 
            this.gpbProgrameStudiu.Controls.Add(this.rdbAvion);
            this.gpbProgrameStudiu.Controls.Add(this.rdbTanc);
            this.gpbProgrameStudiu.Controls.Add(this.rdbBicicleta);
            this.gpbProgrameStudiu.Controls.Add(this.rdbMotocicleta);
            this.gpbProgrameStudiu.Controls.Add(this.rdbAutomobil);
            this.gpbProgrameStudiu.Controls.Add(this.rdbTrotineta);
            this.gpbProgrameStudiu.Location = new System.Drawing.Point(115, 267);
            this.gpbProgrameStudiu.Name = "gpbProgrameStudiu";
            this.gpbProgrameStudiu.Size = new System.Drawing.Size(193, 84);
            this.gpbProgrameStudiu.TabIndex = 40;
            this.gpbProgrameStudiu.TabStop = false;
            // 
            // rdbAvion
            // 
            this.rdbAvion.AutoSize = true;
            this.rdbAvion.Location = new System.Drawing.Point(105, 55);
            this.rdbAvion.Name = "rdbAvion";
            this.rdbAvion.Size = new System.Drawing.Size(52, 17);
            this.rdbAvion.TabIndex = 13;
            this.rdbAvion.TabStop = true;
            this.rdbAvion.Text = "Avion";
            this.rdbAvion.UseVisualStyleBackColor = true;
            // 
            // rdbTanc
            // 
            this.rdbTanc.AutoSize = true;
            this.rdbTanc.Location = new System.Drawing.Point(15, 55);
            this.rdbTanc.Name = "rdbTanc";
            this.rdbTanc.Size = new System.Drawing.Size(50, 17);
            this.rdbTanc.TabIndex = 12;
            this.rdbTanc.TabStop = true;
            this.rdbTanc.Text = "Tanc";
            this.rdbTanc.UseVisualStyleBackColor = true;
            // 
            // rdbBicicleta
            // 
            this.rdbBicicleta.AutoSize = true;
            this.rdbBicicleta.Location = new System.Drawing.Point(15, 32);
            this.rdbBicicleta.Name = "rdbBicicleta";
            this.rdbBicicleta.Size = new System.Drawing.Size(65, 17);
            this.rdbBicicleta.TabIndex = 10;
            this.rdbBicicleta.TabStop = true;
            this.rdbBicicleta.Text = "Bicicleta";
            this.rdbBicicleta.UseVisualStyleBackColor = true;
            // 
            // rdbMotocicleta
            // 
            this.rdbMotocicleta.AutoSize = true;
            this.rdbMotocicleta.Location = new System.Drawing.Point(105, 32);
            this.rdbMotocicleta.Name = "rdbMotocicleta";
            this.rdbMotocicleta.Size = new System.Drawing.Size(80, 17);
            this.rdbMotocicleta.TabIndex = 11;
            this.rdbMotocicleta.TabStop = true;
            this.rdbMotocicleta.Text = "Motocicleta";
            this.rdbMotocicleta.UseVisualStyleBackColor = true;
            // 
            // rdbAutomobil
            // 
            this.rdbAutomobil.AutoSize = true;
            this.rdbAutomobil.Location = new System.Drawing.Point(15, 9);
            this.rdbAutomobil.Name = "rdbAutomobil";
            this.rdbAutomobil.Size = new System.Drawing.Size(71, 17);
            this.rdbAutomobil.TabIndex = 8;
            this.rdbAutomobil.TabStop = true;
            this.rdbAutomobil.Text = "Automobil";
            this.rdbAutomobil.UseVisualStyleBackColor = true;
            // 
            // rdbTrotineta
            // 
            this.rdbTrotineta.AutoSize = true;
            this.rdbTrotineta.Location = new System.Drawing.Point(105, 9);
            this.rdbTrotineta.Name = "rdbTrotineta";
            this.rdbTrotineta.Size = new System.Drawing.Size(67, 17);
            this.rdbTrotineta.TabIndex = 9;
            this.rdbTrotineta.TabStop = true;
            this.rdbTrotineta.Text = "Trotineta";
            this.rdbTrotineta.UseVisualStyleBackColor = true;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(102, 347);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 37;
            // 
            // rtbAfisare
            // 
            this.rtbAfisare.Location = new System.Drawing.Point(358, 30);
            this.rtbAfisare.Margin = new System.Windows.Forms.Padding(2);
            this.rtbAfisare.Name = "rtbAfisare";
            this.rtbAfisare.Size = new System.Drawing.Size(310, 286);
            this.rtbAfisare.TabIndex = 35;
            this.rtbAfisare.Text = "Lista firme";
            // 
            // txtNumeFirma
            // 
            this.txtNumeFirma.Location = new System.Drawing.Point(110, 30);
            this.txtNumeFirma.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeFirma.Name = "txtNumeFirma";
            this.txtNumeFirma.Size = new System.Drawing.Size(193, 20);
            this.txtNumeFirma.TabIndex = 31;
            // 
            // btnAdaugaFirma
            // 
            this.btnAdaugaFirma.Location = new System.Drawing.Point(115, 157);
            this.btnAdaugaFirma.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugaFirma.Name = "btnAdaugaFirma";
            this.btnAdaugaFirma.Size = new System.Drawing.Size(93, 23);
            this.btnAdaugaFirma.TabIndex = 30;
            this.btnAdaugaFirma.Text = "Adauga Firma";
            this.btnAdaugaFirma.UseVisualStyleBackColor = true;
            this.btnAdaugaFirma.Click += new System.EventHandler(this.btnAdaugaFirma_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(17, 62);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(52, 13);
            this.lblLogo.TabIndex = 28;
            this.lblLogo.Text = "*Logo url:";
            // 
            // txtLogoUrl
            // 
            this.txtLogoUrl.Location = new System.Drawing.Point(110, 59);
            this.txtLogoUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogoUrl.Name = "txtLogoUrl";
            this.txtLogoUrl.Size = new System.Drawing.Size(193, 20);
            this.txtLogoUrl.TabIndex = 43;
            // 
            // lblNumeFirma
            // 
            this.lblNumeFirma.AutoSize = true;
            this.lblNumeFirma.Location = new System.Drawing.Point(17, 33);
            this.lblNumeFirma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeFirma.Name = "lblNumeFirma";
            this.lblNumeFirma.Size = new System.Drawing.Size(67, 13);
            this.lblNumeFirma.TabIndex = 44;
            this.lblNumeFirma.Text = "*Nume Firma";
            // 
            // txtRaiting
            // 
            this.txtRaiting.Location = new System.Drawing.Point(110, 91);
            this.txtRaiting.Margin = new System.Windows.Forms.Padding(2);
            this.txtRaiting.Name = "txtRaiting";
            this.txtRaiting.Size = new System.Drawing.Size(193, 20);
            this.txtRaiting.TabIndex = 46;
            // 
            // lblRaiting
            // 
            this.lblRaiting.AutoSize = true;
            this.lblRaiting.Location = new System.Drawing.Point(17, 94);
            this.lblRaiting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaiting.Name = "lblRaiting";
            this.lblRaiting.Size = new System.Drawing.Size(43, 13);
            this.lblRaiting.TabIndex = 45;
            this.lblRaiting.Text = "Raiting:";
            // 
            // lblNumeLivrator
            // 
            this.lblNumeLivrator.AutoSize = true;
            this.lblNumeLivrator.Location = new System.Drawing.Point(22, 214);
            this.lblNumeLivrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeLivrator.Name = "lblNumeLivrator";
            this.lblNumeLivrator.Size = new System.Drawing.Size(80, 13);
            this.lblNumeLivrator.TabIndex = 50;
            this.lblNumeLivrator.Text = "*Nume Livrator:";
            // 
            // txtPrenumeLivrator
            // 
            this.txtPrenumeLivrator.Location = new System.Drawing.Point(115, 240);
            this.txtPrenumeLivrator.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenumeLivrator.Name = "txtPrenumeLivrator";
            this.txtPrenumeLivrator.Size = new System.Drawing.Size(193, 20);
            this.txtPrenumeLivrator.TabIndex = 49;
            // 
            // txtNumeLivrator
            // 
            this.txtNumeLivrator.Location = new System.Drawing.Point(115, 211);
            this.txtNumeLivrator.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeLivrator.Name = "txtNumeLivrator";
            this.txtNumeLivrator.Size = new System.Drawing.Size(193, 20);
            this.txtNumeLivrator.TabIndex = 48;
            // 
            // lblPrenumeLivrator
            // 
            this.lblPrenumeLivrator.AutoSize = true;
            this.lblPrenumeLivrator.Location = new System.Drawing.Point(22, 243);
            this.lblPrenumeLivrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenumeLivrator.Name = "lblPrenumeLivrator";
            this.lblPrenumeLivrator.Size = new System.Drawing.Size(94, 13);
            this.lblPrenumeLivrator.TabIndex = 47;
            this.lblPrenumeLivrator.Text = "*Prenume Livrator:";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(22, 280);
            this.lblTransport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(59, 13);
            this.lblTransport.TabIndex = 51;
            this.lblTransport.Text = "*Transport:";
            // 
            // btnAdaugaLivrator
            // 
            this.btnAdaugaLivrator.Location = new System.Drawing.Point(215, 356);
            this.btnAdaugaLivrator.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugaLivrator.Name = "btnAdaugaLivrator";
            this.btnAdaugaLivrator.Size = new System.Drawing.Size(93, 23);
            this.btnAdaugaLivrator.TabIndex = 52;
            this.btnAdaugaLivrator.Text = "Adauga Livrator";
            this.btnAdaugaLivrator.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            // 
            // txtFirmaError
            // 
            this.txtFirmaError.ForeColor = System.Drawing.Color.Red;
            this.txtFirmaError.Location = new System.Drawing.Point(19, 115);
            this.txtFirmaError.Name = "txtFirmaError";
            this.txtFirmaError.Size = new System.Drawing.Size(323, 28);
            this.txtFirmaError.TabIndex = 53;
            this.txtFirmaError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAfisareFirme
            // 
            this.btnAfisareFirme.Location = new System.Drawing.Point(212, 157);
            this.btnAfisareFirme.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfisareFirme.Name = "btnAfisareFirme";
            this.btnAfisareFirme.Size = new System.Drawing.Size(93, 23);
            this.btnAfisareFirme.TabIndex = 54;
            this.btnAfisareFirme.Text = "Afisare Firme";
            this.btnAfisareFirme.UseVisualStyleBackColor = true;
            this.btnAfisareFirme.Click += new System.EventHandler(this.btnAfisareFirme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(730, 488);
            this.Controls.Add(this.btnAfisareFirme);
            this.Controls.Add(this.txtFirmaError);
            this.Controls.Add(this.btnAdaugaLivrator);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.lblNumeLivrator);
            this.Controls.Add(this.txtPrenumeLivrator);
            this.Controls.Add(this.txtNumeLivrator);
            this.Controls.Add(this.lblPrenumeLivrator);
            this.Controls.Add(this.txtRaiting);
            this.Controls.Add(this.lblRaiting);
            this.Controls.Add(this.lblNumeFirma);
            this.Controls.Add(this.txtLogoUrl);
            this.Controls.Add(this.gpbProgrameStudiu);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.rtbAfisare);
            this.Controls.Add(this.txtNumeFirma);
            this.Controls.Add(this.btnAdaugaFirma);
            this.Controls.Add(this.lblLogo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.gpbProgrameStudiu.ResumeLayout(false);
            this.gpbProgrameStudiu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAfisareFirme;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label txtFirmaError;

        private System.Windows.Forms.Label label1;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Button btnAdaugaFirma;

        private System.Windows.Forms.Button btnAdaugaLivrator;

        private System.Windows.Forms.Label lblPrenumeLivrator;

        private System.Windows.Forms.TextBox txtNumeLivrator;

        private System.Windows.Forms.TextBox txtPrenumeLivrator;

        private System.Windows.Forms.TextBox txtLogoUrl;
        private System.Windows.Forms.Label lblNumeFirma;
        private System.Windows.Forms.TextBox txtRaiting;
        private System.Windows.Forms.Label lblRaiting;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblNumeLivrator;

        private System.Windows.Forms.Label lblLogo;

        private System.Windows.Forms.RadioButton rdbBicicleta;

        private System.Windows.Forms.RadioButton rdbTanc;
        private System.Windows.Forms.RadioButton rdbAvion;

        private System.Windows.Forms.RadioButton rdbMotocicleta;

        private System.Windows.Forms.RadioButton rdbTrotineta;

        private System.Windows.Forms.RadioButton rdbAutomobil;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox gpbProgrameStudiu;
        private System.Windows.Forms.RadioButton rdbElectronica;
        private System.Windows.Forms.RadioButton rdbElectrotehnica;
        private System.Windows.Forms.RadioButton rdbCalculatoare;
        private System.Windows.Forms.RadioButton rdbAutomatica;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.RichTextBox rtbAfisare;
        private System.Windows.Forms.TextBox txtNumeFirma;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;

        #endregion
    }
}