using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltadePiezas
{
    public partial class Form1 : Form
    {
        string[] fecha;
        DialogResult respuestaAgregar;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha = dateTimePicker1.Value.ToString().Split();
            labelFecha.Text = fecha[0];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelDefecto.Visible = true;
            comboBoxDefecto.Visible = true;
            labelRebraze.Visible = true;
            radioButtonSiR.Visible = true;
            radioButtonNoR.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            respuestaAgregar = MessageBox.Show("Seguro que desea agregar la pieza a la base de datos?","Agregar Pieza",MessageBoxButtons.YesNo);
            if (respuestaAgregar == DialogResult.Yes)
            {
                respuestaAgregar = MessageBox.Show("Agregar una nueva pieza?", "Agregar Pieza", MessageBoxButtons.YesNo);
                if (respuestaAgregar == DialogResult.Yes)
                {
                    labelFecha.Text = null;
                }
            }          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelDefecto.Visible = false;
            comboBoxDefecto.Visible = false;
            labelRebraze.Visible = false;
            radioButtonSiR.Visible = false;
            radioButtonNoR.Visible = false;
        }
    }
}
