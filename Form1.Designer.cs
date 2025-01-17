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
            this.lbl_rep = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txt_afficher = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.lbl_difficult = new System.Windows.Forms.Label();
            this.combo_difficult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_rep
            // 
            this.lbl_rep.AutoSize = true;
            this.lbl_rep.Location = new System.Drawing.Point(197, 100);
            this.lbl_rep.Name = "lbl_rep";
            this.lbl_rep.Size = new System.Drawing.Size(50, 13);
            this.lbl_rep.TabIndex = 0;
            this.lbl_rep.Text = "Réponse";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(362, 337);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Push Me";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_afficher
            // 
            this.txt_afficher.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_afficher.Enabled = false;
            this.txt_afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_afficher.Location = new System.Drawing.Point(292, 91);
            this.txt_afficher.Name = "txt_afficher";
            this.txt_afficher.Size = new System.Drawing.Size(274, 22);
            this.txt_afficher.TabIndex = 2;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(211, 176);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 3;
            this.lbl_nom.Text = "Nom :";
            this.lbl_nom.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(198, 232);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(292, 169);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(169, 20);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(292, 225);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(169, 20);
            this.txt_prenom.TabIndex = 6;
            // 
            // lbl_difficult
            // 
            this.lbl_difficult.AutoSize = true;
            this.lbl_difficult.Location = new System.Drawing.Point(211, 287);
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
            this.combo_difficult.Size = new System.Drawing.Size(169, 21);
            this.combo_difficult.TabIndex = 8;
            this.combo_difficult.SelectedIndexChanged += new System.EventHandler(this.combo_difficult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_difficult);
            this.Controls.Add(this.lbl_difficult);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_afficher);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_rep);
            this.Name = "Form1";
            this.Text = "Mon 1er formulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rep;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_afficher;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label lbl_difficult;
        private System.Windows.Forms.ComboBox combo_difficult;
    }
}

