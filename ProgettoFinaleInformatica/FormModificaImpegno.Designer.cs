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
            btSalvaM = new Button();
            btElliminaM = new Button();
            ucModifica = new UserControlModifica();
            SuspendLayout();
            // 
            // btSalvaM
            // 
            btSalvaM.Location = new Point(56, 368);
            btSalvaM.Name = "btSalvaM";
            btSalvaM.Size = new Size(200, 46);
            btSalvaM.TabIndex = 3;
            btSalvaM.Text = "Salva";
            btSalvaM.UseVisualStyleBackColor = true;
            btSalvaM.Click += btSalvaM_Click;
            // 
            // btElliminaM
            // 
            btElliminaM.Location = new Point(451, 368);
            btElliminaM.Name = "btElliminaM";
            btElliminaM.Size = new Size(180, 46);
            btElliminaM.TabIndex = 4;
            btElliminaM.Text = "Elimina";
            btElliminaM.UseVisualStyleBackColor = true;
            btElliminaM.Click += btElliminaM_Click;
            // 
            // ucModifica
            // 
            ucModifica.Location = new Point(137, -4);
            ucModifica.Name = "ucModifica";
            ucModifica.Size = new Size(463, 366);
            ucModifica.TabIndex = 5;
            // 
            // FormModificaImpegno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 445);
            Controls.Add(ucModifica);
            Controls.Add(btElliminaM);
            Controls.Add(btSalvaM);
            Margin = new Padding(2);
            Name = "FormModificaImpegno";
            Text = "FormModificaImpegno";
            ResumeLayout(false);
        }

        #endregion
        private Button btSalvaM;
        private Button btElliminaM;
        private UserControlModifica ucModifica;
    }
}