namespace ProgettoFinaleInformatica {
    partial class FormModificaImpegno {
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
            tbTitoloM = new TextBox();
            btSalvaM = new Button();
            btElliminaM = new Button();
            rtbDescrizioneM = new RichTextBox();
            cbOreM = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbTitoloM
            // 
            tbTitoloM.Location = new Point(237, 51);
            tbTitoloM.Name = "tbTitoloM";
            tbTitoloM.Size = new Size(151, 27);
            tbTitoloM.TabIndex = 0;
            // 
            // btSalvaM
            // 
            btSalvaM.Location = new Point(56, 368);
            btSalvaM.Name = "btSalvaM";
            btSalvaM.Size = new Size(200, 46);
            btSalvaM.TabIndex = 3;
            btSalvaM.Text = "Salva";
            btSalvaM.UseVisualStyleBackColor = true;
            // 
            // btElliminaM
            // 
            btElliminaM.Location = new Point(379, 368);
            btElliminaM.Name = "btElliminaM";
            btElliminaM.Size = new Size(180, 46);
            btElliminaM.TabIndex = 4;
            btElliminaM.Text = "Ellimina";
            btElliminaM.UseVisualStyleBackColor = true;
            // 
            // rtbDescrizioneM
            // 
            rtbDescrizioneM.Location = new Point(165, 116);
            rtbDescrizioneM.Name = "rtbDescrizioneM";
            rtbDescrizioneM.Size = new Size(304, 154);
            rtbDescrizioneM.TabIndex = 5;
            rtbDescrizioneM.Text = "";
            // 
            // cbOreM
            // 
            cbOreM.FormattingEnabled = true;
            cbOreM.Location = new Point(237, 309);
            cbOreM.Name = "cbOreM";
            cbOreM.Size = new Size(151, 28);
            cbOreM.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 93);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "Descrizione:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 28);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Titolo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 286);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 9;
            label3.Text = "Durata Ore:";
            // 
            // FormModificaImpegno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 445);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbOreM);
            Controls.Add(rtbDescrizioneM);
            Controls.Add(btElliminaM);
            Controls.Add(btSalvaM);
            Controls.Add(tbTitoloM);
            Margin = new Padding(2);
            Name = "FormModificaImpegno";
            Text = "FormModificaImpegno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitoloM;
        private Button btSalvaM;
        private Button btElliminaM;
        private RichTextBox rtbDescrizioneM;
        private ComboBox cbOreM;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}