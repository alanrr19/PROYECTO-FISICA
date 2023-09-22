namespace PROYECTO_FISICA
{
    partial class caso1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caso1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnINGRESAR = new System.Windows.Forms.Button();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblTHETA = new System.Windows.Forms.Label();
            this.txtFtotal = new System.Windows.Forms.TextBox();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA LOS DATOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnINGRESAR
            // 
            this.btnINGRESAR.Location = new System.Drawing.Point(543, 157);
            this.btnINGRESAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnINGRESAR.Name = "btnINGRESAR";
            this.btnINGRESAR.Size = new System.Drawing.Size(84, 32);
            this.btnINGRESAR.TabIndex = 2;
            this.btnINGRESAR.Text = "Ingresar valores";
            this.btnINGRESAR.UseVisualStyleBackColor = true;
            this.btnINGRESAR.Click += new System.EventHandler(this.btnINGRESAR_Click);
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(560, 35);
            this.txtT1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(68, 20);
            this.txtT1.TabIndex = 3;
            this.txtT1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "T1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "M";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(560, 92);
            this.txtM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(68, 20);
            this.txtM.TabIndex = 5;
            this.txtM.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "T2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(560, 62);
            this.txtT2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(68, 20);
            this.txtT2.TabIndex = 7;
            this.txtT2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = " θ ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(560, 122);
            this.txtTheta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(68, 20);
            this.txtTheta.TabIndex = 9;
            this.txtTheta.Text = "0";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(45, 92);
            this.lblT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(13, 13);
            this.lblT1.TabIndex = 11;
            this.lblT1.Text = "0";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(157, 166);
            this.lblM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(13, 13);
            this.lblM.TabIndex = 12;
            this.lblM.Text = "0";
            this.lblM.Click += new System.EventHandler(this.lblM_Click);
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(187, 126);
            this.lblT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(13, 13);
            this.lblT2.TabIndex = 13;
            this.lblT2.Text = "0";
            // 
            // lblTHETA
            // 
            this.lblTHETA.AutoSize = true;
            this.lblTHETA.Location = new System.Drawing.Point(103, 27);
            this.lblTHETA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTHETA.Name = "lblTHETA";
            this.lblTHETA.Size = new System.Drawing.Size(13, 13);
            this.lblTHETA.TabIndex = 14;
            this.lblTHETA.Text = "0";
            // 
            // txtFtotal
            // 
            this.txtFtotal.Location = new System.Drawing.Point(560, 216);
            this.txtFtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFtotal.Name = "txtFtotal";
            this.txtFtotal.Size = new System.Drawing.Size(68, 20);
            this.txtFtotal.TabIndex = 15;
            this.txtFtotal.Text = "0";
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.Location = new System.Drawing.Point(29, 199);
            this.btnCALCULAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(145, 44);
            this.btnCALCULAR.TabIndex = 16;
            this.btnCALCULAR.Text = "Calcular";
            this.btnCALCULAR.UseVisualStyleBackColor = true;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // caso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 484);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.txtFtotal);
            this.Controls.Add(this.lblTHETA);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.btnINGRESAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "caso1";
            this.Text = "ñ";
            this.Load += new System.EventHandler(this.caso1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnINGRESAR;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblTHETA;
        private System.Windows.Forms.TextBox txtFtotal;
        private System.Windows.Forms.Button btnCALCULAR;
    }
}