namespace WFAplicacionPrueba
{
    partial class FPrincipalV2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms, NO TOCAR 

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BVisible = new System.Windows.Forms.Button();
            this.BotonSoloLectura = new System.Windows.Forms.Button();
            this.BotonActivar = new System.Windows.Forms.Button();
            this.bTransferir = new System.Windows.Forms.Button();
            this.lEntrada = new System.Windows.Forms.Label();
            this.TextBoxEntrada = new System.Windows.Forms.TextBox();
            this.tdSalida = new System.Windows.Forms.TextBox();
            this.lSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BVisible
            // 
            this.BVisible.Location = new System.Drawing.Point(238, 54);
            this.BVisible.Name = "BVisible";
            this.BVisible.Size = new System.Drawing.Size(151, 23);
            this.BVisible.TabIndex = 0;
            this.BVisible.Text = "Ver";
            this.BVisible.UseVisualStyleBackColor = true;
            this.BVisible.Click += new System.EventHandler(this.Botones_Click);
            // 
            // BotonSoloLectura
            // 
            this.BotonSoloLectura.Location = new System.Drawing.Point(437, 54);
            this.BotonSoloLectura.Name = "BotonSoloLectura";
            this.BotonSoloLectura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotonSoloLectura.Size = new System.Drawing.Size(151, 23);
            this.BotonSoloLectura.TabIndex = 1;
            this.BotonSoloLectura.Text = "Solo Lectura";
            this.BotonSoloLectura.UseVisualStyleBackColor = true;
            this.BotonSoloLectura.Click += new System.EventHandler(this.bActivar_Click);
            // 
            // BotonActivar
            // 
            this.BotonActivar.Location = new System.Drawing.Point(31, 54);
            this.BotonActivar.Name = "BotonActivar";
            this.BotonActivar.Size = new System.Drawing.Size(151, 23);
            this.BotonActivar.TabIndex = 2;
            this.BotonActivar.Text = "Activar";
            this.BotonActivar.UseVisualStyleBackColor = true;
            this.BotonActivar.Click += new System.EventHandler(this.Botones_Click);
            // 
            // bTransferir
            // 
            this.bTransferir.Location = new System.Drawing.Point(618, 54);
            this.bTransferir.Name = "bTransferir";
            this.bTransferir.Size = new System.Drawing.Size(151, 23);
            this.bTransferir.TabIndex = 3;
            this.bTransferir.Text = "Transferir";
            this.bTransferir.UseVisualStyleBackColor = true;
            this.bTransferir.Click += new System.EventHandler(this.Botones_Click);
            // 
            // lEntrada
            // 
            this.lEntrada.AutoSize = true;
            this.lEntrada.Location = new System.Drawing.Point(47, 126);
            this.lEntrada.Name = "lEntrada";
            this.lEntrada.Size = new System.Drawing.Size(74, 13);
            this.lEntrada.TabIndex = 4;
            this.lEntrada.Text = "Texto Entrada";
            this.lEntrada.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxEntrada
            // 
            this.TextBoxEntrada.Enabled = false;
            this.TextBoxEntrada.Location = new System.Drawing.Point(142, 126);
            this.TextBoxEntrada.Name = "TextBoxEntrada";
            this.TextBoxEntrada.Size = new System.Drawing.Size(593, 20);
            this.TextBoxEntrada.TabIndex = 5;
            // 
            // tdSalida
            // 
            this.tdSalida.Enabled = false;
            this.tdSalida.Location = new System.Drawing.Point(142, 174);
            this.tdSalida.Name = "tdSalida";
            this.tdSalida.Size = new System.Drawing.Size(593, 20);
            this.tdSalida.TabIndex = 7;
            // 
            // lSalida
            // 
            this.lSalida.AutoSize = true;
            this.lSalida.Location = new System.Drawing.Point(47, 174);
            this.lSalida.Name = "lSalida";
            this.lSalida.Size = new System.Drawing.Size(66, 13);
            this.lSalida.TabIndex = 6;
            this.lSalida.Text = "Texto Salida";
            // 
            // FPrincipalV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tdSalida);
            this.Controls.Add(this.lSalida);
            this.Controls.Add(this.TextBoxEntrada);
            this.Controls.Add(this.lEntrada);
            this.Controls.Add(this.bTransferir);
            this.Controls.Add(this.BotonActivar);
            this.Controls.Add(this.BotonSoloLectura);
            this.Controls.Add(this.BVisible);
            this.Name = "FPrincipalV2";
            this.Text = "Windows Forms Mi Aplicacion de Prueba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Miembros Privados de la Clase Forms

        private System.Windows.Forms.Button BVisible;
        private System.Windows.Forms.Button BotonSoloLectura;
        private System.Windows.Forms.Button BotonActivar;
        private System.Windows.Forms.Button bTransferir;
        private System.Windows.Forms.Label lEntrada;
        private System.Windows.Forms.TextBox TextBoxEntrada;
        private System.Windows.Forms.TextBox tdSalida;
        private System.Windows.Forms.Label lSalida;
    }
}

