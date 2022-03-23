using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrindadeMDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textValue1.Text);
                int b = int.Parse(textValue2.Text);

               
                List<int> result = CalcularMDC.MDC(a, b);
                int last = result.Last();
                textResultado.Text = $"Vamos calcular o MDC de {a} e {b}\r\n";
                foreach (int ele in result)
                {
                    textResultado.Text += $"{ele} \r\n";
                    if (ele == last)
                    {
                        textResultado.Text += $"O MDC de {a} e {b} é {ele} \r\n";
                    }
                }

                textValue1.Text = "";
                textValue2.Text = "";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                textValue1.Text = "";
                textValue2.Text = "";
            }
        }
    }
}
