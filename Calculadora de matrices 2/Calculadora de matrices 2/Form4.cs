using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_matrices_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttcarga_Click(object sender, EventArgs e)
        {
            try
            {
                int y = System.Convert.ToInt16(tetcolumna.Text);
                int x = System.Convert.ToInt16(tetfila.Text);
                dataGridView1.ColumnCount = y;
                dataGridView2.ColumnCount = y;
                dataGridView1.RowCount = x;
                dataGridView2.RowCount = x;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
            catch (Exception)
            {
                MessageBox.Show("la fila o columna tiene que tener como minimo valor 0");
            }

        }
        private void multiplicarEscalar(bool multi)
        {

            try
            {
                int i, j;
                int fila, columna;
                int p = System.Convert.ToInt32(escalar.Text);

                fila = System.Convert.ToInt32(tetfila.Text);
                columna = System.Convert.ToInt32(tetcolumna.Text);

                for (i = 0; i < fila; i++)
                {
                    for (j = 0; j < columna; j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) * p;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ingrese un numero cualquiera en producto escalar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            multiplicarEscalar(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
