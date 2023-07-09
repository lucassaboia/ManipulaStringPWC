namespace ManipulaStringPWC.Formulários
{
    partial class frmAnagrama
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
            btnLixeira = new PortaldoPreco2.Resources.CustomButton();
            btnPalindromo = new PortaldoPreco2.Resources.CustomButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtPalindromo = new PortaldoPreco2.Customtxt();
            lblTitulo = new Label();
            lblPalindromo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLixeira
            // 
            btnLixeira.BackColor = Color.WhiteSmoke;
            btnLixeira.BackgroundColor = Color.WhiteSmoke;
            btnLixeira.BackgroundImage = Properties.Resources.Lixo;
            btnLixeira.BackgroundImageLayout = ImageLayout.Center;
            btnLixeira.BorderColor = Color.Black;
            btnLixeira.BorderRadius = 8;
            btnLixeira.BorderSize = 1;
            btnLixeira.FlatAppearance.BorderSize = 0;
            btnLixeira.FlatStyle = FlatStyle.Flat;
            btnLixeira.ForeColor = Color.White;
            btnLixeira.Location = new Point(622, 294);
            btnLixeira.Name = "btnLixeira";
            btnLixeira.Size = new Size(50, 50);
            btnLixeira.TabIndex = 16;
            btnLixeira.TextColor = Color.White;
            btnLixeira.UseVisualStyleBackColor = false;
            btnLixeira.Click += BtnLixeira_Click;
            // 
            // btnPalindromo
            // 
            btnPalindromo.BackColor = Color.CornflowerBlue;
            btnPalindromo.BackgroundColor = Color.CornflowerBlue;
            btnPalindromo.BackgroundImage = Properties.Resources.ENVIAR;
            btnPalindromo.BackgroundImageLayout = ImageLayout.Center;
            btnPalindromo.BorderColor = Color.PaleVioletRed;
            btnPalindromo.BorderRadius = 5;
            btnPalindromo.BorderSize = 0;
            btnPalindromo.FlatAppearance.BorderSize = 0;
            btnPalindromo.FlatStyle = FlatStyle.Flat;
            btnPalindromo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnPalindromo.ForeColor = Color.White;
            btnPalindromo.Location = new Point(44, 294);
            btnPalindromo.Name = "btnPalindromo";
            btnPalindromo.Size = new Size(572, 48);
            btnPalindromo.TabIndex = 15;
            btnPalindromo.TextColor = Color.White;
            btnPalindromo.UseVisualStyleBackColor = false;
            btnPalindromo.Click += BtnPalindromo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.tituloAnagrama;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(44, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(573, 53);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.funcionalidadesPalindroma;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(798, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 318);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtPalindromo
            // 
            txtPalindromo.BackColor = SystemColors.Window;
            txtPalindromo.BorderColor = Color.DarkGray;
            txtPalindromo.BorderFocusColor = SystemColors.Highlight;
            txtPalindromo.BorderRadius = 8;
            txtPalindromo.BorderSize = 2;
            txtPalindromo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPalindromo.ForeColor = Color.DimGray;
            txtPalindromo.Location = new Point(45, 85);
            txtPalindromo.Margin = new Padding(4);
            txtPalindromo.Multiline = true;
            txtPalindromo.Name = "txtPalindromo";
            txtPalindromo.Padding = new Padding(7);
            txtPalindromo.PasswordChar = true;
            txtPalindromo.PlaceholderColor = Color.DarkGray;
            txtPalindromo.PlaceholderText = "Insira o texto que deseja alterar aqui";
            txtPalindromo.Size = new Size(572, 202);
            txtPalindromo.TabIndex = 17;
            txtPalindromo.Texts = "";
            txtPalindromo.UnderlinedStyle = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(622, 85);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 48);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "É um palíndromo?";
            // 
            // lblPalindromo
            // 
            lblPalindromo.Location = new Point(624, 133);
            lblPalindromo.Name = "lblPalindromo";
            lblPalindromo.Size = new Size(170, 154);
            lblPalindromo.TabIndex = 23;
            lblPalindromo.Text = "Ordem das Palavras";
            lblPalindromo.Visible = false;
            // 
            // frmAnagrama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 369);
            Controls.Add(lblTitulo);
            Controls.Add(lblPalindromo);
            Controls.Add(txtPalindromo);
            Controls.Add(btnLixeira);
            Controls.Add(btnPalindromo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAnagrama";
            Text = "frmAnagrama";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PortaldoPreco2.Customtxt txtPalindromo;
        private PortaldoPreco2.Resources.CustomButton btnLixeira;
        private PortaldoPreco2.Resources.CustomButton btnPalindromo;
        private Label lblPalindromo;
        private Label lblTitulo;
    }
}