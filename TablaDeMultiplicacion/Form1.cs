using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaDeMultiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                int i = 0;
                int resultado;

                while (i <= 10)
                {
                    resultado = numero * i;
                    listBox1.Items.Add("Multiplicado por \n" + i + " = \n" + resultado);
                    i++;
                }
            }
            else
            {
                txtNumero.Clear();
                MessageBox.Show("Ponga un numero entero");
            }

        }
    }
}
