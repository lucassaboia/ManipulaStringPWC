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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label3 = new Label();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            panelNavbar = new Panel();
            btnnavHome = new Button();
            btnnavAnagrama = new Button();
            btnnavMaiuscula = new Button();
            btnnavPalindroma = new Button();
            btnnavDuplicacao = new Button();
            btnnavOrdem = new Button();
            panelDesktopPane = new Panel();
            panel1.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 292);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 29, 29);
            panel1.BackgroundImage = Properties.Resources.Header;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 82);
            panel1.TabIndex = 22;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = Properties.Resources.ei_close;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(1200, 0);
            button8.Name = "button8";
            button8.Size = new Size(24, 24);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.material_symbols_minimize;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(156, 156, 156);
            button7.Location = new Point(1170, 0);
            button7.Name = "button7";
            button7.Size = new Size(24, 24);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(249, 249, 249);
            panelNavbar.Controls.Add(btnnavHome);
            panelNavbar.Controls.Add(btnnavAnagrama);
            panelNavbar.Controls.Add(btnnavMaiuscula);
            panelNavbar.Controls.Add(btnnavPalindroma);
            panelNavbar.Controls.Add(btnnavDuplicacao);
            panelNavbar.Controls.Add(btnnavOrdem);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.Control;
            panelNavbar.Location = new Point(0, 82);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1224, 59);
            panelNavbar.TabIndex = 23;
            // 
            // btnnavHome
            // 
            btnnavHome.BackColor = Color.FromArgb(29, 29, 29);
            btnnavHome.Dock = DockStyle.Left;
            btnnavHome.FlatAppearance.BorderSize = 0;
            btnnavHome.FlatStyle = FlatStyle.Flat;
            btnnavHome.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnnavHome.ForeColor = Color.White;
            btnnavHome.Location = new Point(0, 0);
            btnnavHome.Name = "btnnavHome";
            btnnavHome.Size = new Size(172, 59);
            btnnavHome.TabIndex = 8;
            btnnavHome.Text = "Home";
            btnnavHome.UseVisualStyleBackColor = false;
            btnnavHome.Click += btnnavHome_Click;
            // 
            // btnnavAnagrama
            // 
            btnnavAnagrama.BackColor = Color.Transparent;
            btnnavAnagrama.Dock = DockStyle.Right;
            btnnavAnagrama.FlatAppearance.BorderSize = 0;
            btnnavAnagrama.FlatStyle = FlatStyle.Flat;
            btnnavAnagrama.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnnavAnagrama.ForeColor = Color.FromArgb(156, 156, 156);
            btnnavAnagrama.Location = new Point(364, 0);
            btnnavAnagrama.Name = "btnnavAnagrama";
            btnnavAnagrama.Size = new Size(172, 59);
            btnnavAnagrama.TabIndex = 7;
            btnnavAnagrama.Text = "Anagrama";
            btnnavAnagrama.UseVisualStyleBackColor = true;
            btnnavAnagrama.Click += btnnavAnagrama_Click;
            // 
            // btnnavMaiuscula
            // 
            btnnavMaiuscula.BackColor = Color.Transparent;
            btnnavMaiuscula.Dock = DockStyle.Right;
            btnnavMaiuscula.FlatAppearance.BorderSize = 0;
            btnnavMaiuscula.FlatStyle = FlatStyle.Flat;
            btnnavMaiuscula.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnnavMaiuscula.ForeColor = Color.FromArgb(156, 156, 156);
            btnnavMaiuscula.Location = new Point(536, 0);
            btnnavMaiuscula.Name = "btnnavMaiuscula";
            btnnavMaiuscula.Size = new Size(172, 59);
            btnnavMaiuscula.TabIndex = 6;
            btnnavMaiuscula.Text = "Maiúscula";
            btnnavMaiuscula.UseVisualStyleBackColor = true;
            btnnavMaiuscula.Click += btnnavMaiuscula_Click;
            // 
            // btnnavPalindroma
            // 
            btnnavPalindroma.BackColor = Color.Transparent;
            btnnavPalindroma.Dock = DockStyle.Right;
            btnnavPalindroma.FlatAppearance.BorderSize = 0;
            btnnavPalindroma.FlatStyle = FlatStyle.Flat;
            btnnavPalindroma.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnnavPalindroma.ForeColor = Color.FromArgb(156, 156, 156);
            btnnavPalindroma.Location = new Point(708, 0);
            btnnavPalindroma.Name = "btnnavPalindroma";
            btnnavPalindroma.Size = new Size(172, 59);
            btnnavPalindroma.TabIndex = 5;
            btnnavPalindroma.Text = "Palíndroma";
            btnnavPalindroma.UseVisualStyleBackColor = true;
            btnnavPalindroma.Click += btnnavPalindroma_Click;
            // 
            // btnnavDuplicacao
            // 
            btnnavDuplicacao.BackColor = Color.Transparent;
            btnnavDuplicacao.Dock = DockStyle.Right;
            btnnavDuplicacao.FlatAppearance.BorderSize = 0;
            btnnavDuplicacao.FlatStyle = FlatStyle.Flat;
            btnnavDuplicacao.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnnavDuplicacao.ForeColor = Color.FromArgb(156, 156, 156);
            btnnavDuplicacao.Location = new Point(880, 0);
            btnnavDuplicacao.Name = "btnnavDuplicacao";
            btnnavDuplicacao.Size = new Size(172, 59);
            btnnavDuplicacao.TabIndex = 4;
            btnnavDuplicacao.Text = "Duplicação";
            btnnavDuplicacao.UseVisualStyleBackColor = true;
            btnnavDuplicacao.Click += btnnavDuplicacao_Click;
            // 
            // btnnavOrdem
            // 
            btnnavOrdem.BackColor = Color.Transparent;
            btnnavOrdem.Dock = DockStyle.Right;
            btnnavOrdem.FlatAppearance.BorderSize = 0;
            btnnavOrdem.FlatStyle = FlatStyle.Flat;
            btnnavOrdem.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnnavOrdem.ForeColor = Color.FromArgb(156, 156, 156);
            btnnavOrdem.Location = new Point(1052, 0);
            btnnavOrdem.Name = "btnnavOrdem";
            btnnavOrdem.Size = new Size(172, 59);
            btnnavOrdem.TabIndex = 1;
            btnnavOrdem.Text = "Ordem";
            btnnavOrdem.UseVisualStyleBackColor = true;
            btnnavOrdem.Click += btnnavOrdem_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(0, 141);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1224, 369);
            panelDesktopPane.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1224, 510);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelNavbar);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel1;
        private Panel panelNavbar;
        private Button btnnavAnagrama;
        private Button btnnavMaiuscula;
        private Button btnnavPalindroma;
        private Button btnnavDuplicacao;
        private Button btnnavOrdem;
        private Button btnnavHome;
        private Button button8;
        private Button button7;
        private Panel panelDesktopPane;
    }
}