namespace Calculadora_de_matrices_2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttcarga = new System.Windows.Forms.Button();
            this.buttresta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tetcolumna = new System.Windows.Forms.TextBox();
            this.tetfila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(291, 200);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(584, 200);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(213, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // buttcarga
            // 
            this.buttcarga.Location = new System.Drawing.Point(138, 62);
            this.buttcarga.Name = "buttcarga";
            this.buttcarga.Size = new System.Drawing.Size(75, 23);
            this.buttcarga.TabIndex = 3;
            this.buttcarga.Text = "cargar";
            this.buttcarga.UseVisualStyleBackColor = true;
            this.buttcarga.Click += new System.EventHandler(this.buttcarga_Click);
            // 
            // buttresta
            // 
            this.buttresta.Location = new System.Drawing.Point(198, 384);
            this.buttresta.Name = "buttresta";
            this.buttresta.Size = new System.Drawing.Size(75, 23);
            this.buttresta.TabIndex = 4;
            this.buttresta.Text = "restar";
            this.buttresta.UseVisualStyleBackColor = true;
            this.buttresta.Click += new System.EventHandler(this.buttresta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(542, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Borra Matrices";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tetcolumna
            // 
            this.tetcolumna.Location = new System.Drawing.Point(24, 31);
            this.tetcolumna.Name = "tetcolumna";
            this.tetcolumna.Size = new System.Drawing.Size(100, 20);
            this.tetcolumna.TabIndex = 6;
            // 
            // tetfila
            // 
            this.tetfila.Location = new System.Drawing.Point(24, 101);
            this.tetfila.Name = "tetfila";
            this.tetfila.Size = new System.Drawing.Size(100, 20);
            this.tetfila.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tetfila);
            this.Controls.Add(this.tetcolumna);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttresta);
            this.Controls.Add(this.buttcarga);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Resta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttcarga;
        private System.Windows.Forms.Button buttresta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tetcolumna;
        private System.Windows.Forms.TextBox tetfila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}