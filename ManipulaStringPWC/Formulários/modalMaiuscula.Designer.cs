﻿namespace ManipulaStringPWC.Formulários
{
    partial class modalMaiuscula
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
            txtOutput = new PortaldoPreco2.Customtxt();
            btnCopiar = new PortaldoPreco2.Resources.CustomButton();
            label1 = new Label();
            button8 = new Button();
            btnEditar = new PortaldoPreco2.Resources.CustomButton();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.Window;
            txtOutput.BorderColor = Color.DarkGray;
            txtOutput.BorderFocusColor = SystemColors.Highlight;
            txtOutput.BorderRadius = 8;
            txtOutput.BorderSize = 2;
            txtOutput.Enabled = false;
            txtOutput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOutput.ForeColor = Color.DimGray;
            txtOutput.Location = new Point(56, 82);
            txtOutput.Margin = new Padding(4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Padding = new Padding(7);
            txtOutput.PasswordChar = true;
            txtOutput.PlaceholderColor = Color.DarkGray;
            txtOutput.PlaceholderText = "";
            txtOutput.Size = new Size(821, 272);
            txtOutput.TabIndex = 21;
            txtOutput.Texts = "";
            txtOutput.UnderlinedStyle = false;
            // 
            // btnCopiar
            // 
            btnCopiar.BackColor = Color.CornflowerBlue;
            btnCopiar.BackgroundColor = Color.CornflowerBlue;
            btnCopiar.BackgroundImage = Properties.Resources.COPIAR;
            btnCopiar.BackgroundImageLayout = ImageLayout.Center;
            btnCopiar.BorderColor = Color.PaleVioletRed;
            btnCopiar.BorderRadius = 5;
            btnCopiar.BorderSize = 0;
            btnCopiar.FlatAppearance.BorderSize = 0;
            btnCopiar.FlatStyle = FlatStyle.Flat;
            btnCopiar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopiar.ForeColor = Color.White;
            btnCopiar.Location = new Point(347, 361);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(113, 48);
            btnCopiar.TabIndex = 19;
            btnCopiar.TextColor = Color.White;
            btnCopiar.UseVisualStyleBackColor = false;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 19);
            label1.Name = "label1";
            label1.Size = new Size(622, 37);
            label1.TabIndex = 22;
            label1.Text = "Esta é a frase transformada em maiúscula";
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.BackgroundImage = Properties.Resources.ei_close;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(897, 0);
            button8.Name = "button8";
            button8.Size = new Size(24, 24);
            button8.TabIndex = 23;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            button8.MouseEnter += button8_MouseEnter;
            button8.MouseLeave += button8_MouseLeave;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.CornflowerBlue;
            btnEditar.BackgroundColor = Color.CornflowerBlue;
            btnEditar.BackgroundImage = Properties.Resources.EDITAR;
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.BorderColor = Color.PaleVioletRed;
            btnEditar.BorderRadius = 5;
            btnEditar.BorderSize = 0;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(477, 361);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(113, 48);
            btnEditar.TabIndex = 24;
            btnEditar.TextColor = Color.White;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // modalMaiuscula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 421);
            Controls.Add(btnEditar);
            Controls.Add(button8);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(btnCopiar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "modalMaiuscula";
            Text = "modalAnagrama";
            Load += modalMaiuscula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PortaldoPreco2.Customtxt txtOutput;
        private PortaldoPreco2.Resources.CustomButton btnCopiar;
        private Label label1;
        private Button button8;
        private PortaldoPreco2.Resources.CustomButton btnEditar;
    }
}