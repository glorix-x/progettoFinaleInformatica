namespace ProgettoFinaleInformatica
{
    partial class FormOttimizzazione
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
            dgvImpegni = new DataGridView();
            Elimina = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbDurata = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btnAggiungi = new Button();
            cbColore = new ComboBox();
            tbNome = new TextBox();
            rtbDescrizione = new RichTextBox();
            dtpDeadline = new DateTimePicker();
            btnOttimizza = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImpegni).BeginInit();
            SuspendLayout();
            // 
            // dgvImpegni
            // 
            dgvImpegni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImpegni.Columns.AddRange(new DataGridViewColumn[] { Elimina });
            dgvImpegni.Location = new Point(361, 46);
            dgvImpegni.Name = "dgvImpegni";
            dgvImpegni.RowHeadersWidth = 51;
            dgvImpegni.Size = new Size(647, 309);
            dgvImpegni.TabIndex = 0;
            dgvImpegni.CellContentClick += dgvImpegni_CellContentClick;
            // 
            // Elimina
            // 
            Elimina.HeaderText = "Delete";
            Elimina.MinimumWidth = 6;
            Elimina.Name = "Elimina";
            Elimina.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 30);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 1;
            label1.Text = "Aggiunta impegno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 81);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 119);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Descrizione";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 235);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Deadline";
            // 
            // cbDurata
            // 
            cbDurata.FormattingEnabled = true;
            cbDurata.Location = new Point(109, 275);
            cbDurata.Name = "cbDurata";
            cbDurata.Size = new Size(221, 28);
            cbDurata.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 278);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 6;
            label5.Text = "Durata";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 330);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 7;
            label6.Text = "Colore";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(135, 370);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(175, 47);
            btnAggiungi.TabIndex = 8;
            btnAggiungi.Text = "Aggiungi evento";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // cbColore
            // 
            cbColore.FormattingEnabled = true;
            cbColore.Location = new Point(109, 327);
            cbColore.Name = "cbColore";
            cbColore.Size = new Size(221, 28);
            cbColore.TabIndex = 9;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(109, 78);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(221, 27);
            tbNome.TabIndex = 10;
            // 
            // rtbDescrizione
            // 
            rtbDescrizione.Location = new Point(135, 123);
            rtbDescrizione.Name = "rtbDescrizione";
            rtbDescrizione.Size = new Size(195, 93);
            rtbDescrizione.TabIndex = 11;
            rtbDescrizione.Text = "";
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(109, 230);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(221, 27);
            dtpDeadline.TabIndex = 12;
            // 
            // btnOttimizza
            // 
            btnOttimizza.Location = new Point(589, 380);
            btnOttimizza.Name = "btnOttimizza";
            btnOttimizza.Size = new Size(175, 47);
            btnOttimizza.TabIndex = 13;
            btnOttimizza.Text = "Ottimizza!";
            btnOttimizza.UseVisualStyleBackColor = true;
            btnOttimizza.Click += btnOttimizza_Click;
            // 
            // FormOttimizzazione
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 450);
            Controls.Add(btnOttimizza);
            Controls.Add(dtpDeadline);
            Controls.Add(rtbDescrizione);
            Controls.Add(tbNome);
            Controls.Add(cbColore);
            Controls.Add(btnAggiungi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbDurata);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvImpegni);
            Name = "FormOttimizzazione";
            Text = "FormOttimizzazione";
            ((System.ComponentModel.ISupportInitialize)dgvImpegni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvImpegni;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbDurata;
        private Label label5;
        private Label label6;
        private Button btnAggiungi;
        private ComboBox cbColore;
        private TextBox tbNome;
        private RichTextBox rtbDescrizione;
        private DateTimePicker dtpDeadline;
        private Button btnOttimizza;
        private DataGridViewButtonColumn Elimina;
    }
}