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
            cbRipetere = new CheckBox();
            txtGiorniDaRipetere = new TextBox();
            label3 = new Label();
            cbTipoRicorrenza = new ComboBox();
            SuspendLayout();
            // 
            // txtTitolo
            // 
            txtTitolo.Location = new Point(206, 68);
            txtTitolo.Margin = new Padding(2);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(150, 31);
            txtTitolo.TabIndex = 0;
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(246, 26);
            lblTitolo.Margin = new Padding(2, 0, 2, 0);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(61, 25);
            lblTitolo.TabIndex = 1;
            lblTitolo.Text = "Titolo:";
            // 
            // rtbDescrizione
            // 
            rtbDescrizione.Location = new Point(94, 162);
            rtbDescrizione.Margin = new Padding(2);
            rtbDescrizione.Name = "rtbDescrizione";
            rtbDescrizione.Size = new Size(384, 162);
            rtbDescrizione.TabIndex = 2;
            rtbDescrizione.Text = "";
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Location = new Point(224, 120);
            lblDescrizione.Margin = new Padding(2, 0, 2, 0);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(106, 25);
            lblDescrizione.TabIndex = 3;
            lblDescrizione.Text = "Descrizione:";
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(94, 342);
            lblDurata.Margin = new Padding(2, 0, 2, 0);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(119, 25);
            lblDurata.TabIndex = 5;
            lblDurata.Text = "Durata in ore:";
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(338, 445);
            btnSalva.Margin = new Padding(2);
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
            cbDurata.Location = new Point(58, 385);
            cbDurata.Margin = new Padding(2);
            cbDurata.Name = "cbDurata";
            cbDurata.Size = new Size(182, 33);
            cbDurata.TabIndex = 7;
            // 
            // lblColore
            // 
            lblColore.AutoSize = true;
            lblColore.Location = new Point(375, 342);
            lblColore.Margin = new Padding(2, 0, 2, 0);
            lblColore.Name = "lblColore";
            lblColore.Size = new Size(68, 25);
            lblColore.TabIndex = 8;
            lblColore.Text = "Colore:";
            // 
            // cbColore
            // 
            cbColore.FormattingEnabled = true;
            cbColore.Location = new Point(324, 385);
            cbColore.Margin = new Padding(2);
            cbColore.Name = "cbColore";
            cbColore.Size = new Size(182, 33);
            cbColore.TabIndex = 9;
            // 
            // cbRipetere
            // 
            cbRipetere.AutoSize = true;
            cbRipetere.Location = new Point(580, 153);
            cbRipetere.Margin = new Padding(2);
            cbRipetere.Name = "cbRipetere";
            cbRipetere.Size = new Size(103, 29);
            cbRipetere.TabIndex = 10;
            cbRipetere.Text = "Ripetere";
            cbRipetere.UseVisualStyleBackColor = true;
            cbRipetere.CheckedChanged += cbRipetere_CheckedChanged;
            // 
            // txtGiorniDaRipetere
            // 
            txtGiorniDaRipetere.Location = new Point(516, 248);
            txtGiorniDaRipetere.Margin = new Padding(2);
            txtGiorniDaRipetere.Name = "txtGiorniDaRipetere";
            txtGiorniDaRipetere.Size = new Size(111, 31);
            txtGiorniDaRipetere.TabIndex = 11;
            txtGiorniDaRipetere.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(580, 206);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 23;
            label3.Text = "Ogni quanto?";
            label3.Visible = false;
            // 
            // cbTipoRicorrenza
            // 
            cbTipoRicorrenza.FormattingEnabled = true;
            cbTipoRicorrenza.Location = new Point(657, 248);
            cbTipoRicorrenza.Name = "cbTipoRicorrenza";
            cbTipoRicorrenza.Size = new Size(122, 33);
            cbTipoRicorrenza.TabIndex = 24;
            cbTipoRicorrenza.Visible = false;
            // 
            // FormCreazioneImpegno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(cbTipoRicorrenza);
            Controls.Add(label3);
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
            Load += FormCreazioneImpegno_Load;
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
        private Label label3;
        private ComboBox cbTipoRicorrenza;
    }
}