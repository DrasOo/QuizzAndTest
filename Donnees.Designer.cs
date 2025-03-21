namespace QuizzAndTest
{
    partial class Donnees
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
            this.but_leave = new System.Windows.Forms.Button();
            this.datagv_tab = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_tab)).BeginInit();
            this.SuspendLayout();
            // 
            // but_leave
            // 
            this.but_leave.BackColor = System.Drawing.Color.Red;
            this.but_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_leave.ForeColor = System.Drawing.Color.Black;
            this.but_leave.Location = new System.Drawing.Point(921, 12);
            this.but_leave.Name = "but_leave";
            this.but_leave.Size = new System.Drawing.Size(50, 50);
            this.but_leave.TabIndex = 21;
            this.but_leave.Text = "❌";
            this.but_leave.UseVisualStyleBackColor = false;
            this.but_leave.Click += new System.EventHandler(this.but_leave_Click);
            // 
            // datagv_tab
            // 
            this.datagv_tab.AllowUserToAddRows = false;
            this.datagv_tab.AllowUserToDeleteRows = false;
            this.datagv_tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_tab.Location = new System.Drawing.Point(49, 34);
            this.datagv_tab.Name = "datagv_tab";
            this.datagv_tab.ReadOnly = true;
            this.datagv_tab.Size = new System.Drawing.Size(618, 453);
            this.datagv_tab.TabIndex = 22;
            // 
            // Donnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 535);
            this.Controls.Add(this.datagv_tab);
            this.Controls.Add(this.but_leave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donnees";
            this.Text = "Données";
            ((System.ComponentModel.ISupportInitialize)(this.datagv_tab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_leave;
        private System.Windows.Forms.DataGridView datagv_tab;
    }
}