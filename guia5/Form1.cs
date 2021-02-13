using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            salarytxt.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(salarytxt.Text);
            if (gerntbuttom.Checked)
            {
                double R1 = salary * 0.20;
                double RF = salary - R1;
                label4.Text = "sueldo Liquido: " + RF.ToString();
                label5.Text = "Gerente: " + nametxt.Text + "\nsalario: " + salary + "\ndescontado: " + R1;
            }
            else if (subGbuttom.Checked)
            {
                double R2 = salary * 0.15;
                double RF = salary - R2;
                label4.Text = "Sueldo liquido: " +RF.ToString();
                label5.Text = "SubGerente: " + nametxt.Text + "\nsalario:" + salary + "\ndescontado: " + R2;
            }
            else if (secretbuttom.Checked)
            {
                double R3 = salary * 0.05;
                double RF = salary - R3;
                label4.Text = "sueldo liquido: " + RF.ToString();
                label5.Text = "Secretaria: " + nametxt.Text + "\nsalario: " + salary +"\ndescontado: " + R3;
            }
                        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
