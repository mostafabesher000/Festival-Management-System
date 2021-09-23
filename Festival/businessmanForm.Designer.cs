namespace Festival
{
    partial class businessmanForm
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
            this.btncreatevt = new System.Windows.Forms.Button();
            this.btnoffer = new System.Windows.Forms.Button();
            this.btndisoffer = new System.Windows.Forms.Button();
            this.datagridviewevt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewevt)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreatevt
            // 
            this.btncreatevt.BackColor = System.Drawing.Color.Transparent;
            this.btncreatevt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreatevt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatevt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncreatevt.Location = new System.Drawing.Point(190, 367);
            this.btncreatevt.Name = "btncreatevt";
            this.btncreatevt.Size = new System.Drawing.Size(116, 33);
            this.btncreatevt.TabIndex = 0;
            this.btncreatevt.Text = "Create Event";
            this.btncreatevt.UseVisualStyleBackColor = false;
            this.btncreatevt.Click += new System.EventHandler(this.btncreatevt_Click);
            // 
            // btnoffer
            // 
            this.btnoffer.BackColor = System.Drawing.Color.Transparent;
            this.btnoffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoffer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoffer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnoffer.Location = new System.Drawing.Point(355, 367);
            this.btnoffer.Name = "btnoffer";
            this.btnoffer.Size = new System.Drawing.Size(115, 33);
            this.btnoffer.TabIndex = 1;
            this.btnoffer.Text = "Offer ";
            this.btnoffer.UseVisualStyleBackColor = false;
            this.btnoffer.Click += new System.EventHandler(this.btnoffer_Click);
            // 
            // btndisoffer
            // 
            this.btndisoffer.BackColor = System.Drawing.Color.Transparent;
            this.btndisoffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisoffer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisoffer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndisoffer.Location = new System.Drawing.Point(522, 367);
            this.btndisoffer.Name = "btndisoffer";
            this.btndisoffer.Size = new System.Drawing.Size(115, 33);
            this.btndisoffer.TabIndex = 2;
            this.btndisoffer.Text = "Discount Offer";
            this.btndisoffer.UseVisualStyleBackColor = false;
            this.btndisoffer.Click += new System.EventHandler(this.btndisoffer_Click);
            // 
            // datagridviewevt
            // 
            this.datagridviewevt.AllowUserToAddRows = false;
            this.datagridviewevt.AllowUserToDeleteRows = false;
            this.datagridviewevt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridviewevt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewevt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewevt.Location = new System.Drawing.Point(62, 34);
            this.datagridviewevt.MultiSelect = false;
            this.datagridviewevt.Name = "datagridviewevt";
            this.datagridviewevt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewevt.Size = new System.Drawing.Size(704, 313);
            this.datagridviewevt.TabIndex = 3;
            // 
            // businessmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Festival.Properties.Resources.what_you_need_start_new_business;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.datagridviewevt);
            this.Controls.Add(this.btndisoffer);
            this.Controls.Add(this.btnoffer);
            this.Controls.Add(this.btncreatevt);
            this.Name = "businessmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "businessmanForm";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewevt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncreatevt;
        private System.Windows.Forms.Button btnoffer;
        private System.Windows.Forms.Button btndisoffer;
        private System.Windows.Forms.DataGridView datagridviewevt;
    }
}