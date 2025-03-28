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
            this.combo_difficulte = new System.Windows.Forms.ComboBox();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.gbox_recherche = new System.Windows.Forms.GroupBox();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.lbl_rechercheQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_tab)).BeginInit();
            this.gbox_recherche.SuspendLayout();
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
            this.datagv_tab.Location = new System.Drawing.Point(43, 132);
            this.datagv_tab.Name = "datagv_tab";
            this.datagv_tab.ReadOnly = true;
            this.datagv_tab.Size = new System.Drawing.Size(794, 374);
            this.datagv_tab.TabIndex = 22;
            // 
            // combo_difficulte
            // 
            this.combo_difficulte.FormattingEnabled = true;
            this.combo_difficulte.Location = new System.Drawing.Point(122, 56);
            this.combo_difficulte.Name = "combo_difficulte";
            this.combo_difficulte.Size = new System.Drawing.Size(176, 21);
            this.combo_difficulte.TabIndex = 23;
            // 
            // txt_recherche
            // 
            this.txt_recherche.Location = new System.Drawing.Point(122, 30);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(176, 20);
            this.txt_recherche.TabIndex = 24;
            // 
            // gbox_recherche
            // 
            this.gbox_recherche.Controls.Add(this.lbl_difficulte);
            this.gbox_recherche.Controls.Add(this.lbl_rechercheQ);
            this.gbox_recherche.Controls.Add(this.combo_difficulte);
            this.gbox_recherche.Controls.Add(this.txt_recherche);
            this.gbox_recherche.Location = new System.Drawing.Point(533, 12);
            this.gbox_recherche.Name = "gbox_recherche";
            this.gbox_recherche.Size = new System.Drawing.Size(304, 100);
            this.gbox_recherche.TabIndex = 25;
            this.gbox_recherche.TabStop = false;
            this.gbox_recherche.Text = "Recherche";
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(21, 59);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 26;
            this.lbl_difficulte.Text = "Difficulté\r\n";
            // 
            // lbl_rechercheQ
            // 
            this.lbl_rechercheQ.AutoSize = true;
            this.lbl_rechercheQ.Location = new System.Drawing.Point(21, 30);
            this.lbl_rechercheQ.Name = "lbl_rechercheQ";
            this.lbl_rechercheQ.Size = new System.Drawing.Size(95, 13);
            this.lbl_rechercheQ.TabIndex = 25;
            this.lbl_rechercheQ.Text = "Recherche de mot";
            // 
            // Donnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 535);
            this.Controls.Add(this.gbox_recherche);
            this.Controls.Add(this.datagv_tab);
            this.Controls.Add(this.but_leave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donnees";
            this.Text = "Données";
            ((System.ComponentModel.ISupportInitialize)(this.datagv_tab)).EndInit();
            this.gbox_recherche.ResumeLayout(false);
            this.gbox_recherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_leave;
        private System.Windows.Forms.DataGridView datagv_tab;
        private System.Windows.Forms.ComboBox combo_difficulte;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.GroupBox gbox_recherche;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.Label lbl_rechercheQ;
    }
}