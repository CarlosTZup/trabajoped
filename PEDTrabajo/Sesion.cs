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
    public partial class Sesion : Form
    {
        Form1 Ingresar;

        public Sesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {

                if (((textBox1.Text == "admin@gmail.com") || (textBox1.Text == "admin")) && (textBox2.Text == "admin"))
                {

                    MessageBox.Show("¡ BIENVENIDO/A !");
                    Ingresar = new Form1();
                    Ingresar.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR LOS DATOS CORRECTOS");
                }

            }
            else
            {
                MessageBox.Show("DEBE INGRESAR LOS DATOS");
            }
        }
    }
}
