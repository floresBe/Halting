using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicio;


namespace AltadePiezas
{
    public partial class AltadePiezas : Form
    {
        string[] fecha;//fecha obtenida de datetimepike
        string[] c; //Ciclo obtenido de comboboxciclos
        List<String> ciclos = new List<string>();
        cCiclo ciclo = new cCiclo();
        cLote lote = new cLote();
        cPieza pieza = new cPieza();
        cDefecto defecto = new cDefecto();
        DialogResult respuesta;

        public AltadePiezas()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            llenarCiclos();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoAprobado.Checked)
            {
                labelDefecto.Visible = true;
                comboBoxDefecto.Visible = true;
                labelRebraze.Visible = true;
                radioButtonSiR.Visible = true;
                radioButtonNoR.Visible = true;
                groupBoxRebraze.Visible = true;
            }
            else
            {
                labelDefecto.Visible = false;
                comboBoxDefecto.Visible = false;
                labelRebraze.Visible = false;
                radioButtonSiR.Visible = false;
                radioButtonNoR.Visible = false;
                groupBoxRebraze.Visible = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Program.fechaAlta = DateTime.Now.ToString();
            if (labelFecha.Text != "--/--/----")
            {
                Program.fechaHorneo = labelFecha.Text;
            }
            else
            {
                MessageBox.Show("Seleccione fecha.");
                return;
            }
            if (comboBoxCiclos.SelectedItem != null)
            {
                c = comboBoxCiclos.SelectedItem.ToString().Split('|');
                Program.noC = Convert.ToInt32(c[0]);
                Program.pkC = Convert.ToInt32(c[1]);
            }
            else
            {
                MessageBox.Show("Seleccione Ciclo.");
                return;
            }
            Program.serie = generarSerie();//Lista de series
            if (Program.serie == null || Program.serie.Count < 0)
            {
                textBoxSerie.Focus();
                return;
            }
            if (radioButtonSiAprobado.Checked)
            {
                Program.aprobado = 1;
            }
            else if (radioButtonNoAprobado.Checked)
            {
                Program.aprobado = 0;
                if (comboBoxDefecto.SelectedItem != null)
                {
                    string[] defecto = comboBoxDefecto.SelectedItem.ToString().Split();
                    Program.defecto = Convert.ToInt32(defecto[0]);
                }
                else
                {
                    MessageBox.Show("Seleccione defecto.");
                    return;
                }

                if (radioButtonSiR.Checked)
                {
                    Program.rebraze = 1;
                }
                else if (radioButtonNoR.Checked)
                {
                    Program.rebraze = 0;
                }
                else
                {
                    MessageBox.Show("Indique si el lote/pieza necesita rebraze.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Indique si el lote/pieza fue o no aprobada.");
                return;
            }
            respuesta = MessageBox.Show("Seguro que desea agregar la pieza a la base de datos?", "Agregar Pieza", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Program.lote = darDeAlta(Program.usuario, Program.fechaHorneo, Program.fechaAlta, Program.pkC, Program.serie, Program.aprobado, Program.defecto, Program.rebraze);
                MessageBox.Show("Pieza/Lote dado de alta exitosamente.");
                respuesta = MessageBox.Show("Agregar una nueva pieza/Lote?", "Agregar Pieza", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    labelFecha.Text = "--/--/----";
                    comboBoxCiclos.Items.Clear();
                    comboBoxCiclos.Text = "";
                    textBoxSerie.Text = "";
                    textBoxSerieRango.Text = "";
                    textBoxSerieRango.Visible = false;
                    radioButtonSiAprobado.Checked = false;
                    radioButtonNoAprobado.Checked = false;
                    groupBoxRebraze.Visible = false;
                    comboBoxCiclos.Enabled = false;
                }
                else
                {
                    //respuesta = MessageBox.Show("Agregar Pruebas a la pieza/Lote?", "Agregar Prueba", MessageBoxButtons.YesNo);
                    //if (respuesta == DialogResult.Yes)
                    //{
                    //    Program.sesion = 1;
                    //    PruebasRealizadas ventana = new PruebasRealizadas();
                    //    ventana.Show();
                    //    this.Close();
                    //}
                    //else
                    //{
                    this.Close();
                    // }
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
        private void buttonMas_Click(object sender, EventArgs e)
        {
            if (textBoxSerieRango.Visible)
            {
                textBoxSerieRango.Visible = false;
                buttonMas.Text = "+";
            }
            else
            {
                textBoxSerieRango.Visible = true;
                buttonMas.Text = "-";
            }
        }
        private List<string> generarSerie()
        {
            List<string> series = null;

            if (textBoxSerieRango.Visible == true)
            {
                if (textBoxSerieRango.Text != string.Empty && textBoxSerieRango.Text != null)
                {
                    try
                    {
                        int serie1 = Convert.ToInt32(textBoxSerie.Text);
                        int serie2 = Convert.ToInt32(textBoxSerieRango.Text);
                        series = new List<string>();
                        for (int i = serie1; i <= serie2; i++)
                        {
                            string serie = "serie" + i.ToString();
                            series.Add(serie);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Datos del rango no validos");
                        return null;
                    }
                }
                else
                {
                    respuesta = MessageBox.Show("El campo de rango se encuentra vacio, desea agregar un rango de piezas?", "Agregar Rango", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        textBoxSerieRango.Focus();
                        return null;
                    }
                    else
                    {
                        textBoxSerieRango.Visible = false;
                        int serie1 = 0;
                        string serie = null;
                        try
                        {
                            serie1 = Convert.ToInt32(textBoxSerie.Text);
                            serie = "serie" + serie1.ToString();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Dato no valido");
                            return null;
                        }
                        series = new List<string>();
                        series.Add(serie);
                    }
                }

            }
            else
            {
                int serie1 = 0;
                string serie = null;
                try
                {
                    serie1 = Convert.ToInt32(textBoxSerie.Text);
                    serie = "serie" + serie1.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dato no valido");
                    return null;
                }
                series = new List<string>();
                series.Add(serie);
            }
            return series;
        }

        private int darDeAlta(int usuario, string fechaHorneo, string fechaAlta, int ciclo, List<string> serie, int aprobado, int defecto, int rebraze)
        {
            int lotePK = lote.Insertar(ciclo, usuario, fechaHorneo, fechaAlta);

            foreach (var item in serie)
            {
                pieza.Insertar(item, lotePK, defecto, aprobado, rebraze);
            }
            return lotePK;
        }

        private void AltadePiezas_Load(object sender, EventArgs e)
        {
            List<string> defectos = new List<string>();

            defectos = defecto.ObtenerTodos();
            if (defectos.Count != 0 && defectos != null)
            {
                foreach (var item in defectos)
                {
                    comboBoxDefecto.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCiclos();
        }
        private void llenarCiclos()
        {
            ciclo = new cCiclo();
            string horno = string.Empty;
            int h = 0;
            try
            {
                h = comboBox1.SelectedIndex;
                switch (h)
                {
                    case 0:
                        horno = "A";
                        break;
                    case 1:
                        horno = "I";
                        break;
                    case 2:
                        horno = "H";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                //No selecciono horno
                return;
            }
            try
            {
                fecha = dateTimePicker.Value.ToString().Split();
                labelFecha.Text = fecha[0];
            }
            catch
            {
                //No selecciono fecha
                return;
            }
            ciclos = ciclo.obtenerPorHornoyFecha(horno, fecha[0]);
            if (ciclos.Count() == 0 || ciclos == null)
            {
                MessageBox.Show("No Existen ciclos con los datos selccionados.");
                comboBoxCiclos.Enabled = false;
                return;
            }
            else
            {
                comboBoxCiclos.Enabled = true;
                comboBoxCiclos.Items.Clear();
                foreach (string ciclo in ciclos)
                {
                    comboBoxCiclos.Items.Add(ciclo);
                }
            }
            ciclo = null;
        }

        private void comboBoxCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
