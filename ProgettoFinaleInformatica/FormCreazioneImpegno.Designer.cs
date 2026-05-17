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
        private void InitializeComponent()
        {
            txtTitolo = new TextBox();
            lblTitolo = new Label();
            rtbDescrizione = new RichTextBox();
            lblDescrizione = new Label();
            lblDurata = new Label();
            btnSalva = new Button();
            cbDurata = new ComboBox();
            lblColore = new Label();
            cbColore = new ComboBox();
            cbRipetere = new CheckBox();
            txtGiorniDaRipetere = new TextBox();
            SuspendLayout();
            // 
            // txtTitolo
            // 
            txtTitolo.Location = new Point(165, 54);
            txtTitolo.Margin = new Padding(2);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(121, 27);
            txtTitolo.TabIndex = 0;
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(197, 21);
            lblTitolo.Margin = new Padding(2, 0, 2, 0);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(51, 20);
            lblTitolo.TabIndex = 1;
            lblTitolo.Text = "Titolo:";
            // 
            // rtbDescrizione
            // 
            rtbDescrizione.Location = new Point(75, 130);
            rtbDescrizione.Margin = new Padding(2);
            rtbDescrizione.Name = "rtbDescrizione";
            rtbDescrizione.Size = new Size(308, 130);
            rtbDescrizione.TabIndex = 2;
            rtbDescrizione.Text = "";
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Location = new Point(179, 96);
            lblDescrizione.Margin = new Padding(2, 0, 2, 0);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(89, 20);
            lblDescrizione.TabIndex = 3;
            lblDescrizione.Text = "Descrizione:";
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(75, 274);
            lblDurata.Margin = new Padding(2, 0, 2, 0);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(99, 20);
            lblDurata.TabIndex = 5;
            lblDurata.Text = "Durata in ore:";
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(270, 356);
            btnSalva.Margin = new Padding(2);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(90, 27);
            btnSalva.TabIndex = 6;
            btnSalva.Text = "SALVA";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // cbDurata
            // 
            cbDurata.FormattingEnabled = true;
            cbDurata.Location = new Point(46, 308);
            cbDurata.Margin = new Padding(2);
            cbDurata.Name = "cbDurata";
            cbDurata.Size = new Size(146, 28);
            cbDurata.TabIndex = 7;
            // 
            // lblColore
            // 
            lblColore.AutoSize = true;
            lblColore.Location = new Point(300, 274);
            lblColore.Margin = new Padding(2, 0, 2, 0);
            lblColore.Name = "lblColore";
            lblColore.Size = new Size(56, 20);
            lblColore.TabIndex = 8;
            lblColore.Text = "Colore:";
            // 
            // cbColore
            // 
            cbColore.FormattingEnabled = true;
            cbColore.Location = new Point(259, 308);
            cbColore.Margin = new Padding(2);
            cbColore.Name = "cbColore";
            cbColore.Size = new Size(146, 28);
            cbColore.TabIndex = 9;
            // 
            // cbRipetere
            // 
            cbRipetere.AutoSize = true;
            cbRipetere.Location = new Point(470, 69);
            cbRipetere.Margin = new Padding(2, 2, 2, 2);
            cbRipetere.Name = "cbRipetere";
            cbRipetere.Size = new Size(87, 24);
            cbRipetere.TabIndex = 10;
            cbRipetere.Text = "Ripetere";
            cbRipetere.UseVisualStyleBackColor = true;
            // 
            // txtGiorniDaRipetere
            // 
            txtGiorniDaRipetere.Location = new Point(446, 112);
            txtGiorniDaRipetere.Margin = new Padding(2, 2, 2, 2);
            txtGiorniDaRipetere.Name = "txtGiorniDaRipetere";
            txtGiorniDaRipetere.Size = new Size(121, 27);
            txtGiorniDaRipetere.TabIndex = 11;
            // 
            // FormCreazioneImpegno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 417);
            Controls.Add(txtGiorniDaRipetere);
            Controls.Add(cbRipetere);
            Controls.Add(cbColore);
            Controls.Add(lblColore);
            Controls.Add(cbDurata);
            Controls.Add(btnSalva);
            Controls.Add(lblDurata);
            Controls.Add(lblDescrizione);
            Controls.Add(rtbDescrizione);
            Controls.Add(lblTitolo);
            Controls.Add(txtTitolo);
            Margin = new Padding(2);
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
        private CheckBox cbRipetere;
        private TextBox txtGiorniDaRipetere;
    }
}