using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FISICA
{
    public partial class caso2 : Form
    {
        public caso2()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            double alfa, beta,masa,tension1,tension2;
            alfa = Convert.ToDouble(TxtAlfa.Text);
            beta = Convert.ToDouble(TxtBeta.Text);
            masa = Convert.ToDouble(TxtMasa.Text);
            tension1 = Convert.ToDouble(TxtT1.Text);
            tension2 = Convert.ToDouble(TxtT2.Text);
            if (masa == 0 && tension1 == 0 && tension2 == 0)
            {
                MessageBox.Show("Debes ingresar al menos una fuerza");

            }
            else if ((alfa==0 && tension1==0)||(beta==0 && tension2==0))
            {
                MessageBox.Show("Con los datos ingresados no se puede realizar los calculos");
            }
            else if (masa == 0 && tension1 > 0 && tension2 == 0 && alfa == 0)
            {
                MessageBox.Show("Con los datos ingresados no se puede realizar los calculos");
            }
            else if (masa == 0 && tension1 == 0 && tension2 > 0 && beta == 0)
            {
                MessageBox.Show("Con los datos ingresados no se puede realizar los calculos");
            }
            else
            {
                LblT1I.Visible = true;
                LblT2I.Visible = true;
                LblMasaI.Visible = true;
                LblAlfaI.Visible = true;
                LblBetaI.Visible = true;
                BtnCalcular.Visible = true;
                LblT1I.Text = TxtT1.Text;
                LblT2I.Text = TxtT2.Text;
                LblMasaI.Text = TxtMasa.Text;
                LblBetaI.Text = TxtBeta.Text;
                LblAlfaI.Text = TxtAlfa.Text;
                LblT1.Visible = false;
                LblT2.Visible = false;
                LblMasa.Visible = false;
                LblAlfa.Visible = false;
                LblBeta.Visible = false;
                BtnIngresar.Visible = false;
                TxtT1.Visible= false;
                TxtT2.Visible= false;
                TxtAlfa.Visible= false;
                TxtBeta.Visible= false;
                TxtMasa.Visible = false;
                
            }           
        }

        private void caso2_Load(object sender, EventArgs e)
        {
            LblT1I.Visible = false;
            LblT2I.Visible = false;
            LblMasaI.Visible = false;
            LblAlfaI.Visible = false;
            LblBetaI.Visible = false;
            BtnCalcular.Visible = false;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double alfa, beta, masa, tension1, tension2,alfag = 0,betag=0;
            alfa = Convert.ToDouble(LblAlfaI.Text);
            beta = Convert.ToDouble(LblBetaI.Text);
            masa = Convert.ToDouble(LblMasaI.Text);
            tension1 = Convert.ToDouble(LblT1I.Text);
            tension2 = Convert.ToDouble(LblT2I.Text);

            if (tension1 == 0)
            {
                double R;
                alfag = alfa * (Math.PI / 180);
                betag = beta * (Math.PI / 180);
                R = Math.Abs((tension2*Math.Cos(betag))/ (Math.Cos(alfag)));                                
                LblT1I.Text = R.ToString("0.00");
            }
            if (tension2 == 0)
            {
                double R;
                alfag = alfa * (Math.PI / 180);
                betag = beta * (Math.PI / 180);
                R = Math.Abs((tension1 * Math.Cos(alfag)) / (Math.Cos(betag)));
                LblT2I.Text = R.ToString("0.00");
            }
            if(masa == 0)
            {
                double R;
                alfag = alfa * (Math.PI / 180);
                betag = beta * (Math.PI / 180);
                R = Math.Abs((tension1 * Math.Sin(alfag))+ (tension2 * Math.Sin(betag)));
                LblMasaI.Text = R.ToString("0.00");
            }
            if (alfa == 0)
            {
                double R;
                betag = (beta * (Math.PI / 180));
                R = (Math.Acos(((tension2 * Math.Cos(betag)) / tension1)));
                R = R * (180/Math.PI);
                LblAlfaI.Text = R.ToString("0.00");
            }
            if (beta == 0)
            {
                double R;
                alfag = (alfa * (Math.PI / 180));
                R = (Math.Acos(((tension1 * Math.Cos(alfag)) / tension2)));
                R = R * (180 / Math.PI);
                LblBetaI.Text = R.ToString("0.00");
            }
            if(tension1 == 0 && tension2 == 0)
            {
                double R1,R2;
                alfag = alfa * (Math.PI / 180);
                betag = beta * (Math.PI / 180); 
                R1 = masa/(Math.Sin(alfag)+ Math.Cos(alfag)*Math.Tan(betag));
                R2 = (R1 * Math.Cos(alfag))/Math.Cos(betag);
                LblT1I.Text = R1.ToString("0.00");
                LblT2I.Text = R2.ToString("0.00");
            }
            if (tension2 == 0 && masa == 0)
            {
                double R1, R2;
                alfag = alfa * (Math.PI / 180);
                betag = beta * (Math.PI / 180);
                R1 = (tension1 * Math.Cos(alfag)) / Math.Cos(betag);
                R2 = Math.Abs((tension1 * Math.Sin(alfag)) + (R1 * Math.Sin(betag)));;
                LblT2I.Text = R1.ToString("0.00");
                LblMasaI.Text = R2.ToString("0.00");
            }
            if (tension1 == 0 && masa == 0)
            {
                double R1, R2;
                alfag = alfa * (Math.PI / 180);
                betag = beta * (Math.PI / 180);
                R1 = (tension2 * Math.Cos(betag)) / Math.Cos(alfag);
                R2 = Math.Abs((R1 * Math.Sin(alfag)) + (tension2 * Math.Sin(betag))); ;
                LblT1I.Text = R1.ToString("0.00");
                LblMasaI.Text = R2.ToString("0.00");
            }
        }
    }
}
