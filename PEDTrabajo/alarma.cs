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
        public DateTime Clock;
        public bool intended=false;

        public Alarma()
        {
            InitializeComponent();
            LabelClock.Text = Clock.ToString("hh:mm");
            dataGridView1.DataSource = GetPerdataNewList();
        }

        private void Alarma_Load(object sender, EventArgs e)
        {

        }

        private void AlarmaClosed(object sender, FormClosedEventArgs e)
        {
            if (!intended)
            form1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelClock.Text = Clock.ToString("hh:mm");
            Clock = Clock.AddSeconds(1);
        }

        public List<DataClock> GetPerdataNewList()
        {
            List<DataClock> Alarmanew = new List<DataClock>();
            DataClock temp = new DataClock(1, "Alarma1", "11:40", "LMNJVSD");
            Alarmanew.Add(temp);


            return Alarmanew;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<DataClock> Alarmanew = (List<DataClock>)dataGridView1.DataSource;
            if (nombrebox.Text != "" && tiempobox.Text != "")
            {
                string dias = string.Empty;
                foreach (var dia in checkedListBox1.CheckedItems)
                {
                    switch (dia.ToString())
                    {
                        case "Lunes":
                            dias += "L";
                            continue;
                        case "Martes":
                            dias += "M";
                            continue;
                        case "Miercoles":
                            dias += "N";
                            continue;
                        case "Jueves":
                            dias += "J";
                            continue;
                        case "Viernes":
                            dias += "V";
                            continue;
                        case "Sabado":
                            dias += "S";
                            continue;
                        case "Domingo":
                            dias += "D";
                            break;
                        default: break;
                    }
                }
                DataClock temp = new DataClock(Alarmanew.Count + 1, nombrebox.Text, tiempobox.Text, dias);
                Alarmanew.Add(temp);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Alarmanew;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<DataClock> AlarmData = (List<DataClock>)dataGridView1.DataSource;
            if (nombrebox.Text != "" && tiempobox.Text != "" && idbox.Text != "")
            {

                if (int.TryParse(idbox.Text, out int id))
                {
                    DataClock AlarmaEditar = AlarmData.FirstOrDefault(p => p.ID == id);

                    if (AlarmaEditar != null)
                    {
                        AlarmaEditar.Nombre = nombrebox.Text;
                        AlarmaEditar.Hora = tiempobox.Text;
                        string dias = string.Empty;
                        foreach (var dia in checkedListBox1.CheckedItems)
                        {
                            switch (dia.ToString())
                            {
                                case "Lunes":
                                    dias += "L";
                                    continue;
                                case "Martes":
                                    dias += "M";
                                    continue;
                                case "Miercoles":
                                    dias += "N";
                                    continue;
                                case "Jueves":
                                    dias += "J";
                                    continue;
                                case "Viernes":
                                    dias += "V";
                                    continue;
                                case "Sabado":
                                    dias += "S";
                                    continue;
                                case "Domingo":
                                    dias += "D";
                                    break;
                                default: break;
                            }
                        }
                        AlarmaEditar.Dias = dias;
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = AlarmData;
                        MessageBox.Show("Editado!");
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido.");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<DataClock> AlarmData = (List<DataClock>)dataGridView1.DataSource;
            if (idbox.Text != "")
            {

                if (int.TryParse(idbox.Text, out int id))
                {
                    DataClock AlarmBuscar = AlarmData.FirstOrDefault(p => p.ID == id);

                    if (AlarmBuscar != null)
                    {
                        nombrebox.Text = AlarmBuscar.Nombre;
                        tiempobox.Text = AlarmBuscar.Hora;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = AlarmData;
                        MessageBox.Show("Encontrado!");
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido.");
                }
            }
            else
            {
                MessageBox.Show("Rellene el campo ID.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<DataClock> AlarmaData = (List<DataClock>)dataGridView1.DataSource;
            if (idbox.Text != "")
            {

                if (int.TryParse(idbox.Text, out int id))
                {
                    DataClock AlarmaEliminar = AlarmaData.FirstOrDefault(p => p.ID == id);

                    if (AlarmaEliminar != null)
                    {
                        string dias = string.Empty;
                        foreach (var dia in checkedListBox1.CheckedItems)
                        {
                            switch (dia.ToString())
                            {
                                case "Lunes":
                                    dias += "L";
                                    continue;
                                case "Martes":
                                    dias += "M";
                                    continue;
                                case "Miercoles":
                                    dias += "N";
                                    continue;
                                case "Jueves":
                                    dias += "J";
                                    continue;
                                case "Viernes":
                                    dias += "V";
                                    continue;
                                case "Sabado":
                                    dias += "S";
                                    continue;
                                case "Domingo":
                                    dias += "D";
                                    break;
                                default: break;
                            }
                        }

                        if (nombrebox.Text == AlarmaEliminar.Nombre && tiempobox.Text == AlarmaEliminar.Hora && dias == AlarmaEliminar.Dias)
                        {
                            MessageBox.Show("Eliminando! " + AlarmaEliminar.Nombre);
                            AlarmaData.Remove(AlarmaEliminar);
                            for (int i = 0; i < AlarmaData.Count; i++)
                            {
                                AlarmaData[i].ID = i + 1;
                            }
                            idbox.Clear();
                            nombrebox.Clear();
                            tiempobox.Clear();
                            checkedListBox1.ClearSelected();
                        }
                        else
                            MessageBox.Show("Porfavor valide la informacion de todos los campos.");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = AlarmaData;
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado.");
                    }

                }
                else
                {
                    MessageBox.Show("ID inválido.");
                }
            }
            else
            {
                MessageBox.Show("Rellene el campo ID.");
            }

        }

        private void buttonregresar_Click(object sender, EventArgs e)
        {
            intended = true;
            form1.Show();
            this.Close();
        }
    }
}
