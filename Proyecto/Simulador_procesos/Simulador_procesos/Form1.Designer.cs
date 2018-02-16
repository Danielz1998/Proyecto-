namespace Simulador_procesos
{
    partial class P_Lotes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Lotes));
            this.label1 = new System.Windows.Forms.Label();
            this.lblconfig = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboconfig = new System.Windows.Forms.ComboBox();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataProcesos = new System.Windows.Forms.DataGridView();
            this.Tipo_proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo_LL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priori_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbotipoconfig = new System.Windows.Forms.ComboBox();
            this.lbldecision = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.TimerAlgoritmo = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.visualizaralgoritmoboton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMULADOR DE PROCESOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblconfig
            // 
            this.lblconfig.AutoSize = true;
            this.lblconfig.BackColor = System.Drawing.Color.Transparent;
            this.lblconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblconfig.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfig.ForeColor = System.Drawing.Color.Green;
            this.lblconfig.Location = new System.Drawing.Point(44, 99);
            this.lblconfig.Name = "lblconfig";
            this.lblconfig.Size = new System.Drawing.Size(95, 15);
            this.lblconfig.TabIndex = 1;
            this.lblconfig.Text = "CONFIGURAR";
            this.lblconfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblconfig.Click += new System.EventHandler(this.lblconfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(364, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(445, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "PROCESAMIENTO POR LOTES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(350, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "LLEGADA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboconfig
            // 
            this.cboconfig.FormattingEnabled = true;
            this.cboconfig.Items.AddRange(new object[] {
            "Dispositivo de E/S",
            "Programa"});
            this.cboconfig.Location = new System.Drawing.Point(144, 97);
            this.cboconfig.Name = "cboconfig";
            this.cboconfig.Size = new System.Drawing.Size(135, 21);
            this.cboconfig.TabIndex = 6;
            this.cboconfig.SelectedIndexChanged += new System.EventHandler(this.cboconfig_SelectedIndexChanged);
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(354, 58);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(55, 20);
            this.txtCpu.TabIndex = 9;
            this.txtCpu.TextChanged += new System.EventHandler(this.txtCpu_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(354, 99);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(55, 20);
            this.txtTiempo.TabIndex = 10;
            this.txtTiempo.TextChanged += new System.EventHandler(this.txtTiempo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(346, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "PRIORIDAD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboPrioridad.Location = new System.Drawing.Point(354, 142);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(55, 21);
            this.cboPrioridad.TabIndex = 14;
            this.cboPrioridad.SelectedIndexChanged += new System.EventHandler(this.cboPrioridad_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(13, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataProcesos
            // 
            this.dataProcesos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProcesos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataProcesos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataProcesos.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_proceso,
            this.Proceso_name,
            this.Tiempo_LL,
            this.CPU_column,
            this.Priori_colum,
            this.Estado_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProcesos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataProcesos.Location = new System.Drawing.Point(13, 243);
            this.dataProcesos.Name = "dataProcesos";
            this.dataProcesos.RowHeadersVisible = false;
            this.dataProcesos.Size = new System.Drawing.Size(460, 188);
            this.dataProcesos.TabIndex = 34;
            // 
            // Tipo_proceso
            // 
            this.Tipo_proceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo_proceso.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo_proceso.HeaderText = "Tipo de Proceso";
            this.Tipo_proceso.Name = "Tipo_proceso";
            this.Tipo_proceso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo_proceso.Width = 101;
            // 
            // Proceso_name
            // 
            this.Proceso_name.HeaderText = "Proceso";
            this.Proceso_name.Name = "Proceso_name";
            this.Proceso_name.Width = 71;
            // 
            // Tiempo_LL
            // 
            this.Tiempo_LL.HeaderText = "Tiempo de Llegada";
            this.Tiempo_LL.Name = "Tiempo_LL";
            this.Tiempo_LL.Width = 113;
            // 
            // CPU_column
            // 
            this.CPU_column.HeaderText = "CPU";
            this.CPU_column.Name = "CPU_column";
            this.CPU_column.Width = 54;
            // 
            // Priori_colum
            // 
            this.Priori_colum.HeaderText = "Prioridad";
            this.Priori_colum.Name = "Priori_colum";
            this.Priori_colum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Priori_colum.Width = 54;
            // 
            // Estado_column
            // 
            this.Estado_column.HeaderText = "Estado";
            this.Estado_column.Name = "Estado_column";
            this.Estado_column.Width = 65;
            // 
            // cbotipoconfig
            // 
            this.cbotipoconfig.FormattingEnabled = true;
            this.cbotipoconfig.Location = new System.Drawing.Point(144, 124);
            this.cbotipoconfig.Name = "cbotipoconfig";
            this.cbotipoconfig.Size = new System.Drawing.Size(135, 21);
            this.cbotipoconfig.TabIndex = 22;
            this.cbotipoconfig.Visible = false;
            this.cbotipoconfig.SelectedIndexChanged += new System.EventHandler(this.cbotipoconfig_SelectedIndexChanged);
            // 
            // lbldecision
            // 
            this.lbldecision.AutoSize = true;
            this.lbldecision.BackColor = System.Drawing.Color.Transparent;
            this.lbldecision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldecision.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldecision.ForeColor = System.Drawing.Color.Green;
            this.lbldecision.Location = new System.Drawing.Point(44, 126);
            this.lbldecision.Name = "lbldecision";
            this.lbldecision.Size = new System.Drawing.Size(95, 15);
            this.lbldecision.TabIndex = 21;
            this.lbldecision.Text = "CONFIGURAR";
            this.lbldecision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldecision.Visible = false;
            this.lbldecision.Click += new System.EventHandler(this.lbldecision_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(122, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 23;
            this.button3.Text = "LIMPIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(144, 150);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(55, 20);
            this.txtnumero.TabIndex = 31;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // TimerAlgoritmo
            // 
            this.TimerAlgoritmo.Interval = 1000;
            this.TimerAlgoritmo.Tick += new System.EventHandler(this.TimerAlgoritmo_Tick);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Tomato;
            this.button4.Location = new System.Drawing.Point(54, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 21);
            this.button4.TabIndex = 35;
            this.button4.Text = "QUANTUM";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(589, 154);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(56, 52);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 29;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(56, 52);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(311, 46);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(37, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(311, 87);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(311, 129);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(346, 210);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picAgregar
            // 
            this.picAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(88, 204);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(37, 32);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgregar.TabIndex = 15;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAgregar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Simulador_procesos.Properties.Resources.fabricacion_por_lotes_2;
            this.pictureBox3.Location = new System.Drawing.Point(470, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulador_procesos.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(15, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Simulador_procesos.Properties.Resources.imagen1;
            this.pictureBox2.Location = new System.Drawing.Point(88, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // visualizaralgoritmoboton
            // 
            this.visualizaralgoritmoboton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualizaralgoritmoboton.FlatAppearance.BorderSize = 0;
            this.visualizaralgoritmoboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizaralgoritmoboton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizaralgoritmoboton.ForeColor = System.Drawing.Color.Tomato;
            this.visualizaralgoritmoboton.Location = new System.Drawing.Point(491, 243);
            this.visualizaralgoritmoboton.Name = "visualizaralgoritmoboton";
            this.visualizaralgoritmoboton.Size = new System.Drawing.Size(165, 21);
            this.visualizaralgoritmoboton.TabIndex = 50;
            this.visualizaralgoritmoboton.Text = "VISUALIZAR ALGORITMO";
            this.visualizaralgoritmoboton.UseVisualStyleBackColor = true;
            this.visualizaralgoritmoboton.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(518, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 21);
            this.button2.TabIndex = 51;
            this.button2.Text = "EJECUTANDO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Tomato;
            this.button6.Location = new System.Drawing.Point(479, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 45);
            this.button6.TabIndex = 53;
            this.button6.Text = "TIEMPO REQUERIDO PARA PROCESOS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(539, 308);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(55, 20);
            this.txtsuma.TabIndex = 54;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.Green;
            this.lbltimer.Location = new System.Drawing.Point(560, 369);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(15, 15);
            this.lbltimer.TabIndex = 56;
            this.lbltimer.Text = "0";
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Tomato;
            this.button5.Location = new System.Drawing.Point(203, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 21);
            this.button5.TabIndex = 57;
            this.button5.Text = "MATAR PROCESO";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 257);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(654, 202);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 58;
            this.pictureBox5.TabStop = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Tomato;
            this.button7.Location = new System.Drawing.Point(425, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 21);
            this.button7.TabIndex = 59;
            this.button7.Text = "SIMULAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Tomato;
            this.button8.Location = new System.Drawing.Point(500, 216);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 21);
            this.button8.TabIndex = 60;
            this.button8.Text = "TERMINAR RESTANTES";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // P_Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 461);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.visualizaralgoritmoboton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.dataProcesos);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbotipoconfig);
            this.Controls.Add(this.lbldecision);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picAgregar);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtCpu);
            this.Controls.Add(this.cboconfig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblconfig);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_Lotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador_de_procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboconfig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbotipoconfig;
        private System.Windows.Forms.Label lbldecision;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Timer TimerAlgoritmo;
        private System.Windows.Forms.DataGridView dataProcesos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo_LL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priori_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_column;
        private System.Windows.Forms.Button visualizaralgoritmoboton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

