namespace Festival
{
    partial class discountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtboxevtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxdiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpost = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(342, 98);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(141, 20);
            this.txtboxusername.TabIndex = 1;
            // 
            // txtboxevtname
            // 
            this.txtboxevtname.Location = new System.Drawing.Point(138, 50);
            this.txtboxevtname.Name = "txtboxevtname";
            this.txtboxevtname.Size = new System.Drawing.Size(345, 20);
            this.txtboxevtname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Name";
            // 
            // txtboxdiscount
            // 
            this.txtboxdiscount.Location = new System.Drawing.Point(138, 99);
            this.txtboxdiscount.Name = "txtboxdiscount";
            this.txtboxdiscount.Size = new System.Drawing.Size(88, 20);
            this.txtboxdiscount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount";
            // 
            // btnpost
            // 
            this.btnpost.BackColor = System.Drawing.Color.Transparent;
            this.btnpost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpost.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpost.Location = new System.Drawing.Point(151, 166);
            this.btnpost.Name = "btnpost";
            this.btnpost.Size = new System.Drawing.Size(75, 34);
            this.btnpost.TabIndex = 6;
            this.btnpost.Text = "Post";
            this.btnpost.UseVisualStyleBackColor = false;
            this.btnpost.Click += new System.EventHandler(this.btnpost_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(295, 166);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 34);
            this.btnback.TabIndex = 18;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // discountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Festival.Properties.Resources.shutterstock_543802489_850x476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 273);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpost);
            this.Controls.Add(this.txtboxdiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxevtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "discountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "discountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtboxevtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxdiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpost;
        private System.Windows.Forms.Button btnback;
    }
}