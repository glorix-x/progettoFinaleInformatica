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
            lblDurata = new Label();
            btnSalva = new Button();
            cbDurata = new ComboBox();
            lblColore = new Label();
            cbColore = new ComboBox();
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
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(207, 342);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(119, 25);
            lblDurata.TabIndex = 5;
            lblDurata.Text = "Durata in ore:";
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(337, 445);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(112, 34);
            btnSalva.TabIndex = 6;
            btnSalva.Text = "SALVA";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // cbDurata
            // 
            cbDurata.FormattingEnabled = true;
            cbDurata.Location = new Point(173, 385);
            cbDurata.Name = "cbDurata";
            cbDurata.Size = new Size(182, 33);
            cbDurata.TabIndex = 7;
            // 
            // lblColore
            // 
            lblColore.AutoSize = true;
            lblColore.Location = new Point(489, 342);
            lblColore.Name = "lblColore";
            lblColore.Size = new Size(68, 25);
            lblColore.TabIndex = 8;
            lblColore.Text = "Colore:";
            // 
            // cbColore
            // 
            cbColore.FormattingEnabled = true;
            cbColore.Location = new Point(437, 385);
            cbColore.Name = "cbColore";
            cbColore.Size = new Size(182, 33);
            cbColore.TabIndex = 9;
            // 
            // FormCreazioneImpegno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(cbColore);
            Controls.Add(lblColore);
            Controls.Add(cbDurata);
            Controls.Add(btnSalva);
            Controls.Add(lblDurata);
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
        private Label lblDurata;
        private Button btnSalva;
        private ComboBox cbDurata;
        private Label lblColore;
        private ComboBox cbColore;
    }
}