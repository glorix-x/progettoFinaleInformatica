namespace ProgettoFinaleInformatica
{
    partial class UserControlModifica
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            rtbDescrizioneM = new RichTextBox();
            tbTitoloM = new TextBox();
            label4 = new Label();
            cbColore = new ComboBox();
            cbDurata = new ComboBox();
            lblDurata = new Label();
            cbRipeti = new CheckBox();
            tbRipeti = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 26);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "Titolo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 91);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 13;
            label1.Text = "Descrizione:";
            // 
            // rtbDescrizioneM
            // 
            rtbDescrizioneM.Location = new Point(91, 114);
            rtbDescrizioneM.Name = "rtbDescrizioneM";
            rtbDescrizioneM.Size = new Size(304, 154);
            rtbDescrizioneM.TabIndex = 11;
            rtbDescrizioneM.Text = "";
            // 
            // tbTitoloM
            // 
            tbTitoloM.Location = new Point(163, 49);
            tbTitoloM.Name = "tbTitoloM";
            tbTitoloM.Size = new Size(151, 27);
            tbTitoloM.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 278);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 16;
            label4.Text = "Modifica il colore:";
            // 
            // cbColore
            // 
            cbColore.FormattingEnabled = true;
            cbColore.Location = new Point(268, 312);
            cbColore.Name = "cbColore";
            cbColore.Size = new Size(151, 28);
            cbColore.TabIndex = 17;
            // 
            // cbDurata
            // 
            cbDurata.FormattingEnabled = true;
            cbDurata.Location = new Point(62, 312);
            cbDurata.Margin = new Padding(2);
            cbDurata.Name = "cbDurata";
            cbDurata.Size = new Size(146, 28);
            cbDurata.TabIndex = 19;
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(90, 278);
            lblDurata.Margin = new Padding(2, 0, 2, 0);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(99, 20);
            lblDurata.TabIndex = 18;
            lblDurata.Text = "Durata in ore:";
            // 
            // cbRipeti
            // 
            cbRipeti.AutoSize = true;
            cbRipeti.Location = new Point(476, 87);
            cbRipeti.Name = "cbRipeti";
            cbRipeti.Size = new Size(70, 24);
            cbRipeti.TabIndex = 20;
            cbRipeti.Text = "Ripeti";
            cbRipeti.UseVisualStyleBackColor = true;
            cbRipeti.CheckedChanged += cbRipeti_CheckedChanged_1;
            // 
            // tbRipeti
            // 
            tbRipeti.Location = new Point(453, 181);
            tbRipeti.Name = "tbRipeti";
            tbRipeti.Size = new Size(125, 27);
            tbRipeti.TabIndex = 21;
            tbRipeti.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 144);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 22;
            label3.Text = "Ogni quanti giorni?";
            label3.Visible = false;
            // 
            // UserControlModifica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(tbRipeti);
            Controls.Add(cbRipeti);
            Controls.Add(cbDurata);
            Controls.Add(lblDurata);
            Controls.Add(cbColore);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbDescrizioneM);
            Controls.Add(tbTitoloM);
            Name = "UserControlModifica";
            Size = new Size(644, 377);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private RichTextBox rtbDescrizioneM;
        private TextBox tbTitoloM;
        private Label label4;
        private ComboBox cbColore;
        private ComboBox cbDurata;
        private Label lblDurata;
        private CheckBox cbRipeti;
        private TextBox tbRipeti;
        private Label label3;
    }
}
