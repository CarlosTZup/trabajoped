namespace PEDTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelTime.Text = dateTimePicker1.Value.ToString("hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LabelTime.Text = dateTimePicker1.Value.ToString("hh:mm:ss tt");
        }
    }
}