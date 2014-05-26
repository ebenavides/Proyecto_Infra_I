using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdProceso_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCrearProceso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Proceso: " + "'" + textBoxNombreProceso.Text + "'" + "\n" + " De tipo: " + comboTipoProceso.Text + "\n" + " Ha sido creado con el id: " + textBoxIdProceso.Text, "Proceso Creado!");
       
   
        }

        private void textBoxNombreProceso_TextChanged(object sender, EventArgs e)
        {
            
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

        private void comboTipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
