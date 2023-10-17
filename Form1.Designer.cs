namespace Calculadora
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
            txtbresultado = new TextBox();
            btncero = new Button();
            btnIgual = new Button();
            btnone = new Button();
            btnthree = new Button();
            btntwo = new Button();
            btnsixe = new Button();
            btnfive = new Button();
            btnfour = new Button();
            btnnime = new Button();
            btnocho = new Button();
            btnseven = new Button();
            btnborrar = new Button();
            btnresta = new Button();
            btnmulti = new Button();
            btndividir = new Button();
            btnsuma = new Button();
            SuspendLayout();
            // 
            // txtbresultado
            // 
            txtbresultado.BackColor = SystemColors.Control;
            txtbresultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtbresultado.Location = new Point(15, 12);
            txtbresultado.MaxLength = 22;
            txtbresultado.Multiline = true;
            txtbresultado.Name = "txtbresultado";
            txtbresultado.ReadOnly = true;
            txtbresultado.RightToLeft = RightToLeft.Yes;
            txtbresultado.Size = new Size(317, 45);
            txtbresultado.TabIndex = 0;
            txtbresultado.Text = "0";
            // 
            // btncero
            // 
            btncero.BackColor = SystemColors.ActiveBorder;
            btncero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncero.Location = new Point(12, 346);
            btncero.Name = "btncero";
            btncero.Size = new Size(134, 48);
            btncero.TabIndex = 1;
            btncero.Text = "0";
            btncero.UseVisualStyleBackColor = false;
            btncero.Click += AgregarNumero;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.ActiveBorder;
            btnIgual.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnIgual.Location = new Point(152, 346);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(119, 48);
            btnIgual.TabIndex = 2;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += resolver;
            // 
            // btnone
            // 
            btnone.BackColor = SystemColors.ActiveBorder;
            btnone.Location = new Point(12, 276);
            btnone.Name = "btnone";
            btnone.Size = new Size(55, 55);
            btnone.TabIndex = 3;
            btnone.Text = "1";
            btnone.UseVisualStyleBackColor = false;
            btnone.Click += AgregarNumero;
            // 
            // btnthree
            // 
            btnthree.BackColor = SystemColors.ActiveBorder;
            btnthree.Location = new Point(134, 276);
            btnthree.Name = "btnthree";
            btnthree.Size = new Size(55, 55);
            btnthree.TabIndex = 4;
            btnthree.Text = "3";
            btnthree.UseVisualStyleBackColor = false;
            btnthree.Click += AgregarNumero;
            // 
            // btntwo
            // 
            btntwo.BackColor = SystemColors.ActiveBorder;
            btntwo.Location = new Point(73, 276);
            btntwo.Name = "btntwo";
            btntwo.Size = new Size(55, 55);
            btntwo.TabIndex = 5;
            btntwo.Text = "2";
            btntwo.UseVisualStyleBackColor = false;
            btntwo.Click += AgregarNumero;
            // 
            // btnsixe
            // 
            btnsixe.BackColor = SystemColors.ActiveBorder;
            btnsixe.Location = new Point(134, 209);
            btnsixe.Name = "btnsixe";
            btnsixe.Size = new Size(55, 55);
            btnsixe.TabIndex = 6;
            btnsixe.Text = "6";
            btnsixe.UseVisualStyleBackColor = false;
            btnsixe.Click += AgregarNumero;
            // 
            // btnfive
            // 
            btnfive.BackColor = SystemColors.ActiveBorder;
            btnfive.Location = new Point(73, 209);
            btnfive.Name = "btnfive";
            btnfive.Size = new Size(55, 55);
            btnfive.TabIndex = 7;
            btnfive.Text = "5";
            btnfive.UseVisualStyleBackColor = false;
            btnfive.Click += AgregarNumero;
            // 
            // btnfour
            // 
            btnfour.BackColor = SystemColors.ActiveBorder;
            btnfour.Location = new Point(12, 209);
            btnfour.Name = "btnfour";
            btnfour.Size = new Size(55, 55);
            btnfour.TabIndex = 8;
            btnfour.Text = "4";
            btnfour.UseVisualStyleBackColor = false;
            btnfour.Click += AgregarNumero;
            // 
            // btnnime
            // 
            btnnime.BackColor = SystemColors.ActiveBorder;
            btnnime.Location = new Point(134, 138);
            btnnime.Name = "btnnime";
            btnnime.Size = new Size(55, 55);
            btnnime.TabIndex = 9;
            btnnime.Text = "9";
            btnnime.UseVisualStyleBackColor = false;
            btnnime.Click += AgregarNumero;
            // 
            // btnocho
            // 
            btnocho.BackColor = SystemColors.ActiveBorder;
            btnocho.Location = new Point(73, 138);
            btnocho.Name = "btnocho";
            btnocho.Size = new Size(55, 55);
            btnocho.TabIndex = 10;
            btnocho.Text = "8";
            btnocho.UseVisualStyleBackColor = false;
            btnocho.Click += AgregarNumero;
            // 
            // btnseven
            // 
            btnseven.BackColor = SystemColors.ActiveBorder;
            btnseven.Location = new Point(12, 138);
            btnseven.Name = "btnseven";
            btnseven.Size = new Size(55, 55);
            btnseven.TabIndex = 11;
            btnseven.Text = "7";
            btnseven.UseVisualStyleBackColor = false;
            btnseven.Click += AgregarNumero;
            // 
            // btnborrar
            // 
            btnborrar.BackColor = SystemColors.ActiveBorder;
            btnborrar.Location = new Point(12, 74);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(55, 55);
            btnborrar.TabIndex = 12;
            btnborrar.Text = "C";
            btnborrar.UseVisualStyleBackColor = false;
            btnborrar.Click += btnborrar_Click;
            // 
            // btnresta
            // 
            btnresta.BackColor = Color.FromArgb(255, 128, 0);
            btnresta.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnresta.Location = new Point(277, 276);
            btnresta.Margin = new Padding(0);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(55, 55);
            btnresta.TabIndex = 13;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += Signo_Selector;
            // 
            // btnmulti
            // 
            btnmulti.BackColor = Color.FromArgb(255, 128, 0);
            btnmulti.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnmulti.Location = new Point(277, 209);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(55, 55);
            btnmulti.TabIndex = 14;
            btnmulti.Text = "x";
            btnmulti.UseVisualStyleBackColor = false;
            btnmulti.Click += Signo_Selector;
            // 
            // btndividir
            // 
            btndividir.BackColor = Color.FromArgb(255, 128, 0);
            btndividir.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btndividir.Location = new Point(277, 138);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(55, 55);
            btndividir.TabIndex = 15;
            btndividir.Text = "/";
            btndividir.UseVisualStyleBackColor = false;
            btndividir.Click += Signo_Selector;
            // 
            // btnsuma
            // 
            btnsuma.BackColor = Color.FromArgb(255, 128, 0);
            btnsuma.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnsuma.Location = new Point(277, 346);
            btnsuma.Margin = new Padding(0);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(55, 48);
            btnsuma.TabIndex = 16;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += Signo_Selector;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(341, 399);
            Controls.Add(btnsuma);
            Controls.Add(btndividir);
            Controls.Add(btnmulti);
            Controls.Add(btnresta);
            Controls.Add(btnborrar);
            Controls.Add(btnseven);
            Controls.Add(btnocho);
            Controls.Add(btnnime);
            Controls.Add(btnfour);
            Controls.Add(btnfive);
            Controls.Add(btnsixe);
            Controls.Add(btntwo);
            Controls.Add(btnthree);
            Controls.Add(btnone);
            Controls.Add(btnIgual);
            Controls.Add(btncero);
            Controls.Add(txtbresultado);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbresultado;
        private Button btncero;
        private Button btnIgual;
        private Button btnone;
        private Button btnthree;
        private Button btntwo;
        private Button btnsixe;
        private Button btnfive;
        private Button btnfour;
        private Button btnnime;
        private Button btnocho;
        private Button btnseven;
        private Button btnborrar;
        private Button btnresta;
        private Button btnmulti;
        private Button btndividir;
        private Button btnsuma;
    }
}