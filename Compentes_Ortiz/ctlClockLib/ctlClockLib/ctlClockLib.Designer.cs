namespace ctlClockLib
{
    partial class ctlClockLib
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbZonasHorarias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(2, 29);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(121, 25);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "CONTROL";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbZonasHorarias
            // 
            this.cmbZonasHorarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZonasHorarias.FormattingEnabled = true;
            this.cmbZonasHorarias.Location = new System.Drawing.Point(146, 29);
            this.cmbZonasHorarias.Name = "cmbZonasHorarias";
            this.cmbZonasHorarias.Size = new System.Drawing.Size(141, 28);
            this.cmbZonasHorarias.TabIndex = 3;
            this.cmbZonasHorarias.SelectedIndexChanged += new System.EventHandler(this.cmbZonasHorarias_SelectedIndexChanged);
            // 
            // ctlClockLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbZonasHorarias);
            this.Controls.Add(this.lblDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctlClockLib";
            this.Size = new System.Drawing.Size(304, 103);
            this.Load += new System.EventHandler(this.ctlClockLib_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbZonasHorarias;
    }
}
