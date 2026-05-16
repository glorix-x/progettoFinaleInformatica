using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgettoFinaleInformatica
{
    public partial class FormHome : Form
    {
        private Font font;
        private FormCalendario f;
        public FormHome(FormCalendario f)
        {
            InitializeComponent();
            this.f = f;
            this.f.FormClosed += (sender, e) => Application.Exit(); //serve per chiudere tutto, sennò quando nascondo il form home rimane in bg
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/SupermercadoOne-Regular.ttf");
            this.font = new Font(fonts.Families[0], 11f);
            this.BackColor = Color.AliceBlue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pbHome.Value = 0;
            btnStart.Hide();
            timer1.Start();

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Width = this.ClientSize.Width - 20;
            label1.Height = this.ClientSize.Height / 3;
            label1.Top = 0;
            label1.Left = 10;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font(font.FontFamily, 50);
            label1.BackColor = Color.RebeccaPurple;
            btnStart.Left = (this.ClientSize.Width - btnStart.Width) / 2;
            pbHome.Style = ProgressBarStyle.Continuous;
            pbHome.Height = 40;
            pbHome.Width = 600;
            pbHome.Left =(this.ClientSize.Width-pbHome.Width)/2;
            //pibble.Image = Image.FromFile("images/pibble.jpeg");
            pibble.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (pbHome.Value < 100)
            {
                pbHome.Value += 1;
                if (pbHome.Value < 100)
                {
                    pbHome.Value += 1;
                    pbHome.Value -= 1;
                }
            }
            else
            {
                timer1.Stop();
                pbHome.Maximum = 101; // queste addizioni e sottrazioni servono a rimediare per la latenza
                pbHome.Value = 101;
                pbHome.Maximum = 100;
                pbHome.Value = 100;
                System.Threading.Thread.Sleep(200);
                f.Show();
                this.Hide();
            }
        }
    }
}
