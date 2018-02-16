using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_procesos
{
    public partial class Round_Robin : Form
    {
        public Round_Robin()
        {
            InitializeComponent();
            int Contador;//Contador del total de procesos que se van ingresando
            int NProceso;//Carga el número de procesos ejecutándose
            int Rafaga = 0;//Carga la ráfaga en ejecución
            int Quantum = 0;//Carga el quantum en ejecución
            int ResiduoRafaga = 0;//Carga el residuo en ejecución
            int TiempoProceso = 0;//Carga el tiempo que se dura procesando
            int ValorBarra;//Carga el progreso de la Barra
            int CantidadProcesos;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Ingresar()
        { //Ingresar proceso a la tabla

            int Contador = 1;
            Contador++;
            Object[] miTabla = new Object[5];
            miTabla[0] = Contador;
            miTabla[1] = txtCpu.Text;
            miTabla[2] = txtnumero.Text;
            miTabla[3] = txtCpu.Text;
            miTabla[4] = "Listo";
            datalistaprocesos.Rows.Add(miTabla);
            txtCpu.Text = "";
            txtCpu.Focus();
            
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(txtCpu.Text)) <= 100)
            {
                Ingresar();
                txtnumero.Enabled = false;
            }
            else
            {
                MessageBox.Show("Las Rafagas no pueden ser mayores de 100");
                txtCpu.Text = "";
                txtCpu.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
