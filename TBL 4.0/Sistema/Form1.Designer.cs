namespace Sistema
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
            panel1 = new Panel();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Location = new Point(711, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(40, 40);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "❐";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Location = new Point(711, 9);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(40, 40);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.Text = "□";
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 40);
            label1.TabIndex = 1;
            label1.Text = "Meu sistema";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(757, 3);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 300);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(12, 131);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 2;
            button4.Text = "Produtos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button5_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 91);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 3;
            button5.Text = "Vendas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 57);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Relatórios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(0, 6);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 0;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button btnMaximizar;
        private Button btnRestaurar;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
