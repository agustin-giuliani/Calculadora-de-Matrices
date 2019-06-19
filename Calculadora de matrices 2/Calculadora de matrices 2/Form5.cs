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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void cargarA_Click(object sender, EventArgs e)
        { 
            
                try
                {
                    int y = System.Convert.ToInt16(tetcolumnaA.Text);
                    int x = System.Convert.ToInt16(tetfilaA.Text);
                    dataGridView1.ColumnCount = y;
                    dataGridView1.RowCount = x;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception)
                {
                    MessageBox.Show("introducir un numero Real en los casilleros correspondientes");
                }

            
        }

        private void cargarB_Click(object sender, EventArgs e)
        {
            try
            {
                int y = System.Convert.ToInt16(tetcolumnaB.Text);
                int x = System.Convert.ToInt16(tetfilaB.Text);
                int z = System.Convert.ToInt32(tetcolumnaA.Text);
                int p = System.Convert.ToInt32(tetfilaA.Text);
                if (z == x)
                {
                    dataGridView2.ColumnCount = y;
                    dataGridView2.RowCount = x;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView3.ColumnCount = y;
                    dataGridView3.RowCount = p;
                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else MessageBox.Show("para que el producto de una matriz pueda ser realizada es nesesario que la cantidad de columnas de A sea igual a las filas de B");
            }
            catch (Exception)
            {
                MessageBox.Show("introducir un numero Real en los casilleros correspondientes");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j;
            Decimal filaA, columnaB, result;

            filaA = System.Convert.ToDecimal(tetfilaA.Text);
            columnaB = System.Convert.ToDecimal(tetcolumnaB.Text);


            try
            {
                for (i = 0; i < filaA; i++)//recorre fila matriz resultado
                {
                    //MessageBox.Show("Fila A: ", Convert.ToString(i));
                    for (j = 0; j < columnaB; j++)//recorre columna de matriz resultado
                    {
                        //MessageBox.Show("Columna B: ", Convert.ToString(j));
                        dataGridView3.Rows[i].Cells[j].Value = 0;
                        for (int p = 0; p < columnaB - 1; p++)
                        {

                            // MessageBox.Show(p.ToString(), Convert.ToString(dgvResultado.Rows[i].Cells[j].Value));
                            dataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView3.Rows[i].Cells[j].Value) + Convert.ToDouble(dataGridView1.Rows[i].Cells[p].Value) * Convert.ToDouble(dataGridView2.Rows[p].Cells[j].Value);
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("algo", "Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
