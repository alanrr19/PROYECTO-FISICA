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
    public partial class casos : Form
    {
        public casos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            caso1 obj= new caso1 ();
            obj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caso2 obj= new caso2 ();
            obj.Show();
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj= new Form1 ();
            obj.Show();
            this.Close ();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            caso4 obj= new caso4 ();
            obj.Show();
            this.Close ();  

        }

        private void button5_Click(object sender, EventArgs e)
        {
         Form1 obj= new Form1 ();
            obj.Show();
            this.Close ();
        }
    }
}
