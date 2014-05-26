using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Infra
{
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            InitializeComponent();
        }

        public void buttonCrearProceso_Click(object sender, EventArgs e)
        {

            Proceso proceso = new Proceso(int.Parse(textBoxIdProceso.Text), textBoxNombreProceso.Text, comboTipoProceso.SelectedItem.ToString());
            Program.ListaProcesos.Add(proceso);

            MessageBox.Show("El Proceso: " + "'" + textBoxNombreProceso.Text + "'" + "\n" + " De tipo: " + comboTipoProceso.Text + "\n" + " Ha sido creado con el id: " + textBoxIdProceso.Text, "Proceso Creado!");

            textBoxIdProceso.Text = "";
            textBoxNombreProceso.Text = "";
            comboTipoProceso.SelectedIndex = -1;
        }

        private void textBoxIdProceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros enteros!","Aviso");
            }
        }

        private void textBoxNombreProceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan carateres de tipo String","Aviso");
            }
           
        }

        private void textBoxNombreProceso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

