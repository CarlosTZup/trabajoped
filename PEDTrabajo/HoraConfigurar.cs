using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDTrabajo
{
    public partial class HoraConfigurar : Form
    {

        public Form1 form1;
        public DateTime Clock;

        public DateTime BGClock;
        public DateTime NewClock;
        public bool intended = false;
        public bool sent = false;
        public HoraConfigurar()
        {
            InitializeComponent();
            LabelTime.Text = Clock.ToString("hh:mm:ss tt");
            NewClock = Clock;
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
            BGClock = Clock;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BGClock = BGClock.AddSeconds(1);
            if (sent)
            {
                LabelTime.Text = Clock.ToString("hh:mm:ss tt");
                NewClock = Clock;
                labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
                BGClock = Clock;
                sent = false;
            }
        }

        private void HoramasButton_Click(object sender, EventArgs e)
        {
            NewClock = NewClock.AddHours(1);
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
        }

        private void HoramenosButton_Click(object sender, EventArgs e)
        {
            NewClock = NewClock.AddHours(-1);
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
        }

        private void MinutomasButton_Click(object sender, EventArgs e)
        {
            NewClock = NewClock.AddMinutes(1);
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
        }

        private void MinutomenosButton_Click(object sender, EventArgs e)
        {
            NewClock = NewClock.AddMinutes(-1);
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
        }

        private void SegundomasButton_Click(object sender, EventArgs e)
        {
            NewClock = NewClock.AddSeconds(1);
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
        }

        private void SegundomenosButton_Click(object sender, EventArgs e)
        {
            NewClock = NewClock.AddSeconds(-1);
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Clock = NewClock;
            BGClock = NewClock;
            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");

            LabelTime.Text = Clock.ToString("hh:mm:ss tt");
            form1.CambiarHora(BGClock);

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Clock = BGClock;
            NewClock = BGClock;
            LabelTime.Text = Clock.ToString("hh:mm:ss tt");

            labelNewTime.Text = NewClock.ToString("hh:mm:ss tt");

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            intended = true;
            form1.Show();
            this.Close();
        }

        private void HoraClosed(object sender, FormClosedEventArgs e)
        {
            if (!intended)
                form1.Close();
        }
    }
}
