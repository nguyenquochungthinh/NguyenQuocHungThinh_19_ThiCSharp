using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuocHungThinh_19_ThiCSharp
{
    public partial class GiaiPhuongTrinhBac2 : Form
    {
        public GiaiPhuongTrinhBac2()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            int intA, intB, intC;
            double x1, x2, delta;
            intA = Convert.ToInt32(txtSoA.Text);
            intB = Convert.ToInt32(txtSoB.Text);
            intC = Convert.ToInt32(txtSoC.Text);
            if (intA == 0)
            {
                if (intB == 0)
                {
                    if (intC == 0)


                    {
                        lblKQ.Text = "phương trình có vô số nghiệm";

                    }
                    else
                    {
                        lblKQ.Text = "phương trình vô nghiệm";
                    }
                }
                else
                {
                    x1 = (double)-intC / intB;
                    lblKQ.Text = "phương trình có nghiệm duy nhất";
                    lblKQ.Text += x1;

                }
            }
            else
            {
                delta = Math.Pow(intB, 2) - 4 * intA * intC;
                if (delta < 0)
                {
                    lblKQ.Text = "phương trình có vô số nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -intB / (2 * intA);
                    lblKQ.Text = "phương trình có vô sô nghiệm";
                }
                else
                {
                    x1 = (-intB + Math.Sqrt(delta)) / (2 * intA);
                    x2 = (-intB - Math.Sqrt(delta)) / (2 * intA);
                    lblKQ.Text = "phương trình có 2 nghiệm phân biệt" + "\n" + "x1= " + (x1) + "\n" + "x2= " + (x2);
                }

            }
        }
    }
}

