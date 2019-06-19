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
    public partial class Form3 : Form
    {
        public Form3()
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
                dataGridView3.ColumnCount = y;
                dataGridView3.RowCount = x;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("la fila o columna tiene que tener como minimo valor 0");
            }
        }

        private void RestaMatrices(bool esSuma)
        {
            int i, j;
            int fila, columna;

            fila = System.Convert.ToInt32(tetfila.Text);
            columna = System.Convert.ToInt32(tetcolumna.Text);

            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    if (esSuma)
                        dataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) - Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);

                }
            }
        }

        private void buttresta_Click(object sender, EventArgs e)
        {
            RestaMatrices(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();

        }
    }
}
