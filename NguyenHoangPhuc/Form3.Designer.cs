namespace NguyenHoangPhuc
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btcham = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(81, 87);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(98, 83);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(185, 87);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(98, 83);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(289, 87);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(98, 83);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(393, 87);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(98, 83);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(185, 176);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(98, 83);
            this.btMul.TabIndex = 5;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(81, 176);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(98, 83);
            this.btPlus.TabIndex = 6;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btcham
            // 
            this.btcham.Location = new System.Drawing.Point(289, 176);
            this.btcham.Name = "btcham";
            this.btcham.Size = new System.Drawing.Size(98, 83);
            this.btcham.TabIndex = 7;
            this.btcham.Text = ".";
            this.btcham.UseVisualStyleBackColor = true;
            this.btcham.Click += new System.EventHandler(this.btcham_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(393, 176);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(98, 83);
            this.btEquals.TabIndex = 8;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btcham);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btMul;
        private Button btPlus;
        private Button btcham;
        private Button btEquals;
    }
}