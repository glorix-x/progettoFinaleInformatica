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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbOreM = new ComboBox();
            rtbDescrizioneM = new RichTextBox();
            tbTitoloM = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 283);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 15;
            label3.Text = "Durata Ore:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 25);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "Titolo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 90);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 13;
            label1.Text = "Descrizione:";
            // 
            // cbOreM
            // 
            cbOreM.FormattingEnabled = true;
            cbOreM.Location = new Point(98, 306);
            cbOreM.Name = "cbOreM";
            cbOreM.Size = new Size(151, 28);
            cbOreM.TabIndex = 12;
            // 
            // rtbDescrizioneM
            // 
            rtbDescrizioneM.Location = new Point(26, 113);
            rtbDescrizioneM.Name = "rtbDescrizioneM";
            rtbDescrizioneM.Size = new Size(304, 154);
            rtbDescrizioneM.TabIndex = 11;
            rtbDescrizioneM.Text = "";
            // 
            // tbTitoloM
            // 
            tbTitoloM.Location = new Point(98, 48);
            tbTitoloM.Name = "tbTitoloM";
            tbTitoloM.Size = new Size(151, 27);
            tbTitoloM.TabIndex = 10;
            // 
            // UserControlModifica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbOreM);
            Controls.Add(rtbDescrizioneM);
            Controls.Add(tbTitoloM);
            Name = "UserControlModifica";
            Size = new Size(367, 377);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbOreM;
        private RichTextBox rtbDescrizioneM;
        private TextBox tbTitoloM;
    }
}
