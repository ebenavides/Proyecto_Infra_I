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
                this.Close();        
        }

        private void buttonCrearGrupo_Click(object sender, EventArgs e)
        {

            if (textBoxNombreGrupo.Text == "")
            {
                MessageBox.Show("Escriba el nombre del grupo!");
            }
            else
            {
                comboGrupo.Items.Add(textBoxNombreGrupo.Text);
                MessageBox.Show("se ingresó el grupo: " + textBoxNombreGrupo.Text, "Grupo Creado!");
                textBoxNombreGrupo.Text = "";
            }
        }

        private void buttonCrearGrupoProceso_Click(object sender, EventArgs e)
        {
            if (textBoxNombreProcesoGrupo.Text == "" || textBoxIdProcesoGrupo.Text == "" || comboGrupo.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un nombre y ID para el proceso y Seleccione un grupo en el comboBox");        
            }
           
            else
            {
                MessageBox.Show("Nombre: " + textBoxNombreProcesoGrupo.Text + "\n" + "ID: " + textBoxIdProcesoGrupo.Text + "\n" + "Grupo: " + comboGrupo.SelectedItem, "Proceso Creado!");
                comboGrupo.SelectedIndex = -1;
                textBoxIdProcesoGrupo.Text = "";
                textBoxNombreProcesoGrupo.Text = "";

            }
        }


    }
}
