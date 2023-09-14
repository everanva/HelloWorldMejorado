namespace HelloWorldMejorado
{
    partial class FormaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textUsuario = new TextBox();
            testPassword = new TextBox();
            buttonIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(33, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textUsuario
            // 
            textUsuario.Font = new Font("Bahnschrift Condensed", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            textUsuario.ForeColor = Color.Maroon;
            textUsuario.Location = new Point(162, 37);
            textUsuario.Multiline = true;
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(340, 50);
            textUsuario.TabIndex = 2;
            // 
            // testPassword
            // 
            testPassword.Font = new Font("Bahnschrift Condensed", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            testPassword.ForeColor = Color.Maroon;
            testPassword.Location = new Point(162, 121);
            testPassword.Multiline = true;
            testPassword.Name = "testPassword";
            testPassword.PasswordChar = '*';
            testPassword.Size = new Size(340, 50);
            testPassword.TabIndex = 3;
            testPassword.TextChanged += textBox2_TextChanged;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackgroundImage = (Image)resources.GetObject("buttonIngresar.BackgroundImage");
            buttonIngresar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonIngresar.Location = new Point(395, 189);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(107, 47);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // FormaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(549, 263);
            Controls.Add(buttonIngresar);
            Controls.Add(testPassword);
            Controls.Add(textUsuario);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormaLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar al sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textUsuario;
        private TextBox testPassword;
        private Button buttonIngresar;
    }
}