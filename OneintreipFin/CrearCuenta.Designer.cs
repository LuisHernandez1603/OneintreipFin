namespace OneintreipFin
{
    partial class CrearCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtlastname = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedb = new System.Windows.Forms.Button();
            this.txtcel = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtsexo = new System.Windows.Forms.ComboBox();
            this.txtselectU = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(289, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 218);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.White;
            this.txtlastname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtlastname.ForeColor = System.Drawing.Color.Black;
            this.txtlastname.Location = new System.Drawing.Point(104, 155);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.PasswordChar = '*';
            this.txtlastname.Size = new System.Drawing.Size(225, 32);
            this.txtlastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(161, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "¡Ingrese sus datos porfavor!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su nombre";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(104, 92);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 32);
            this.txtname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(754, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese Su N°cedula";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.White;
            this.txtnum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtnum.ForeColor = System.Drawing.Color.Black;
            this.txtnum.Location = new System.Drawing.Point(58, 321);
            this.txtnum.Mask = "+000-0000-0000";
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(226, 32);
            this.txtnum.TabIndex = 5;
            this.txtnum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.numerotel_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese su N°de telefono";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(832, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Siguiente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedb
            // 
            this.maskedb.BackColor = System.Drawing.Color.Transparent;
            this.maskedb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedb.ForeColor = System.Drawing.Color.Black;
            this.maskedb.Location = new System.Drawing.Point(12, 456);
            this.maskedb.Name = "maskedb";
            this.maskedb.Size = new System.Drawing.Size(138, 35);
            this.maskedb.TabIndex = 9;
            this.maskedb.Text = "Cancelar";
            this.maskedb.UseVisualStyleBackColor = false;
            this.maskedb.Click += new System.EventHandler(this.maskedb_Click);
            // 
            // txtcel
            // 
            this.txtcel.BackColor = System.Drawing.Color.White;
            this.txtcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcel.ForeColor = System.Drawing.Color.Black;
            this.txtcel.Location = new System.Drawing.Point(722, 320);
            this.txtcel.Mask = "000-000000-0000L";
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(225, 32);
            this.txtcel.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtsexo
            // 
            this.txtsexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsexo.FormattingEnabled = true;
            this.txtsexo.Items.AddRange(new object[] {
            "Seleccione su sexo",
            "Masculino",
            "Femenino"});
            this.txtsexo.Location = new System.Drawing.Point(383, 427);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(245, 32);
            this.txtsexo.TabIndex = 10;
            this.txtsexo.Text = "Seleccione su sexo";
            // 
            // txtselectU
            // 
            this.txtselectU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtselectU.FormattingEnabled = true;
            this.txtselectU.Items.AddRange(new object[] {
            "Seleccione su usuario",
            "Universitario",
            "Cuidadano"});
            this.txtselectU.Location = new System.Drawing.Point(383, 320);
            this.txtselectU.Name = "txtselectU";
            this.txtselectU.Size = new System.Drawing.Size(245, 32);
            this.txtselectU.TabIndex = 32;
            this.txtselectU.Text = "Seleccione su usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OneintreipFin.Properties.Resources.logo_inteWL18_2;
            this.pictureBox1.Location = new System.Drawing.Point(815, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.txtselectU);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.maskedb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One In Trip";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button maskedb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtlastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtcel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox txtsexo;
        private System.Windows.Forms.ComboBox txtselectU;
    }
}