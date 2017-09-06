using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConecxionDB.Dataset.DatasetConecxionTableAdapters;
namespace WindowsFormsApplication3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var x = new EmpleadoTableAdapter();
            x.InsertEmpleado(textBox1.Text, textBox2.Text);
            dataGridView1.DataSource = x.GetDataByEmpleado();
            dataGridView1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var x = new EmpleadoTableAdapter();
            dataGridView1.DataSource = x.GetDataByEmpleado();
            dataGridView1.Refresh();

        }
    }
}
