namespace ManipulaStringPWC.Formulários
{
    partial class frmPalindroma
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
            btnPalindromaLonga = new PortaldoPreco2.Resources.CustomButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblPalindromaLonga = new Label();
            txtPalindromaLonga = new PortaldoPreco2.Customtxt();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btnLixeira.Click += btnLixeira_Click;
            // 
            // btnPalindromaLonga
            // 
            btnPalindromaLonga.BackColor = Color.CornflowerBlue;
            btnPalindromaLonga.BackgroundColor = Color.CornflowerBlue;
            btnPalindromaLonga.BackgroundImage = Properties.Resources.ENVIAR;
            btnPalindromaLonga.BackgroundImageLayout = ImageLayout.Center;
            btnPalindromaLonga.BorderColor = Color.PaleVioletRed;
            btnPalindromaLonga.BorderRadius = 5;
            btnPalindromaLonga.BorderSize = 0;
            btnPalindromaLonga.FlatAppearance.BorderSize = 0;
            btnPalindromaLonga.FlatStyle = FlatStyle.Flat;
            btnPalindromaLonga.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnPalindromaLonga.ForeColor = Color.White;
            btnPalindromaLonga.Location = new Point(44, 294);
            btnPalindromaLonga.Name = "btnPalindromaLonga";
            btnPalindromaLonga.Size = new Size(572, 48);
            btnPalindromaLonga.TabIndex = 15;
            btnPalindromaLonga.TextColor = Color.White;
            btnPalindromaLonga.UseVisualStyleBackColor = false;
            btnPalindromaLonga.Click += btnPalindromaLonga_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.tituloPalindro;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(44, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(573, 53);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.palíndroma;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(331, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 29);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.funcionalidadesAnagrama;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(798, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 318);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(616, 85);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 48);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "Esta é a sua palíndroma:";
            // 
            // lblPalindromaLonga
            // 
            lblPalindromaLonga.Location = new Point(622, 133);
            lblPalindromaLonga.Name = "lblPalindromaLonga";
            lblPalindromaLonga.Size = new Size(170, 154);
            lblPalindromaLonga.TabIndex = 24;
            lblPalindromaLonga.Visible = false;
            // 
            // txtPalindromaLonga
            // 
            txtPalindromaLonga.BackColor = SystemColors.Window;
            txtPalindromaLonga.BorderColor = Color.DarkGray;
            txtPalindromaLonga.BorderFocusColor = SystemColors.Highlight;
            txtPalindromaLonga.BorderRadius = 8;
            txtPalindromaLonga.BorderSize = 2;
            txtPalindromaLonga.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPalindromaLonga.ForeColor = Color.DimGray;
            txtPalindromaLonga.Location = new Point(44, 85);
            txtPalindromaLonga.Margin = new Padding(4);
            txtPalindromaLonga.Multiline = true;
            txtPalindromaLonga.Name = "txtPalindromaLonga";
            txtPalindromaLonga.Padding = new Padding(7);
            txtPalindromaLonga.PasswordChar = true;
            txtPalindromaLonga.PlaceholderColor = Color.DarkGray;
            txtPalindromaLonga.PlaceholderText = "Insira o texto que deseja alterar aqui";
            txtPalindromaLonga.Size = new Size(572, 202);
            txtPalindromaLonga.TabIndex = 23;
            txtPalindromaLonga.Texts = "";
            txtPalindromaLonga.UnderlinedStyle = false;
            // 
            // frmPalindroma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 369);
            Controls.Add(lblTitulo);
            Controls.Add(lblPalindromaLonga);
            Controls.Add(txtPalindromaLonga);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(btnLixeira);
            Controls.Add(btnPalindromaLonga);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPalindroma";
            Text = "frmPalindroma";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PortaldoPreco2.Resources.CustomButton btnLixeira;
        private PortaldoPreco2.Resources.CustomButton btnPalindromaLonga;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblPalindromaLonga;
        private PortaldoPreco2.Customtxt txtPalindromaLonga;
    }
}