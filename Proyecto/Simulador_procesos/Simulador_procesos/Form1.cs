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
    public partial class P_Lotes : Form
    {
        public P_Lotes()
        {
            InitializeComponent();
            lblconfig.BackColor = TransparencyKey;
           
        }

       
        public void Recorrer()
        {
            /*foreach (DataGridViewRow row in dataProcesos.Rows)
            {
                int i = 2;
                    if (Convert.ToInt32(row.Cells[i].Value.ToString()) <= Convert.ToInt32(txtnumero.Text))
                    {
                        i++;
                    }
               
            }*/


            foreach (DataGridViewRow Row in dataProcesos.Rows)
            {
                string valorcpu = Row.Cells["CPU_column"].Value.ToString();
                int valorejecucion = Convert.ToInt32(valorcpu);

                if (valorejecucion <= Convert.ToInt32(txtnumero.Text))
                {
                    dataProcesos.Rows[valorejecucion].DefaultCellStyle.BackColor = Color.Red;
                }
            }

           /* foreach (DataGridViewRow row in dataProcesos.Rows)
            {
                string valortiempollegada=row.Cells["Tiempo_LL"].Value.ToString();
                int valorinstante = Convert.ToInt32(valortiempollegada);
                string valorcpu = row.Cells["CPU_column"].Value.ToString();
                int valorejecucion = Convert.ToInt32(valorcpu);
                if (valorejecucion<=Convert.ToInt32(txtnumero.Text))
                {
                     String valorestado = row.Cells["Estado_column"].Value.ToString();
                    row.Cells["Estado_column"].Value = "Ejecución";
                    //int valorestados = Convert.ToInt32(valorestado);
                }
                else
                {
                    String valorestado = row.Cells["Estado_column"].Value.ToString();
                    MessageBox.Show("El proceso fue enviado al final de la cola");
                    int valorestados = Convert.ToInt32(valorestado);
                }

                

                
                
            }*/

           
           
        }

           
        


        private void picAgregar_Click(object sender, EventArgs e)
        {
            string config, tipoconfig, cpu, tiempo, prioridad,listo;
            config = cboconfig.SelectedItem.ToString();
            tipoconfig = cbotipoconfig.SelectedItem.ToString();
            cpu = txtCpu.Text;
            tiempo = txtTiempo.Text;
            prioridad = cboPrioridad.SelectedItem.ToString();
            listo = "Listo";
            dataProcesos.Rows.Add(config, tipoconfig, tiempo, cpu, prioridad, listo);
        }
    
       
        private void button2_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in dataProcesos.Rows)
            {
                string valorcpu = row.Cells["CPU_column"].Value.ToString();
                int valorejecucion = Convert.ToInt32(valorcpu);


            }*/
         
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cboconfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorcombo = cboconfig.SelectedItem.ToString();
            if (valorcombo=="Dispositivo de E/S")
            {
                lbldecision.Text = "DISPOSITIVO";
                lbldecision.Visible = true;
                cbotipoconfig.Visible = true;
                cbotipoconfig.Items.Add("Micrófono");
                cbotipoconfig.Items.Add("Teclado");
                cbotipoconfig.Items.Add("Mouse");
                cbotipoconfig.Items.Add("Scanner");
                cbotipoconfig.Items.Add("Web Cam");
                cbotipoconfig.Items.Add("Lápiz óptico");
                cbotipoconfig.Items.Add("Lector de código de barras");
                cbotipoconfig.Items.Add("Pantalla");
                cbotipoconfig.Items.Add("Impresora");
                cbotipoconfig.Items.Add("Bocinas");
                cbotipoconfig.Items.Add("Altavoz");
                cbotipoconfig.Items.Add("Fax");
                cbotipoconfig.Items.Add("Auriculares");
            }

            else
            {
                if (valorcombo == "Programa")
                {
                    lbldecision.Text = "PROGRAMA";
                    lbldecision.Visible = true;
                    cbotipoconfig.Visible = true;
                    cbotipoconfig.Items.Add("VLC media");
                    cbotipoconfig.Items.Add("Media Player");
                    cbotipoconfig.Items.Add("VirtualBox");
                    cbotipoconfig.Items.Add("7-Zip");
                    cbotipoconfig.Items.Add("Google Chrome");
                    cbotipoconfig.Items.Add("Microsoft Word");
                    cbotipoconfig.Items.Add("Visual Studio");
                    cbotipoconfig.Items.Add("Recortes");
                    cbotipoconfig.Items.Add("Papelera de Reciclaje");
                    cbotipoconfig.Items.Add("Otro");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {          
            int suma = 0;
            foreach (DataGridViewRow row in dataProcesos.Rows)
            {
                string valorcpu = row.Cells["CPU_column"].Value.ToString();
                int valorejecucion = Convert.ToInt32(valorcpu);
                suma = suma + valorejecucion;

                if (valorejecucion <= Convert.ToInt32(txtnumero.Text))
                {
                    row.Cells["Estado_column"].Style.BackColor = Color.Aquamarine;
                    row.Cells["Estado_column"].Value = "Ejecución";
                   

                }

                else
                {
                    row.Cells["Estado_column"].Style.BackColor = Color.Aquamarine;
                    row.Cells["Estado_column"].Value = "Ejecución";
                    row.Cells["Estado_column"].Style.BackColor = Color.Red;
                    row.Cells["Estado_column"].Value = "Bloqueo";
                }
                txtsuma.Text = Convert.ToString(suma);
               

            }

            
        }

      

        private void TimerAlgoritmo_Tick(object sender, EventArgs e)
        {

            Double total = Convert.ToDouble(lbltimer.Text);
            total = total + 1;
            lbltimer.Text = total.ToString();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataProcesos.Rows)
            {
                string valorcpu = row.Cells["CPU_column"].Value.ToString();
                int valorejecucion = Convert.ToInt32(valorcpu);

                TimerAlgoritmo.Start();
                TimerAlgoritmo.Interval = (valorejecucion * 1000);


                if (valorejecucion <= Convert.ToInt32(txtnumero.Text))
                {
                    MessageBox.Show("El proceso se ejecutará exitosamente");
                    row.Cells["Estado_column"].Style.BackColor = Color.Aquamarine;
                    row.Cells["Estado_column"].Value = "Ejecución";


                    if (TimerAlgoritmo.Interval == valorejecucion * 1000)
                    {
                        TimerAlgoritmo.Stop();
                        row.Cells["Estado_column"].Style.BackColor = Color.Cyan;
                        row.Cells["Estado_column"].Value = "Terminado";

                    }

                }
                else
                {
                    MessageBox.Show("El proceso alcanzó su tiempo máximo, se reanudará posteriormente");
                    row.Cells["Estado_column"].Value = "Bloqueado";
                    row.Cells["Estado_column"].Style.BackColor = Color.Red;

                }







            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataProcesos.Rows)
            {
                if (row.Cells["Estado_column"].Value == "Bloqueado")
                {
                    row.Cells["Estado_column"].Style.BackColor = Color.Cyan;
                    row.Cells["Estado_column"].Value = "Terminado";
                    MessageBox.Show("Todos los procesos han salido");
                }
            }
        }

       

        
    }

}
