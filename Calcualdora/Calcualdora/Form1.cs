using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcualdora
{
    public partial class Form1 : Form
    {
        double n1, n2, r;
        public Form1()
        {
            InitializeComponent();
            txtNum1.Text = "";
            txtNum2.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                
                string RBselec;
                n1 = double.Parse(txtNum1.Text);
                n2 = double.Parse(txtNum2.Text);
                r = n1 + n2;
                RBselec = "Usted ha seleccionado la opcion de Suma";

                txtRBSelec.Text = r.ToString();
                lblOpcion.Text = RBselec.ToString();
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    string RBselec;
                    n1 = double.Parse(txtNum1.Text);
                    n2 = double.Parse(txtNum2.Text);
                    r = n1 - n2;
                    RBselec = "Usted ha seleccionado la opcion de Resta";

                    txtRBSelec.Text = r.ToString();
                    lblOpcion.Text = RBselec.ToString();
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        string RBselec;
                        n1 = double.Parse(txtNum1.Text);
                        n2 = double.Parse(txtNum2.Text);
                        r = n1 * n2;
                        RBselec = "Usted ha seleccionado la opcion de Multiplicacion";

                        txtRBSelec.Text = r.ToString();
                        lblOpcion.Text = RBselec.ToString();
                    }
                    else
                    {
                        if (radioButton4.Checked == true)
                        {
                            string RBselec;
                            n1 = double.Parse(txtNum1.Text);
                            n2 = double.Parse(txtNum2.Text);
                            r = n1 / n2;
                            RBselec = "Usted ha seleccionado la opcion de Division";

                            txtRBSelec.Text = r.ToString();
                            lblOpcion.Text = RBselec.ToString();
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
