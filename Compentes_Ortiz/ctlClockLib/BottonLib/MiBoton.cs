using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BottonLib
{
    public partial class MiBoton : UserControl
    {
        private String txtBoton;

        public MiBoton()
        {
            InitializeComponent();
        }

        public String ButtonText
        // Retrieves the value of the private variable colBColor.
        {
            get
            {
                return txtBoton;
            }
            // Stores the selected value in the private variable colBColor, and 
            // updates the backcolor of the label control lblDisplay.
            set
            {
                txtBoton = value;
                btnGrafico.Text = txtBoton;
            }
        }

        private void MiBoton_Load(object sender, EventArgs e)
        {

        }
    }
}
