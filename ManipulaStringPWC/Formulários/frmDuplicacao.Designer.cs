namespace ManipulaStringPWC.Formulários
{
    partial class frmDuplicacao
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
            btnDuplicacao = new PortaldoPreco2.Resources.CustomButton();
            pictureBox2 = new PictureBox();
            txtDuplicado = new PortaldoPreco2.Customtxt();
            pictureBox1 = new PictureBox();
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
            // btnDuplicacao
            // 
            btnDuplicacao.BackColor = Color.CornflowerBlue;
            btnDuplicacao.BackgroundColor = Color.CornflowerBlue;
            btnDuplicacao.BackgroundImage = Properties.Resources.ENVIAR;
            btnDuplicacao.BackgroundImageLayout = ImageLayout.Center;
            btnDuplicacao.BorderColor = Color.PaleVioletRed;
            btnDuplicacao.BorderRadius = 5;
            btnDuplicacao.BorderSize = 0;
            btnDuplicacao.FlatAppearance.BorderSize = 0;
            btnDuplicacao.FlatStyle = FlatStyle.Flat;
            btnDuplicacao.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnDuplicacao.ForeColor = Color.White;
            btnDuplicacao.Location = new Point(44, 294);
            btnDuplicacao.Name = "btnDuplicacao";
            btnDuplicacao.Size = new Size(572, 48);
            btnDuplicacao.TabIndex = 10;
            btnDuplicacao.TextColor = Color.White;
            btnDuplicacao.UseVisualStyleBackColor = false;
            btnDuplicacao.Click += btnDuplicacao_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.tituloDuplicacao;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(44, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(573, 53);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // txtDuplicado
            // 
            txtDuplicado.BackColor = SystemColors.Window;
            txtDuplicado.BorderColor = Color.DarkGray;
            txtDuplicado.BorderFocusColor = SystemColors.Highlight;
            txtDuplicado.BorderRadius = 8;
            txtDuplicado.BorderSize = 2;
            txtDuplicado.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuplicado.ForeColor = Color.DimGray;
            txtDuplicado.Location = new Point(45, 85);
            txtDuplicado.Margin = new Padding(4);
            txtDuplicado.Multiline = true;
            txtDuplicado.Name = "txtDuplicado";
            txtDuplicado.Padding = new Padding(7);
            txtDuplicado.PasswordChar = true;
            txtDuplicado.PlaceholderColor = Color.DarkGray;
            txtDuplicado.PlaceholderText = "Insira o texto que deseja alterar aqui";
            txtDuplicado.Size = new Size(572, 202);
            txtDuplicado.TabIndex = 25;
            txtDuplicado.Texts = "";
            txtDuplicado.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.funcionalidadesDuplicacao;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(798, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 318);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // frmDuplicacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 369);
            Controls.Add(pictureBox1);
            Controls.Add(txtDuplicado);
            Controls.Add(btnLixeira);
            Controls.Add(btnDuplicacao);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDuplicacao";
            Text = "frmDuplicacao";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PortaldoPreco2.Resources.CustomButton btnLixeira;
        private PortaldoPreco2.Resources.CustomButton btnDuplicacao;
        private PictureBox pictureBox2;
        private PortaldoPreco2.Customtxt txtDuplicado;
        private PictureBox pictureBox1;
    }
}