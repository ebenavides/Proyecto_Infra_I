﻿using System;
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
    public partial class ConfigWindow: Form
    {
        
        public ConfigWindow()
        {
            InitializeComponent();
        }


        private void checkDirecto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDirecto.Checked)
            {
                comboIndirecto.Enabled = false;
                checkIndirecto.Enabled = false;
                
                
            }
            else
            {
                comboIndirecto.Enabled = true;
                checkIndirecto.Enabled = true;
            }
        }

        private void checkIndirecto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIndirecto.Checked)
            {
                comboDirecto.Enabled = false;
                checkDirecto.Enabled = false;
            }
            else
            {
                comboDirecto.Enabled = true;
                checkDirecto.Enabled = true;
            }
        }

        private void checkFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFijo.Checked)
            {
                checkVariable.Enabled = false;
            }
            else
            {
                checkVariable.Enabled = true;
            }
        }

        private void checkVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVariable.Checked)
            {
                checkFijo.Enabled = false;
            }
            else
            {
                checkFijo.Enabled = true;

            }
        }

        private void checkFIFO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFIFO.Checked)
            {
                
                checkPrioridad.Enabled = false;
            }
            else
            {
                checkPrioridad.Enabled = true;
            }
        }

        private void checkPrioridad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrioridad.Checked)
            {
                checkFIFO.Enabled = false;
            }
            else
            {
                checkFIFO.Enabled = true;
            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            FormCrear frm = new FormCrear(); 
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLargoCola_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

