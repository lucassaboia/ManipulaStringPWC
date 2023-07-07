namespace ManipulaStringPWC.Formulários
{
    partial class frmMaiuscula
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
            btnMaiusculo = new PortaldoPreco2.Resources.CustomButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtMaiuscula = new PortaldoPreco2.Customtxt();
            lblMaiusculo = new Label();
            lblTitulo = new Label();
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
            btnLixeira.TabIndex = 11;
            btnLixeira.TextColor = Color.White;
            btnLixeira.UseVisualStyleBackColor = false;
            btnLixeira.Click += btnLixeira_Click;
            // 
            // btnMaiusculo
            // 
            btnMaiusculo.BackColor = Color.CornflowerBlue;
            btnMaiusculo.BackgroundColor = Color.CornflowerBlue;
            btnMaiusculo.BackgroundImage = Properties.Resources.ENVIAR;
            btnMaiusculo.BackgroundImageLayout = ImageLayout.Center;
            btnMaiusculo.BorderColor = Color.PaleVioletRed;
            btnMaiusculo.BorderRadius = 5;
            btnMaiusculo.BorderSize = 0;
            btnMaiusculo.FlatAppearance.BorderSize = 0;
            btnMaiusculo.FlatStyle = FlatStyle.Flat;
            btnMaiusculo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaiusculo.ForeColor = Color.White;
            btnMaiusculo.Location = new Point(44, 294);
            btnMaiusculo.Name = "btnMaiusculo";
            btnMaiusculo.Size = new Size(572, 48);
            btnMaiusculo.TabIndex = 10;
            btnMaiusculo.TextColor = Color.White;
            btnMaiusculo.UseVisualStyleBackColor = false;
            btnMaiusculo.Click += btnMaiusculo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.tituloMaiúscula;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(44, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(628, 53);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.funcionalidadesMaiúscula;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(798, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 318);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtMaiuscula
            // 
            txtMaiuscula.BackColor = SystemColors.Window;
            txtMaiuscula.BorderColor = Color.DarkGray;
            txtMaiuscula.BorderFocusColor = SystemColors.Highlight;
            txtMaiuscula.BorderRadius = 8;
            txtMaiuscula.BorderSize = 2;
            txtMaiuscula.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaiuscula.ForeColor = Color.DimGray;
            txtMaiuscula.Location = new Point(44, 85);
            txtMaiuscula.Margin = new Padding(4);
            txtMaiuscula.Multiline = true;
            txtMaiuscula.Name = "txtMaiuscula";
            txtMaiuscula.Padding = new Padding(7);
            txtMaiuscula.PasswordChar = true;
            txtMaiuscula.PlaceholderColor = Color.DarkGray;
            txtMaiuscula.PlaceholderText = "Insira o texto que deseja alterar aqui";
            txtMaiuscula.Size = new Size(572, 202);
            txtMaiuscula.TabIndex = 12;
            txtMaiuscula.Texts = "";
            txtMaiuscula.UnderlinedStyle = false;
            // 
            // lblMaiusculo
            // 
            lblMaiusculo.Location = new Point(622, 133);
            lblMaiusculo.Name = "lblMaiusculo";
            lblMaiusculo.Size = new Size(170, 154);
            lblMaiusculo.TabIndex = 21;
            lblMaiusculo.Text = "Ordem das Palavras";
            lblMaiusculo.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(623, 85);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 48);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Esta é a sua frase:";
            // 
            // frmMaiuscula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 369);
            Controls.Add(lblTitulo);
            Controls.Add(lblMaiusculo);
            Controls.Add(txtMaiuscula);
            Controls.Add(btnLixeira);
            Controls.Add(btnMaiusculo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMaiuscula";
            Text = "frmMaiuscula";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PortaldoPreco2.Resources.CustomButton btnLixeira;
        private PortaldoPreco2.Resources.CustomButton btnMaiusculo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PortaldoPreco2.Customtxt txtMaiuscula;
        private Label lblMaiusculo;
        private Label lblTitulo;
    }
}