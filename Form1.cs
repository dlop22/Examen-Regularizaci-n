using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenCorregido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //List<Rol> roles = new List<Rol>();
        Dictionary<int, Rol> roles = new Dictionary<int, Rol>();

        private void comboRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboSalida.Items.Clear();
                if (comboRuta.Text == "Ruta 1")
                {
                    comboSalida.Items.Add("7:00");
                    comboSalida.Items.Add("7:05");
                    comboSalida.Items.Add("7:10");
                    comboSalida.Items.Add("7:18");
                }

                else if (comboRuta.Text == "Ruta 2")
                {
                    comboSalida.Items.Add("6:50");
                    comboSalida.Items.Add("7:02");
                    comboSalida.Items.Add("7:12");
                    comboSalida.Items.Add("7:22");
                }

                else if (comboRuta.Text == "Ruta 10")
                {
                    comboSalida.Items.Add("6:00");
                    comboSalida.Items.Add("6:05");
                    comboSalida.Items.Add("6:10");
                    comboSalida.Items.Add("6:18");

                }

                else if (comboRuta.Text == "Ruta 21")
                {
                    comboSalida.Items.Add("6:00");
                    comboSalida.Items.Add("6:30");
                    comboSalida.Items.Add("6:45");
                    comboSalida.Items.Add("7:10");

                }
               
                comboSalida.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Rol mirol;
            int numero = Convert.ToInt32(txtEco.Text);
            mirol = new Rol(numero, txtChofer.Text, comboRuta.Text,comboSalida.Text);
            lista1.Items.Add(mirol.ToString());
            roles.Add(numero,mirol);
        }

        private void txtEco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
