﻿using System;
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
    public partial class ConfigWindow : Form
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
                Config.fmt_length = "fijo";
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
                Config.fmt_length = "var";
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
                Config.fifo = true;
                Config.priority = false;
            }
            else
            {
                checkPrioridad.Enabled = true;
                Config.fifo = false;
                Config.priority = true;
            }
        }

        private void checkPrioridad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrioridad.Checked)
            {
                checkFIFO.Enabled = false;
                Config.priority = true;
                Config.fifo = false;
            }
            else
            {
                checkFIFO.Enabled = true;
                Config.priority = false;
                Config.fifo = true;
            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {

            if(comboSend.SelectedIndex == -1 || comboReceive.SelectedIndex == -1 || comboContenido.SelectedIndex == -1){
                 MessageBox.Show("Debe llenar todos los espacios de los ComboBox");
            }

            else
            {
                Config.send = comboSend.SelectedItem.ToString();
                Config.receive = comboReceive.SelectedItem.ToString();
                Config.content = comboContenido.SelectedItem.ToString();
                Config.length = int.Parse(textBoxLargoCola.Text);
                if ((checkDirecto.Checked && comboDirecto.SelectedIndex != -1)||(checkIndirecto.Checked && comboIndirecto.SelectedIndex != -1))
                {
                    if (checkDirecto.Checked)
                    {
                        Config.direccionamiento = comboDirecto.SelectedItem.ToString();
                        FormCrear frm = new FormCrear();
                        frm.Show();
                    }

                    else
                    {
                        Config.direccionamiento = comboIndirecto.SelectedItem.ToString();
                        FormGrupo frm = new FormGrupo();
                        frm.Show();                       
                    }


                }

                else
                {
                    MessageBox.Show("Debe llenar todos los espacios de los ComboBox");
                }

               
            }
            

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("¡Solo se aceptan numeros enteros!", "Aviso");
            }
        }
    }
}
    
