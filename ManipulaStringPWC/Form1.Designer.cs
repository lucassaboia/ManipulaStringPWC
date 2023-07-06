namespace ManipulaStringPWC
{
    partial class Form1
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
            txtOrdem = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDuplicado = new TextBox();
            label4 = new Label();
            txtPalindromaLonga = new TextBox();
            label5 = new Label();
            txtMaiuscula = new TextBox();
            label6 = new Label();
            txtPalindromo = new TextBox();
            btnOrdem = new Button();
            btnDuplicacao = new Button();
            btnPalindromaLonga = new Button();
            btnMaiusculo = new Button();
            btnPalindromo = new Button();
            lblOrdem = new Label();
            lblDuplicacao = new Label();
            lblPalindromaLonga = new Label();
            lblMaiusculo = new Label();
            lblPalindromo = new Label();
            SuspendLayout();
            // 
            // txtOrdem
            // 
            txtOrdem.Location = new Point(65, 118);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(100, 23);
            txtOrdem.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 83);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "Ordem das Palavras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 83);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 83);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 5;
            label2.Text = "Remove Duplicação";
            // 
            // txtDuplicado
            // 
            txtDuplicado.Location = new Point(261, 118);
            txtDuplicado.Name = "txtDuplicado";
            txtDuplicado.Size = new Size(100, 23);
            txtDuplicado.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 83);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Palíndroma Longa";
            // 
            // txtPalindromaLonga
            // 
            txtPalindromaLonga.Location = new Point(455, 118);
            txtPalindromaLonga.Name = "txtPalindromaLonga";
            txtPalindromaLonga.Size = new Size(100, 23);
            txtPalindromaLonga.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 83);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 9;
            label5.Text = "Primeira letra Maiúscula";
            // 
            // txtMaiuscula
            // 
            txtMaiuscula.Location = new Point(630, 118);
            txtMaiuscula.Name = "txtMaiuscula";
            txtMaiuscula.Size = new Size(100, 23);
            txtMaiuscula.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(809, 83);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 11;
            label6.Text = "Verifica se é Palíndromo";
            // 
            // txtPalindromo
            // 
            txtPalindromo.Location = new Point(832, 118);
            txtPalindromo.Name = "txtPalindromo";
            txtPalindromo.Size = new Size(100, 23);
            txtPalindromo.TabIndex = 10;
            // 
            // btnOrdem
            // 
            btnOrdem.Location = new Point(63, 166);
            btnOrdem.Name = "btnOrdem";
            btnOrdem.Size = new Size(104, 52);
            btnOrdem.TabIndex = 12;
            btnOrdem.Text = "button1";
            btnOrdem.UseVisualStyleBackColor = true;
            btnOrdem.Click += btnOrdem_Click;
            // 
            // btnDuplicacao
            // 
            btnDuplicacao.Location = new Point(257, 166);
            btnDuplicacao.Name = "btnDuplicacao";
            btnDuplicacao.Size = new Size(104, 52);
            btnDuplicacao.TabIndex = 13;
            btnDuplicacao.Text = "button2";
            btnDuplicacao.UseVisualStyleBackColor = true;
            btnDuplicacao.Click += btnDuplicacao_Click;
            // 
            // btnPalindromaLonga
            // 
            btnPalindromaLonga.Location = new Point(451, 166);
            btnPalindromaLonga.Name = "btnPalindromaLonga";
            btnPalindromaLonga.Size = new Size(104, 52);
            btnPalindromaLonga.TabIndex = 14;
            btnPalindromaLonga.Text = "button3";
            btnPalindromaLonga.UseVisualStyleBackColor = true;
            btnPalindromaLonga.Click += btnPalindromaLonga_Click;
            // 
            // btnMaiusculo
            // 
            btnMaiusculo.Location = new Point(626, 166);
            btnMaiusculo.Name = "btnMaiusculo";
            btnMaiusculo.Size = new Size(104, 52);
            btnMaiusculo.TabIndex = 15;
            btnMaiusculo.Text = "button4";
            btnMaiusculo.UseVisualStyleBackColor = true;
            btnMaiusculo.Click += btnMaiusculo_Click;
            // 
            // btnPalindromo
            // 
            btnPalindromo.Location = new Point(832, 166);
            btnPalindromo.Name = "btnPalindromo";
            btnPalindromo.Size = new Size(104, 52);
            btnPalindromo.TabIndex = 16;
            btnPalindromo.Text = "button5";
            btnPalindromo.UseVisualStyleBackColor = true;
            btnPalindromo.Click += btnPalindromo_Click;
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(54, 255);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(111, 15);
            lblOrdem.TabIndex = 17;
            lblOrdem.Text = "Ordem das Palavras";
            lblOrdem.Visible = false;
            // 
            // lblDuplicacao
            // 
            lblDuplicacao.AutoSize = true;
            lblDuplicacao.Location = new Point(250, 255);
            lblDuplicacao.Name = "lblDuplicacao";
            lblDuplicacao.Size = new Size(111, 15);
            lblDuplicacao.TabIndex = 18;
            lblDuplicacao.Text = "Ordem das Palavras";
            lblDuplicacao.Visible = false;
            // 
            // lblPalindromaLonga
            // 
            lblPalindromaLonga.AutoSize = true;
            lblPalindromaLonga.Location = new Point(451, 255);
            lblPalindromaLonga.Name = "lblPalindromaLonga";
            lblPalindromaLonga.Size = new Size(111, 15);
            lblPalindromaLonga.TabIndex = 19;
            lblPalindromaLonga.Text = "Ordem das Palavras";
            lblPalindromaLonga.Visible = false;
            // 
            // lblMaiusculo
            // 
            lblMaiusculo.AutoSize = true;
            lblMaiusculo.Location = new Point(619, 255);
            lblMaiusculo.Name = "lblMaiusculo";
            lblMaiusculo.Size = new Size(111, 15);
            lblMaiusculo.TabIndex = 20;
            lblMaiusculo.Text = "Ordem das Palavras";
            lblMaiusculo.Visible = false;
            // 
            // lblPalindromo
            // 
            lblPalindromo.AutoSize = true;
            lblPalindromo.Location = new Point(831, 255);
            lblPalindromo.Name = "lblPalindromo";
            lblPalindromo.Size = new Size(111, 15);
            lblPalindromo.TabIndex = 21;
            lblPalindromo.Text = "Ordem das Palavras";
            lblPalindromo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(lblPalindromo);
            Controls.Add(lblMaiusculo);
            Controls.Add(lblPalindromaLonga);
            Controls.Add(lblDuplicacao);
            Controls.Add(lblOrdem);
            Controls.Add(btnPalindromo);
            Controls.Add(btnMaiusculo);
            Controls.Add(btnPalindromaLonga);
            Controls.Add(btnDuplicacao);
            Controls.Add(btnOrdem);
            Controls.Add(label6);
            Controls.Add(txtPalindromo);
            Controls.Add(label5);
            Controls.Add(txtMaiuscula);
            Controls.Add(label4);
            Controls.Add(txtPalindromaLonga);
            Controls.Add(label2);
            Controls.Add(txtDuplicado);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtOrdem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrdem;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtDuplicado;
        private Label label4;
        private TextBox txtPalindromaLonga;
        private Label label5;
        private TextBox txtMaiuscula;
        private Label label6;
        private TextBox txtPalindromo;
        private Button btnOrdem;
        private Button btnDuplicacao;
        private Button btnPalindromaLonga;
        private Button btnMaiusculo;
        private Button btnPalindromo;
        private Label lblOrdem;
        private Label lblDuplicacao;
        private Label lblPalindromaLonga;
        private Label lblMaiusculo;
        private Label lblPalindromo;
    }
}