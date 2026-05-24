namespace ProgettoFinaleInformatica {
    partial class FormCalendario {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            lblScegliSettimana = new Label();
            btnOttimizzazione = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(4, 2);
            monthCalendar1.Location = new Point(98, 129);
            monthCalendar1.Margin = new Padding(7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // lblScegliSettimana
            // 
            lblScegliSettimana.AutoSize = true;
            lblScegliSettimana.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblScegliSettimana.Location = new Point(280, 46);
            lblScegliSettimana.Margin = new Padding(2, 0, 2, 0);
            lblScegliSettimana.Name = "lblScegliSettimana";
            lblScegliSettimana.Size = new Size(684, 46);
            lblScegliSettimana.TabIndex = 1;
            lblScegliSettimana.Text = "Scegli un giorno per vederne la settimana";
            // 
            // btnOttimizzazione
            // 
            btnOttimizzazione.Location = new Point(494, 551);
            btnOttimizzazione.Name = "btnOttimizzazione";
            btnOttimizzazione.Size = new Size(241, 39);
            btnOttimizzazione.TabIndex = 2;
            btnOttimizzazione.Text = "Ottimizzazione intelligente";
            btnOttimizzazione.UseVisualStyleBackColor = true;
            btnOttimizzazione.Click += btnOttimizzazione_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(229, 560);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Clicca qui";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 560);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 4;
            label1.Text = "Vuoi supportarci?";
            // 
            // FormCalendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 620);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(btnOttimizzazione);
            Controls.Add(lblScegliSettimana);
            Controls.Add(monthCalendar1);
            Margin = new Padding(2);
            Name = "FormCalendario";
            Text = "Form1";
            Load += FormCalendario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label lblScegliSettimana;
        private Button btnOttimizzazione;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}
