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
    public partial class FormGrupo : Form
    {
        public FormGrupo()
        {
            InitializeComponent();
        }

        private void textBoxNombreGrupo_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se aceptan carateres de tipo String", "Aviso");
            }
        }

        private void textBoxNombreProcesoGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreProcesoGrupo_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se aceptan carateres de tipo String", "Aviso");
            }
        }

        private void textBoxIdProcesoGrupo_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se aceptan numeros enteros!", "Aviso");
            }
        }

        private void buttonCrearProceso_Click(object sender, EventArgs e)
        {
            FormGrupo frm = new FormGrupo();
            frm.Close(); 
        }

    }
}
