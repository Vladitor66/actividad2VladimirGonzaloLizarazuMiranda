namespace sistemasventas.VISTA.ProyectoFinal
{
    partial class IniciarSesionVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionVista));
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(281, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 41);
            textBox1.TabIndex = 0;
            textBox1.Text = "Iniciar Sesion";
            // 
            // button1
            // 
            button1.Location = new Point(311, 357);
            button1.Name = "button1";
            button1.Size = new Size(157, 37);
            button1.TabIndex = 1;
            button1.Text = "ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 288);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 27);
            textBox3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(311, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(82, 27);
            textBox4.TabIndex = 5;
            textBox4.Text = "USUARIO";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 288);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(108, 27);
            textBox5.TabIndex = 6;
            textBox5.Text = "CONTRASEÑA";
            // 
            // IniciarSesionVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "IniciarSesionVista";
            Text = "IniciarSesionVista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}