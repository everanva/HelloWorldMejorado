namespace HelloWorldMejorado.formas
{
    partial class FormaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaRegistro));
            label1 = new Label();
            labelNombre = new Label();
            labelApellidos = new Label();
            labelUsuario = new Label();
            labelContrasena = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            buttonRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(278, 40);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuarios";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(34, 101);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.Location = new Point(34, 154);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(56, 15);
            labelApellidos.TabIndex = 2;
            labelApellidos.Text = "Apellidos";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(34, 206);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(47, 15);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Location = new Point(34, 262);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(67, 15);
            labelContrasena.TabIndex = 4;
            labelContrasena.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleGreen;
            textBox1.Location = new Point(121, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PaleGreen;
            textBox2.Location = new Point(121, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.PaleGreen;
            textBox3.Location = new Point(121, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.PaleGreen;
            textBox4.Location = new Point(121, 259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 23);
            textBox4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(473, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 109);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Location = new Point(488, 283);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(75, 23);
            buttonRegistrar.TabIndex = 10;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            // 
            // FormaRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 356);
            Controls.Add(buttonRegistrar);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelContrasena);
            Controls.Add(labelUsuario);
            Controls.Add(labelApellidos);
            Controls.Add(labelNombre);
            Controls.Add(label1);
            Name = "FormaRegistro";
            Text = "FormaRegistro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNombre;
        private Label labelApellidos;
        private Label labelUsuario;
        private Label labelContrasena;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button buttonRegistrar;
    }
}