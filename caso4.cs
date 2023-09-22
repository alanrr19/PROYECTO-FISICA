using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FISICA
{
    public partial class caso4 : Form
    {
        public caso4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            double dato;

            dato = Convert.ToDouble(txtTHETA.Text);

            if (dato <= 0)
            {
                MessageBox.Show("EL ANGULO NO PUEDE SER NEGATIVO! ");

            }
            else if (dato > 0)
            { DATOT1.Text = txtT1.Text;
                DATOT2.Text = txtT2.Text;
                datoTHETA.Text = txtTHETA.Text;
                L1.Visible = false;
                L2.Visible = false;
                L3.Visible = false;
                L4.Visible = false;
                L5.Visible = false;
                L6.Visible = false;
                L7.Visible = false;
                L8.Visible = false;
                LBLTHETA.Visible = false;
                LT1.Visible = false;
                LT2.Visible = false;
                label1.Visible = false;
                btnINGRESAR.Visible = false;
                DATOT1.Text = txtT1.Text;
                DATOT2.Text = txtT2.Text;
                datoTHETA.Text = txtTHETA.Text;
                double tension,w1,w2;
                tension = Convert.ToDouble(txtTS.Text);
                w1=Convert.ToDouble(txtT1.Text); 
                w2 = Convert.ToDouble(txtT2.Text); 
                btnCALCULAR.Visible = true; 
       if (w1 >0) {

                    lblts1.Text = txtT1.Text;
                  lblT.Text= txtT1.Text;    

                }
                if (w2 > 0)
                {

                    lblt2s.Text = txtT2.Text;
                    lblT.Text= txtT2.Text;  
                }
            }
            

        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            double t1, t2, m1, m2, theta,re1,re2,w1,w2;
            theta = Convert.ToDouble(datoTHETA.Text);
            t1=Convert.ToDouble(DATOT1.Text);
            t2=Convert.ToDouble(DATOT2.Text);
            
            if (t1 == 0) {
                w1 = t2; 
                m1 = (Math.Cos(90 - theta));
                re1 = w1/m1; 

                MessageBox.Show("La tension de t1 y su peso es de  "+re1);
                lblts1.Text = (""+re1);
                DATOT1.Text = (""+re1);

            }
            else if (t2 == 0) {
                w2= t1; 
                m1 = (Math.Cos(90 - theta));
                re2 = w2 / m1;
                MessageBox.Show("La tension de t1 y su peso es de  " + re2);
               lblt2s.Text = ("" + re2);
                DATOT2.Text = (""+re2);            }




        }

        private void caso4_Load(object sender, EventArgs e)
        {
            btnCALCULAR.Visible = false; 

        }
    }
}
