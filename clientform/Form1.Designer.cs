
namespace clientform
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMessaggiServ = new System.Windows.Forms.ListBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnetti = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMessaggiServ
            // 
            this.lstMessaggiServ.FormattingEnabled = true;
            this.lstMessaggiServ.Location = new System.Drawing.Point(11, 90);
            this.lstMessaggiServ.Margin = new System.Windows.Forms.Padding(2);
            this.lstMessaggiServ.Name = "lstMessaggiServ";
            this.lstMessaggiServ.Size = new System.Drawing.Size(468, 277);
            this.lstMessaggiServ.TabIndex = 17;
            // 
            // btnInvia
            // 
            this.btnInvia.Enabled = false;
            this.btnInvia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInvia.Location = new System.Drawing.Point(284, 44);
            this.btnInvia.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(56, 26);
            this.btnInvia.TabIndex = 16;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Enabled = false;
            this.txtMessaggio.Location = new System.Drawing.Point(76, 49);
            this.txtMessaggio.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(191, 20);
            this.txtMessaggio.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Messaggio:";
            // 
            // btnConnetti
            // 
            this.btnConnetti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnetti.Location = new System.Drawing.Point(284, 11);
            this.btnConnetti.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(56, 27);
            this.btnConnetti.TabIndex = 13;
            this.btnConnetti.Text = "Connetti";
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(190, 15);
            this.txtPorta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(76, 20);
            this.txtPorta.TabIndex = 12;
            this.txtPorta.Text = "23000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Porta";
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(63, 15);
            this.txtIPServer.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(76, 20);
            this.txtIPServer.TabIndex = 10;
            this.txtIPServer.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(493, 379);
            this.Controls.Add(this.lstMessaggiServ);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnetti);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMessaggiServ;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label label1;
    }
}

