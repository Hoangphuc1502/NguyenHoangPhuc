namespace NguyenHoangPhuc
{
    partial class Home
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
            this.btBT = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBT
            // 
            this.btBT.Location = new System.Drawing.Point(82, 48);
            this.btBT.Name = "btBT";
            this.btBT.Size = new System.Drawing.Size(113, 48);
            this.btBT.TabIndex = 0;
            this.btBT.Text = "Bài Tập";
            this.btBT.UseVisualStyleBackColor = true;
            this.btBT.Click += new System.EventHandler(this.btBT_Click);
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(277, 48);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(113, 48);
            this.btQL.TabIndex = 1;
            this.btQL.Text = "Quản Lý HS";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.btBT);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btBT;
        private Button btQL;
    }
}