namespace ProgettoFinaleInformatica
{
    partial class FormHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pibble = new PictureBox();
            pbHome = new ProgressBar();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pibble).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 87);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Calendario intelligente";
            // 
            // pibble
            // 
            pibble.Location = new Point(26, 343);
            pibble.Name = "pibble";
            pibble.Size = new Size(191, 130);
            pibble.TabIndex = 1;
            pibble.TabStop = false;
            // 
            // pbHome
            // 
            pbHome.Location = new Point(268, 343);
            pbHome.Name = "pbHome";
            pbHome.Size = new Size(718, 29);
            pbHome.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(452, 259);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(351, 57);
            btnStart.TabIndex = 3;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick_1;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 500);
            Controls.Add(btnStart);
            Controls.Add(pbHome);
            Controls.Add(pibble);
            Controls.Add(label1);
            Name = "FormHome";
            Text = "\\";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)pibble).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pibble;
        private ProgressBar pbHome;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}