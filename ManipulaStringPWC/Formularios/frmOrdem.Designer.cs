namespace ManipulaStringPWC.Formularios
{
    partial class frmOrdem
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
            btnOrdem = new PortaldoPreco2.Resources.CustomButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtOrdem = new PortaldoPreco2.Customtxt();
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
            btnLixeira.Click += BtnLixeira_Click;
            // 
            // btnOrdem
            // 
            btnOrdem.BackColor = Color.CornflowerBlue;
            btnOrdem.BackgroundColor = Color.CornflowerBlue;
            btnOrdem.BackgroundImage = Properties.Resources.ENVIAR;
            btnOrdem.BackgroundImageLayout = ImageLayout.Center;
            btnOrdem.BorderColor = Color.PaleVioletRed;
            btnOrdem.BorderRadius = 5;
            btnOrdem.BorderSize = 0;
            btnOrdem.FlatAppearance.BorderSize = 0;
            btnOrdem.FlatStyle = FlatStyle.Flat;
            btnOrdem.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrdem.ForeColor = Color.White;
            btnOrdem.Location = new Point(44, 294);
            btnOrdem.Name = "btnOrdem";
            btnOrdem.Size = new Size(572, 48);
            btnOrdem.TabIndex = 10;
            btnOrdem.TextColor = Color.White;
            btnOrdem.UseVisualStyleBackColor = false;
            btnOrdem.Click += BtnOrdem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.tituloOrdem;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(44, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(573, 53);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.funcionalidadesOrdem;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(798, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 318);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtOrdem
            // 
            txtOrdem.BackColor = SystemColors.Window;
            txtOrdem.BorderColor = Color.DarkGray;
            txtOrdem.BorderFocusColor = SystemColors.Highlight;
            txtOrdem.BorderRadius = 8;
            txtOrdem.BorderSize = 2;
            txtOrdem.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrdem.ForeColor = Color.DimGray;
            txtOrdem.Location = new Point(44, 85);
            txtOrdem.Margin = new Padding(4);
            txtOrdem.Multiline = true;
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Padding = new Padding(7);
            txtOrdem.PasswordChar = true;
            txtOrdem.PlaceholderColor = Color.DarkGray;
            txtOrdem.PlaceholderText = "Insira o texto que deseja alterar aqui";
            txtOrdem.Size = new Size(572, 202);
            txtOrdem.TabIndex = 28;
            txtOrdem.Texts = "";
            txtOrdem.UnderlinedStyle = false;
            // 
            // frmOrdem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 369);
            Controls.Add(txtOrdem);
            Controls.Add(btnLixeira);
            Controls.Add(btnOrdem);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrdem";
            Text = "frmOrdem";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PortaldoPreco2.Resources.CustomButton btnLixeira;
        private PortaldoPreco2.Resources.CustomButton btnOrdem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PortaldoPreco2.Customtxt txtOrdem;
    }
}