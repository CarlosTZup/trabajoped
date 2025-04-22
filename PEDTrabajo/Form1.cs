using System.Security.Claims;

namespace PEDTrabajo
{
    public partial class Form1 : Form
    {
        public Sesion Sesion;
        public DateTime alarm;
        public bool validate = false;
        public Form1()
        {
            InitializeComponent();
            LabelTime.Text = dateTimePicker1.Value.ToString("hh:mm:ss tt");
            alarm = dateTimePicker1.Value;
            alarm = alarm.AddMinutes(2);
            LabelNextAlarm.Text = alarm.ToString("hh:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alarma Form = new Alarma();
            Form.Show();
            Form.form1 = this;
            Form.Clock = dateTimePicker1.Value;
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LabelTime.Text = dateTimePicker1.Value.ToString("hh:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddSeconds(1);
            LabelTime.Text = dateTimePicker1.Value.ToString("hh:mm:ss tt");

            if (alarm.ToString("hh:mm") == dateTimePicker1.Value.ToString("hh:mm") && !validate)
            {
                validate = true;
                MessageBox.Show("¡ Alarma Activada !");

            }
            else if (!(alarm.ToString("hh:mm") == dateTimePicker1.Value.ToString("hh:mm")))
                validate = false;
        }

        private void Form1Closed(object sender, FormClosedEventArgs e)
        {
            Sesion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoraConfigurar Form = new HoraConfigurar();
            Form.Show();
            Form.form1 = this;
            Form.Clock = dateTimePicker1.Value;
            Form.sent = true;
            this.Hide();
        }

        public void CambiarHora(DateTime bGClock)
        {
             dateTimePicker1.Value = bGClock;
        }
    }
}