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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_Lotes frm = new P_Lotes();
            Inicio frm2 = new Inicio();
            frm.Show();
            frm2.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_Lotes frm = new P_Lotes();
            Inicio frm2 = new Inicio();
            Round_Robin frm3 = new Round_Robin();
            frm3.Show();
            frm2.Hide();
        }

       private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
