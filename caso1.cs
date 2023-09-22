using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PROYECTO_FISICA
{
    public partial class caso1 : Form
    {
        public caso1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
           double theta;
           theta = Convert.ToDouble(txtTheta.Text);
           if (theta ==0)
            {
                MessageBox.Show(" DEBES INGRESAR EL ANGULO TETA");
            }
            lblT1.Visible = true;
            lblT2.Visible = true;
            lblM.Visible = true;
            lblTHETA.Visible = true;
            btnCALCULAR.Visible = true;

            lblT1.Text = txtT1.Text; 
            lblT2.Text = txtT2.Text;
            lblM.Text = txtM.Text;
            lblTHETA.Text=txtTheta.Text;
           
            //ENCONTRAR SOLO TENSIONES
            if (lblT1.Text ==" "){
                double Theta = double.Parse(txtTheta.Text);
                double Masa = double.Parse(txtM.Text);
                double Tension1 = double.Parse(txtT1.Text);
                double Tension2 = double.Parse(txtT2.Text);
                double Ftotal = double.Parse(txtFtotal.Text);

                
                

                double radianes = Math.PI / (Theta * 180);
                
                Tension2 = Masa * Math.Tan(Theta);
                //Ftotal = Math.Sqrt(Tension1 *Tension1 + Tension2 *Tension2"MENOS -2*t1*t2*cos(theta) POR TENSION 1 X TENSION 2 X COS DEL ANGULO ")
                    ; 

                txtTheta.Text = Theta.ToString();
                txtT1.Text = Tension1.ToString();
                txtT2.Text = Tension2.ToString();
                MessageBox.Show("LA TENION 2 ES DE " +Tension2);
            }
           
            


            //if (T1==0) {

            //}
            //else if (T2==0) { 
        }
        //if (M==0) { 
        //}   
        //else if (theta==0) {
        //}

        //}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void caso1_Load(object sender, EventArgs e)
        {
            lblT1.Visible=false;
            lblT2.Visible=false;
            lblM.Visible=false;
            lblTHETA.Visible=false;
            btnCALCULAR.Visible=false;  
        }

        private void lblM_Click(object sender, EventArgs e)
        {

        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            txtT1.Visible = false; 
            txtT2.Visible = false;
            txtM.Visible = false;
            txtTheta.Visible=false;
            btnINGRESAR.Visible=false;
            label2.Visible=false;   
            label3.Visible=false;   
            label4.Visible=false; 
            label5.Visible=false; 
            label1.Visible=false;
            if (lblT2.Text == "0")
            {
                double Theta = double.Parse(lblTHETA.Text);
                double Masa = double.Parse(lblM.Text);
                double Tension1 = double.Parse(lblT1.Text);
                double Tension2 = double.Parse(lblT2.Text);
                double Ftotal = double.Parse(txtFtotal.Text);

                double radianes = Math.PI / (Theta * 180);
                Tension2 = Masa * Math.Cos(radianes);
               // Tension2 = Masa * Math.Cos(radianes);

              //  txtTheta.Text = Theta.ToString();
                lblT2.Text = Tension2.ToString();
                MessageBox.Show("La tension de T2 es:  ",lblT2.Text);
               // txtT2.Text = Tension2.ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
