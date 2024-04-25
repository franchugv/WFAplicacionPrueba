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
    public partial class fPrincipal : Form
    {
        public fPrincipal()
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
