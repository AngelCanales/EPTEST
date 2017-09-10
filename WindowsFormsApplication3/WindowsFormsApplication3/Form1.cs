using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicaDeNegocio.Logic;
using WindowsFormsApplication3.ViewModel;
using ConecxionDB.Modelo;
namespace WindowsFormsApplication3
{

    public partial class Form1 : Form
    {
       LogicEmpleado logicEmpleado = new LogicEmpleado();
   
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var Eempleado = new Empleado();
            Eempleado.Nombre = textBox1.Text;
            Eempleado.Puesto = textBox2.Text;
            logicEmpleado.AgregarEmpleado(Eempleado);
            dataGridView1.DataSource = logicEmpleado.llenarGrid();
            dataGridView1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = logicEmpleado.llenarGrid();
            dataGridView1.Refresh();

        }
    }
}
