namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.miBoton1 = new BottonLib.MiBoton();
            this.ctlClockLib2 = new ctlClockLib.ctlClockLib();
            this.ctlClockLib1 = new ctlClockLib.ctlClockLib();
            this.SuspendLayout();
            // 
            // miBoton1
            // 
            this.miBoton1.ButtonText = "Cualquier cosa";
            this.miBoton1.Location = new System.Drawing.Point(101, 92);
            this.miBoton1.Name = "miBoton1";
            this.miBoton1.Size = new System.Drawing.Size(142, 39);
            this.miBoton1.TabIndex = 2;
            // 
            // ctlClockLib2
            // 
            this.ctlClockLib2.ClockBackColor = System.Drawing.Color.Empty;
            this.ctlClockLib2.ClockForeColor = System.Drawing.Color.Empty;
            this.ctlClockLib2.Location = new System.Drawing.Point(70, -5);
            this.ctlClockLib2.Margin = new System.Windows.Forms.Padding(2);
            this.ctlClockLib2.Name = "ctlClockLib2";
            this.ctlClockLib2.Size = new System.Drawing.Size(304, 103);
            this.ctlClockLib2.TabIndex = 1;
            // 
            // ctlClockLib1
            // 
            this.ctlClockLib1.BackColor = System.Drawing.Color.Red;
            this.ctlClockLib1.ClockBackColor = System.Drawing.Color.Empty;
            this.ctlClockLib1.ClockForeColor = System.Drawing.Color.Empty;
            this.ctlClockLib1.Location = new System.Drawing.Point(70, 145);
            this.ctlClockLib1.Margin = new System.Windows.Forms.Padding(2);
            this.ctlClockLib1.Name = "ctlClockLib1";
            this.ctlClockLib1.Size = new System.Drawing.Size(304, 103);
            this.ctlClockLib1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 323);
            this.Controls.Add(this.miBoton1);
            this.Controls.Add(this.ctlClockLib2);
            this.Controls.Add(this.ctlClockLib1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlClockLib.ctlClockLib ctlClockLib1;
        private ctlClockLib.ctlClockLib ctlClockLib2;
        private BottonLib.MiBoton miBoton1;

    }
}

