using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace archivos3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream archivo;
            Random rnd = new Random();
            int i, num = 0;
            double prom, suma = 0;
            string valoresMayorAlPromedio = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                    File.Delete(saveFileDialog1.FileName);
                archivo = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter flujoEscritura = new StreamWriter(archivo);
                for (i = 0; i < 20; i++)
                {
                    num = rnd.Next(100);
                    suma += rnd.Next(100);
                    flujoEscritura.Write(rnd.Next(100));
                }
                flujoEscritura.Close();
                archivo.Close();
                prom = suma / 20;
                label2.Text = "" + prom.ToString();
                if (num > prom)
                {
                    if (valoresMayorAlPromedio.Length > 0)
                    {
                        valoresMayorAlPromedio += " ";
                    }
                    valoresMayorAlPromedio += num.ToString();
                }
                label4.Text = valoresMayorAlPromedio;

            }
        }
    }
}
