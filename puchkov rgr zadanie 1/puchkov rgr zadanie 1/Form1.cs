
<Project Sdc="Microsoft.NET.Sdc">

<PropertyGroup>
<OutputType>Exe</OutputType>
<TargetFramework>netcoreapp3.1</TargetFramework>
</PropertyGroup>

</Project>
using System;


namespace puchkov_rgr_zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;
            n = 1;
            int M = Convert.ToInt32(textBox1.Text);
            double x1 = Convert.ToDouble(textBox2.Text);
            double x2 = Convert.ToDouble(textBox3.Text);
            double A = Convert.ToDouble(textBox4.Text);
            double[] x = new double[25];
            double[] y = new double[25];
            x[1] = x1;
            x[M + 2] = x2;

            for (i = 2; i <= (M + 1); i++)
            {
                x[i] = x1 + (x2 - x1) * n / (M + 1);
                n++;
            }

            for (i = 1; i <= (M + 2); i++)
            {
                if (x[i] >= 0)
                {
                    if ((x[i] == 0) && (A == 0))
                    {
                        listBox1.Items.Add(i + ".");
                        listBox1.Items.Add("Для x [ " + i + " ] = " + x[i] + " решений нет");
                        listBox1.Items.Add("");
                    }

                    else
                    {
                        y[i] = -(Math.Sqrt(Math.Sqrt(16*Math.Pow(A,4)+4*Math.Pow(A,2)*Math.Pow(A+x[i],2))-Math.Pow(A,2)));
                        listBox1.Items.Add(i + ".");
                        listBox1.Items.Add("Для x [ " + i + " ] = " + x[i]);
                        listBox1.Items.Add("y [" + i + "] = " + y[i]);
                        listBox1.Items.Add("");
                    }
                }

                else
                {
                    if ((A == 0) && (x[i]<0))
                    {
                        listBox1.Items.Add(i + ".");
                        listBox1.Items.Add("Для x [ " + i + " ] = " + x[i] + " решений нет");
                        listBox1.Items.Add("");
                    }

                    else
                    {
                        y[i] = Math.Sqrt(Math.Pow(A, 2)-Math.Pow(A + x[i], 2))-2*A;
                        listBox1.Items.Add(i + ".");
                        listBox1.Items.Add("Для x [ " + i + " ] = " + x[i]);
                        listBox1.Items.Add("y [" + i + "] = " + y[i]);
                        listBox1.Items.Add("");
                    }
                }

                button1.Enabled = false;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            listBox1.Items.Clear();
            button1.Enabled = true;
            textBox1.Focus();
        }
    }
}


