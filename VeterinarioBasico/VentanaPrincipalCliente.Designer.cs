﻿namespace VeterinarioBasico
{
    partial class VentanaPrincipalCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipalCliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.apellido2 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.apellido1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.razaMascota = new System.Windows.Forms.Label();
            this.tipoMascota = new System.Windows.Forms.Label();
            this.fecNacMascota = new System.Windows.Forms.Label();
            this.nombreMascota = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1388, 766);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.apellido2);
            this.tabPage1.Controls.Add(this.direccion);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.apellido1);
            this.tabPage1.Controls.Add(this.nombre);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1380, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mi perfil";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VeterinarioBasico.Properties.Resources.logovet;
            this.pictureBox3.Location = new System.Drawing.Point(868, 569);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(504, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(831, 364);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(386, 118);
            this.button9.TabIndex = 9;
            this.button9.Text = "SUSCRÍBETE A NUESTRA REVISTA MENSUAL";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(831, 218);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(386, 118);
            this.button8.TabIndex = 8;
            this.button8.Text = "FACTURAS";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(146)))), ((int)(((byte)(195)))));
            this.button7.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(831, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(386, 118);
            this.button7.TabIndex = 7;
            this.button7.Text = "MÉTODOS DE PAGO";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // apellido2
            // 
            this.apellido2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.apellido2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido2.Location = new System.Drawing.Point(291, 345);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(182, 36);
            this.apellido2.TabIndex = 5;
            this.apellido2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.direccion.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(93, 477);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(380, 36);
            this.direccion.TabIndex = 4;
            this.direccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.email.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(93, 407);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(380, 36);
            this.email.TabIndex = 3;
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apellido1
            // 
            this.apellido1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.apellido1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido1.Location = new System.Drawing.Point(93, 345);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(182, 36);
            this.apellido1.TabIndex = 2;
            this.apellido1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nombre.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(181, 288);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(202, 36);
            this.nombre.TabIndex = 1;
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(181, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.razaMascota);
            this.tabPage2.Controls.Add(this.tipoMascota);
            this.tabPage2.Controls.Add(this.fecNacMascota);
            this.tabPage2.Controls.Add(this.nombreMascota);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1380, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mi mascota";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VeterinarioBasico.Properties.Resources.logovet;
            this.pictureBox4.Location = new System.Drawing.Point(868, 571);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(504, 146);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(146)))), ((int)(((byte)(195)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.button5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1003, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 72);
            this.button5.TabIndex = 10;
            this.button5.Text = "AÑADIR MASCOTA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // razaMascota
            // 
            this.razaMascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.razaMascota.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razaMascota.Location = new System.Drawing.Point(592, 209);
            this.razaMascota.Name = "razaMascota";
            this.razaMascota.Size = new System.Drawing.Size(241, 47);
            this.razaMascota.TabIndex = 6;
            this.razaMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoMascota
            // 
            this.tipoMascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tipoMascota.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoMascota.Location = new System.Drawing.Point(345, 209);
            this.tipoMascota.Name = "tipoMascota";
            this.tipoMascota.Size = new System.Drawing.Size(241, 47);
            this.tipoMascota.TabIndex = 5;
            this.tipoMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fecNacMascota
            // 
            this.fecNacMascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fecNacMascota.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecNacMascota.Location = new System.Drawing.Point(592, 147);
            this.fecNacMascota.Name = "fecNacMascota";
            this.fecNacMascota.Size = new System.Drawing.Size(241, 47);
            this.fecNacMascota.TabIndex = 4;
            this.fecNacMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreMascota
            // 
            this.nombreMascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nombreMascota.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMascota.Location = new System.Drawing.Point(345, 147);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(241, 47);
            this.nombreMascota.TabIndex = 3;
            this.nombreMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(117, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1380, 723);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mis citas";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(355, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Para gestionar una cita ya existente, o para concertar una nueva cita, por favor," +
    " póngase en contacto con nosotros llamando al 910 884 881. Gracias.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VeterinarioBasico.Properties.Resources.logovet;
            this.pictureBox5.Location = new System.Drawing.Point(868, 569);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(504, 146);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(533, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "PRÓXIMAS CITAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_calendar.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_customer_1.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_dog.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_dog_paw.ico");
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 170);
            this.dataGridView1.TabIndex = 14;
            // 
            // VentanaPrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1388, 766);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaPrincipalCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PK Vet";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label apellido1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label apellido2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label razaMascota;
        private System.Windows.Forms.Label tipoMascota;
        private System.Windows.Forms.Label fecNacMascota;
        private System.Windows.Forms.Label nombreMascota;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

