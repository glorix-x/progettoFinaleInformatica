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
        private void InitializeComponent() {
            btSalvaM = new Button();
            btEliminaM = new Button();
            ucModifica = new UserControlModifica();
            SuspendLayout();
            // 
            // btSalvaM
            // 
            btSalvaM.Location = new Point(70, 460);
            btSalvaM.Margin = new Padding(4, 4, 4, 4);
            btSalvaM.Name = "btSalvaM";
            btSalvaM.Size = new Size(250, 58);
            btSalvaM.TabIndex = 3;
            btSalvaM.Text = "Salva";
            btSalvaM.UseVisualStyleBackColor = true;
            btSalvaM.Click += btSalvaM_Click;
            // 
            // btEliminaM
            // 
            btEliminaM.Location = new Point(564, 460);
            btEliminaM.Margin = new Padding(4, 4, 4, 4);
            btEliminaM.Name = "btEliminaM";
            btEliminaM.Size = new Size(225, 58);
            btEliminaM.TabIndex = 4;
            btEliminaM.Text = "Elimina";
            btEliminaM.UseVisualStyleBackColor = true;
            btEliminaM.Click += btEliminaM_Click;
            // 
            // ucModifica
            // 
            ucModifica.Location = new Point(70, -5);
            ucModifica.Margin = new Padding(5, 5, 5, 5);
            ucModifica.Name = "ucModifica";
            ucModifica.Size = new Size(772, 458);
            ucModifica.TabIndex = 5;
            // 
            // FormModificaImpegno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 556);
            Controls.Add(ucModifica);
            Controls.Add(btEliminaM);
            Controls.Add(btSalvaM);
            Margin = new Padding(2);
            Name = "FormModificaImpegno";
            Text = "FormModificaImpegno";
            ResumeLayout(false);
        }

        #endregion
        private Button btSalvaM;
        private Button btEliminaM;
        private UserControlModifica ucModifica;
    }
}