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
    public partial class Alarma : Form
    {
        public Form1 form1;
        public Alarma()
        {
            InitializeComponent();
        }

        private void Alarma_Load(object sender, EventArgs e)
        {

        }

        private void AlarmaClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }
    }
}
