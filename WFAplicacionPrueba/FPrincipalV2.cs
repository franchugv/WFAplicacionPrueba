using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAplicacionPrueba
{
    public partial class FPrincipalV2 : Form
    {
        public FPrincipalV2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bVisible(object sender, EventArgs e)
        {
            if (TextBoxEntrada.Visible)
            {
                // Ocultar la Entrada
                TextBoxEntrada.Hide();
                // Cambiar titulo
                BVisible.Text = "Ver";
            }

            else
            {
                TextBoxEntrada.Visible = true;
                BVisible.Text = "Ocultar";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Botones_Click(object sender, EventArgs e)
        {
            // RECURSOS
            Button boton = (Button)sender;  // Capturar el control que produce o que recibe el evento            

            // Acciones SEGÚN el botón
            switch (boton.Name)
            {
                case "BotonActivar":
                    if (TextBoxEntrada.Enabled)
                    {
                        TextBoxEntrada.Enabled = false;
                        // BotonActivar.Text = "Activar";
                        boton.Text = "Activar";
                    }
                    else
                    {
                        TextBoxEntrada.Enabled = true;
                        // BotonActivar.Text = "Desactivar";
                        boton.Text = "Desactivar";
                    }
                    break;
                case "BVisible":
                    if (TextBoxEntrada.Visible)
                    {
                        // Ocultar la Entrada
                        TextBoxEntrada.Hide();
                        // Cambiar titulo
                        boton.Text = "Ver";
                    }

                    else
                    {
                        TextBoxEntrada.Visible = true;
                        boton.Text = "Ocultar";

                    }
                    break;
                case "bTransferir":
                    tdSalida.Text = TextBoxEntrada.Text;
                    break;
                case "BotonSoloLectura":
                    if (TextBoxEntrada.ReadOnly) // Modo solo Lectura
                    {
                        TextBoxEntrada.ReadOnly = false;
                        boton.Text = "Desactivar Modo Lectura";
                    }
                    else   // Modo Edición
                    {
                        TextBoxEntrada.ReadOnly = true;
                        boton.Text = "Activar Modo Lectura";
                    }
                    break;
            }

        }


        private void bTransferir_Click(object sender, EventArgs e)
        {
            tdSalida.Text = TextBoxEntrada.Text;
        }

        private void bActivar_Click(object sender, EventArgs e)
        {
            if (TextBoxEntrada.Enabled)
            {
                TextBoxEntrada.Enabled = false;
                BotonActivar.Text = "Activar";
            }
            else
            {
                TextBoxEntrada.Enabled = true;
                BotonActivar.Text = "Desactivar";
            }
            

        }

        private void BotonSoloLectura_Cick(object sender, EventArgs e)
        {
            if (TextBoxEntrada.ReadOnly) /// Modo solo Lectura
            { 
                TextBoxEntrada.ReadOnly = false;
                BotonSoloLectura.Text = "Desactivar Modo Lectura";
            }
            else   // Modo Edición
            {
                TextBoxEntrada.ReadOnly = true;
                BotonSoloLectura.Text = "Activar Modo Lectura";
            }


        }
        
    }
}
