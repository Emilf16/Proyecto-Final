﻿namespace Proyecto_Final
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbx_Usuario = new System.Windows.Forms.TextBox();
            this.tbx_Contraseña = new System.Windows.Forms.TextBox();
            this.Btn_Acceder = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 35);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 108);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alquiler \r\nde\r\n Salones";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final.Properties.Resources.Intec_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(33, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tbx_Usuario
            // 
            this.tbx_Usuario.BackColor = System.Drawing.Color.White;
            this.tbx_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Usuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Usuario.ForeColor = System.Drawing.Color.Black;
            this.tbx_Usuario.Location = new System.Drawing.Point(324, 92);
            this.tbx_Usuario.Name = "tbx_Usuario";
            this.tbx_Usuario.Size = new System.Drawing.Size(377, 20);
            this.tbx_Usuario.TabIndex = 1;
            this.tbx_Usuario.Text = "Usuario";
            this.tbx_Usuario.Enter += new System.EventHandler(this.tbx_Usuario_Enter);
            this.tbx_Usuario.Leave += new System.EventHandler(this.tbx_Usuario_Leave);
            // 
            // tbx_Contraseña
            // 
            this.tbx_Contraseña.BackColor = System.Drawing.Color.White;
            this.tbx_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Contraseña.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Contraseña.ForeColor = System.Drawing.Color.Black;
            this.tbx_Contraseña.Location = new System.Drawing.Point(324, 164);
            this.tbx_Contraseña.Name = "tbx_Contraseña";
            this.tbx_Contraseña.Size = new System.Drawing.Size(377, 20);
            this.tbx_Contraseña.TabIndex = 2;
            this.tbx_Contraseña.Text = "Contraseña";
            this.tbx_Contraseña.Enter += new System.EventHandler(this.tbx_Contraseña_Enter);
            this.tbx_Contraseña.Leave += new System.EventHandler(this.tbx_Contraseña_Leave);
            // 
            // Btn_Acceder
            // 
            this.Btn_Acceder.BackColor = System.Drawing.Color.Green;
            this.Btn_Acceder.FlatAppearance.BorderSize = 0;
            this.Btn_Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Acceder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Btn_Acceder.Location = new System.Drawing.Point(324, 238);
            this.Btn_Acceder.Name = "Btn_Acceder";
            this.Btn_Acceder.Size = new System.Drawing.Size(387, 33);
            this.Btn_Acceder.TabIndex = 4;
            this.Btn_Acceder.Text = "Acceder";
            this.Btn_Acceder.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Green;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(421, 287);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ha olvidado la contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Image = global::Proyecto_Final.Properties.Resources.Boton_Cerrar;
            this.Btn_Cerrar.Location = new System.Drawing.Point(745, 12);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(23, 23);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Image = global::Proyecto_Final.Properties.Resources.Boton_Minimizar;
            this.Btn_Minimizar.Location = new System.Drawing.Point(706, 12);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(23, 23);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Minimizar.TabIndex = 7;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(324, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "__________________________________________________________________________";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(324, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "__________________________________________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.LogIn_Empresa;
            this.pictureBox1.Location = new System.Drawing.Point(421, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Green;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(444, 304);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(121, 17);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Registrarme Ahora";
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Minimizar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Btn_Acceder);
            this.Controls.Add(this.tbx_Contraseña);
            this.Controls.Add(this.tbx_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox tbx_Usuario;
        private TextBox tbx_Contraseña;
        private Button Btn_Acceder;
        private LinkLabel linkLabel1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox Btn_Cerrar;
        private PictureBox Btn_Minimizar;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel2;
    }
}