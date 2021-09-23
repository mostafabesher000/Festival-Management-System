namespace Festival
{
    partial class adminForm
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
            this.datagridviewevt = new System.Windows.Forms.DataGridView();
            this.btnapprove = new System.Windows.Forms.Button();
            this.btndisapprove = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewevt)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewevt
            // 
            this.datagridviewevt.AllowUserToAddRows = false;
            this.datagridviewevt.AllowUserToDeleteRows = false;
            this.datagridviewevt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridviewevt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewevt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewevt.Location = new System.Drawing.Point(73, 48);
            this.datagridviewevt.MultiSelect = false;
            this.datagridviewevt.Name = "datagridviewevt";
            this.datagridviewevt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewevt.Size = new System.Drawing.Size(696, 283);
            this.datagridviewevt.TabIndex = 0;
            // 
            // btnapprove
            // 
            this.btnapprove.BackColor = System.Drawing.Color.Transparent;
            this.btnapprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapprove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapprove.ForeColor = System.Drawing.Color.Lime;
            this.btnapprove.Location = new System.Drawing.Point(220, 351);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(114, 34);
            this.btnapprove.TabIndex = 1;
            this.btnapprove.Text = "Approve";
            this.btnapprove.UseVisualStyleBackColor = false;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // btndisapprove
            // 
            this.btndisapprove.BackColor = System.Drawing.Color.Transparent;
            this.btndisapprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisapprove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisapprove.ForeColor = System.Drawing.Color.Red;
            this.btndisapprove.Location = new System.Drawing.Point(499, 351);
            this.btndisapprove.Name = "btndisapprove";
            this.btndisapprove.Size = new System.Drawing.Size(114, 34);
            this.btndisapprove.TabIndex = 2;
            this.btndisapprove.Text = "Disapprove";
            this.btndisapprove.UseVisualStyleBackColor = false;
            this.btndisapprove.Click += new System.EventHandler(this.btndisapprove_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Blue;
            this.btnrefresh.Location = new System.Drawing.Point(361, 351);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(114, 34);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Festival.Properties.Resources.setting_smarter_goals;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 414);
            this.Controls.Add(this.btnapprove);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndisapprove);
            this.Controls.Add(this.datagridviewevt);
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminForm";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewevt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btndisapprove;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.DataGridView datagridviewevt;
        private System.Windows.Forms.Button btnrefresh;
    }
}