namespace QuizzAndTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.lbl_difficult = new System.Windows.Forms.Label();
            this.combo_difficult = new System.Windows.Forms.ComboBox();
            this.but_leave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(324, 395);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(357, 79);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(172, 57);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 3;
            this.lbl_nom.Text = "Nom :";
            this.lbl_nom.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(158, 134);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(292, 57);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(433, 20);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(292, 131);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(433, 20);
            this.txt_prenom.TabIndex = 6;
            // 
            // lbl_difficult
            // 
            this.lbl_difficult.AutoSize = true;
            this.lbl_difficult.Location = new System.Drawing.Point(153, 287);
            this.lbl_difficult.Name = "lbl_difficult";
            this.lbl_difficult.Size = new System.Drawing.Size(54, 13);
            this.lbl_difficult.TabIndex = 7;
            this.lbl_difficult.Text = "Difficulté :";
            this.lbl_difficult.Click += new System.EventHandler(this.label1_Click);
            // 
            // combo_difficult
            // 
            this.combo_difficult.FormattingEnabled = true;
            this.combo_difficult.Location = new System.Drawing.Point(292, 279);
            this.combo_difficult.Name = "combo_difficult";
            this.combo_difficult.Size = new System.Drawing.Size(433, 21);
            this.combo_difficult.TabIndex = 8;
            this.combo_difficult.SelectedIndexChanged += new System.EventHandler(this.combo_difficult_Click);
            // 
            // but_leave
            // 
            this.but_leave.BackColor = System.Drawing.Color.Red;
            this.but_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_leave.ForeColor = System.Drawing.Color.Black;
            this.but_leave.Location = new System.Drawing.Point(922, 20);
            this.but_leave.Name = "but_leave";
            this.but_leave.Size = new System.Drawing.Size(50, 50);
            this.but_leave.TabIndex = 21;
            this.but_leave.Text = "❌";
            this.but_leave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.but_leave);
            this.Controls.Add(this.combo_difficult);
            this.Controls.Add(this.lbl_difficult);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Mon 1er formulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label lbl_difficult;
        private System.Windows.Forms.ComboBox combo_difficult;
        private System.Windows.Forms.Button but_leave;
    }
}

