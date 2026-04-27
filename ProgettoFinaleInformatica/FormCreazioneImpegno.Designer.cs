namespace ProgettoFinaleInformatica {
    partial class FormCreazioneImpegno {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtTitolo = new TextBox();
            lblTitolo = new Label();
            rtbDescrizione = new RichTextBox();
            lblDescrizione = new Label();
            txtDurata = new TextBox();
            lblDurata = new Label();
            SuspendLayout();
            // 
            // txtTitolo
            // 
            txtTitolo.Location = new Point(320, 67);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(150, 31);
            txtTitolo.TabIndex = 0;
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(360, 26);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(61, 25);
            lblTitolo.TabIndex = 1;
            lblTitolo.Text = "Titolo:";
            // 
            // rtbDescrizione
            // 
            rtbDescrizione.Location = new Point(207, 159);
            rtbDescrizione.Name = "rtbDescrizione";
            rtbDescrizione.Size = new Size(384, 161);
            rtbDescrizione.TabIndex = 2;
            rtbDescrizione.Text = "";
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Location = new Point(337, 120);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(106, 25);
            lblDescrizione.TabIndex = 3;
            lblDescrizione.Text = "Descrizione:";
            // 
            // txtDurata
            // 
            txtDurata.Location = new Point(320, 376);
            txtDurata.Name = "txtDurata";
            txtDurata.Size = new Size(150, 31);
            txtDurata.TabIndex = 4;
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(337, 336);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(119, 25);
            lblDurata.TabIndex = 5;
            lblDurata.Text = "Durata in ore:";
            // 
            // FormCreazioneImpegno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurata);
            Controls.Add(txtDurata);
            Controls.Add(lblDescrizione);
            Controls.Add(rtbDescrizione);
            Controls.Add(lblTitolo);
            Controls.Add(txtTitolo);
            Name = "FormCreazioneImpegno";
            Text = "FormCreazioneImpegno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitolo;
        private Label lblTitolo;
        private RichTextBox rtbDescrizione;
        private Label lblDescrizione;
        private TextBox txtDurata;
        private Label lblDurata;
    }
}