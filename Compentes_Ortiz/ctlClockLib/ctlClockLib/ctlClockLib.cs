using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;using System.IO;
using System.Collections;

namespace ctlClockLib
{
    public partial class ctlClockLib : UserControl
    {
        private Color colFColor;
        private Color colBColor;
        private double diffhora;
        private String signo;
        // Declares the name and type of the property.
        public Color ClockBackColor
        // Retrieves the value of the private variable colBColor.
        {
            get
            {
                return colBColor;
            }
            // Stores the selected value in the private variable colBColor, and 
            // updates the backcolor of the label control lblDisplay.
            set
            {
                colBColor = value;
                lblDisplay.BackColor = colBColor;
            }
        }
        // Provides a similar set of instructions for the forecolor.
        public Color ClockForeColor
        {
            get
            {
                return colFColor;
            }
            set
            {
                colFColor = value;
                lblDisplay.ForeColor = colFColor;
            }
        }

        public ctlClockLib()
        {
            InitializeComponent();
            
        }

        public virtual void timer1_Tick(object sender, EventArgs e)
        {
            if (signo == "+")
                lblDisplay.Text = DateTime.Now.AddHours(diffhora).ToLongTimeString();
            else
                lblDisplay.Text = DateTime.Now.AddHours(-diffhora).ToLongTimeString();
        }

       
       

        private void ctlClockLib_Load(object sender, EventArgs e)
        {
            leerZonaHoraria();
        }

        private void leerZonaHoraria()
        {

            StreamReader objReader = new StreamReader("C:\\Users\\graura\\Dropbox\\Docencia\\ProgAvanzada\\UnidadI\\componentsample\\ctlClockLib\\ctlClockLib\\ZonasHorarias.txt");
            string sLine = "";
            ArrayList arrText = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();
            arrText.Sort();
            cmbZonasHorarias.DataSource = arrText;

        }

        private void cmbZonasHorarias_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            String hora;
            hora = cmbZonasHorarias.SelectedValue.ToString();
            signo = hora.Substring(hora.IndexOf(',')+1,1);
            hora = hora.Substring(hora.IndexOf(',') + 2);
            diffhora = double.Parse(hora);
        }
       
    }
}
