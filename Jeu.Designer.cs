﻿namespace QuizzAndTest
{
    partial class Jeu
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
            this.lbl_quizz = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.lbl_tempstot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_question = new System.Windows.Forms.TextBox();
            this.txtbox_tempstot = new System.Windows.Forms.TextBox();
            this.grpbox_rep = new System.Windows.Forms.GroupBox();
            this.chkbox_rep5 = new System.Windows.Forms.CheckBox();
            this.chkbox_rep2 = new System.Windows.Forms.CheckBox();
            this.chkbox_rep3 = new System.Windows.Forms.CheckBox();
            this.chkbox_rep4 = new System.Windows.Forms.CheckBox();
            this.chkbox_rep1 = new System.Windows.Forms.CheckBox();
            this.but_validation = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtbox_joueur = new System.Windows.Forms.TextBox();
            this.txtbox_difficulte = new System.Windows.Forms.TextBox();
            this.lbl_joueur = new System.Windows.Forms.Label();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.prgBar_timer = new System.Windows.Forms.ProgressBar();
            this.picbox_img = new System.Windows.Forms.PictureBox();
            this.but_leave = new System.Windows.Forms.Button();
            this.grpbox_rep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_quizz
            // 
            this.lbl_quizz.AutoSize = true;
            this.lbl_quizz.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quizz.Location = new System.Drawing.Point(321, 22);
            this.lbl_quizz.Name = "lbl_quizz";
            this.lbl_quizz.Size = new System.Drawing.Size(268, 39);
            this.lbl_quizz.TabIndex = 0;
            this.lbl_quizz.Text = "Quizz And Test";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(98, 62);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(58, 13);
            this.lbl_question.TabIndex = 1;
            this.lbl_question.Text = "Question 1";
            // 
            // lbl_tempstot
            // 
            this.lbl_tempstot.AutoSize = true;
            this.lbl_tempstot.Location = new System.Drawing.Point(711, 25);
            this.lbl_tempstot.Name = "lbl_tempstot";
            this.lbl_tempstot.Size = new System.Drawing.Size(62, 13);
            this.lbl_tempstot.TabIndex = 2;
            this.lbl_tempstot.Text = "Temps total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 8;
            // 
            // txtbox_question
            // 
            this.txtbox_question.Enabled = false;
            this.txtbox_question.Location = new System.Drawing.Point(101, 78);
            this.txtbox_question.Multiline = true;
            this.txtbox_question.Name = "txtbox_question";
            this.txtbox_question.Size = new System.Drawing.Size(518, 73);
            this.txtbox_question.TabIndex = 9;
            // 
            // txtbox_tempstot
            // 
            this.txtbox_tempstot.Enabled = false;
            this.txtbox_tempstot.Location = new System.Drawing.Point(714, 41);
            this.txtbox_tempstot.Name = "txtbox_tempstot";
            this.txtbox_tempstot.Size = new System.Drawing.Size(178, 20);
            this.txtbox_tempstot.TabIndex = 10;
            // 
            // grpbox_rep
            // 
            this.grpbox_rep.Controls.Add(this.chkbox_rep5);
            this.grpbox_rep.Controls.Add(this.chkbox_rep2);
            this.grpbox_rep.Controls.Add(this.chkbox_rep3);
            this.grpbox_rep.Controls.Add(this.chkbox_rep4);
            this.grpbox_rep.Controls.Add(this.chkbox_rep1);
            this.grpbox_rep.Location = new System.Drawing.Point(101, 182);
            this.grpbox_rep.Name = "grpbox_rep";
            this.grpbox_rep.Size = new System.Drawing.Size(518, 217);
            this.grpbox_rep.TabIndex = 12;
            this.grpbox_rep.TabStop = false;
            this.grpbox_rep.Text = "Réponses possibles";
            // 
            // chkbox_rep5
            // 
            this.chkbox_rep5.AutoSize = true;
            this.chkbox_rep5.Location = new System.Drawing.Point(19, 181);
            this.chkbox_rep5.Name = "chkbox_rep5";
            this.chkbox_rep5.Size = new System.Drawing.Size(78, 17);
            this.chkbox_rep5.TabIndex = 4;
            this.chkbox_rep5.Text = "Réponse 5";
            this.chkbox_rep5.UseVisualStyleBackColor = true;
            this.chkbox_rep5.Click += new System.EventHandler(this.chkbox_rep1_Click);
            // 
            // chkbox_rep2
            // 
            this.chkbox_rep2.AutoSize = true;
            this.chkbox_rep2.Location = new System.Drawing.Point(19, 73);
            this.chkbox_rep2.Name = "chkbox_rep2";
            this.chkbox_rep2.Size = new System.Drawing.Size(78, 17);
            this.chkbox_rep2.TabIndex = 3;
            this.chkbox_rep2.Text = "Réponse 2";
            this.chkbox_rep2.UseVisualStyleBackColor = true;
            this.chkbox_rep2.Click += new System.EventHandler(this.chkbox_rep1_Click);
            // 
            // chkbox_rep3
            // 
            this.chkbox_rep3.AutoSize = true;
            this.chkbox_rep3.Location = new System.Drawing.Point(19, 109);
            this.chkbox_rep3.Name = "chkbox_rep3";
            this.chkbox_rep3.Size = new System.Drawing.Size(78, 17);
            this.chkbox_rep3.TabIndex = 2;
            this.chkbox_rep3.Text = "Réponse 3";
            this.chkbox_rep3.UseVisualStyleBackColor = true;
            this.chkbox_rep3.Click += new System.EventHandler(this.chkbox_rep1_Click);
            // 
            // chkbox_rep4
            // 
            this.chkbox_rep4.AutoSize = true;
            this.chkbox_rep4.Location = new System.Drawing.Point(19, 145);
            this.chkbox_rep4.Name = "chkbox_rep4";
            this.chkbox_rep4.Size = new System.Drawing.Size(81, 17);
            this.chkbox_rep4.TabIndex = 1;
            this.chkbox_rep4.Text = "Réponse 4 ";
            this.chkbox_rep4.UseVisualStyleBackColor = true;
            this.chkbox_rep4.Click += new System.EventHandler(this.chkbox_rep1_Click);
            // 
            // chkbox_rep1
            // 
            this.chkbox_rep1.AutoSize = true;
            this.chkbox_rep1.Location = new System.Drawing.Point(19, 40);
            this.chkbox_rep1.Name = "chkbox_rep1";
            this.chkbox_rep1.Size = new System.Drawing.Size(78, 17);
            this.chkbox_rep1.TabIndex = 0;
            this.chkbox_rep1.Text = "Réponse 1";
            this.chkbox_rep1.UseVisualStyleBackColor = true;
            this.chkbox_rep1.Click += new System.EventHandler(this.chkbox_rep1_Click);
            // 
            // but_validation
            // 
            this.but_validation.Location = new System.Drawing.Point(406, 460);
            this.but_validation.Name = "but_validation";
            this.but_validation.Size = new System.Drawing.Size(94, 27);
            this.but_validation.TabIndex = 13;
            this.but_validation.Text = "Valider";
            this.but_validation.UseVisualStyleBackColor = true;
            this.but_validation.Click += new System.EventHandler(this.but_validation_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtbox_joueur
            // 
            this.txtbox_joueur.Enabled = false;
            this.txtbox_joueur.Location = new System.Drawing.Point(714, 435);
            this.txtbox_joueur.Name = "txtbox_joueur";
            this.txtbox_joueur.Size = new System.Drawing.Size(178, 20);
            this.txtbox_joueur.TabIndex = 15;
            // 
            // txtbox_difficulte
            // 
            this.txtbox_difficulte.Enabled = false;
            this.txtbox_difficulte.Location = new System.Drawing.Point(714, 493);
            this.txtbox_difficulte.Name = "txtbox_difficulte";
            this.txtbox_difficulte.Size = new System.Drawing.Size(178, 20);
            this.txtbox_difficulte.TabIndex = 16;
            // 
            // lbl_joueur
            // 
            this.lbl_joueur.AutoSize = true;
            this.lbl_joueur.Location = new System.Drawing.Point(711, 406);
            this.lbl_joueur.Name = "lbl_joueur";
            this.lbl_joueur.Size = new System.Drawing.Size(39, 13);
            this.lbl_joueur.TabIndex = 17;
            this.lbl_joueur.Text = "Joueur";
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(711, 477);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 18;
            this.lbl_difficulte.Text = "Difficulté";
            // 
            // prgBar_timer
            // 
            this.prgBar_timer.Location = new System.Drawing.Point(714, 255);
            this.prgBar_timer.Maximum = 15;
            this.prgBar_timer.Name = "prgBar_timer";
            this.prgBar_timer.Size = new System.Drawing.Size(178, 23);
            this.prgBar_timer.TabIndex = 19;
            // 
            // picbox_img
            // 
            this.picbox_img.Image = global::QuizzAndTest.Properties.Resources.Interrogation;
            this.picbox_img.Location = new System.Drawing.Point(714, 78);
            this.picbox_img.Name = "picbox_img";
            this.picbox_img.Size = new System.Drawing.Size(178, 161);
            this.picbox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_img.TabIndex = 11;
            this.picbox_img.TabStop = false;
            // 
            // but_leave
            // 
            this.but_leave.BackColor = System.Drawing.Color.Red;
            this.but_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_leave.ForeColor = System.Drawing.Color.Black;
            this.but_leave.Location = new System.Drawing.Point(922, 12);
            this.but_leave.Name = "but_leave";
            this.but_leave.Size = new System.Drawing.Size(50, 50);
            this.but_leave.TabIndex = 20;
            this.but_leave.Text = "❌";
            this.but_leave.UseVisualStyleBackColor = false;
            this.but_leave.Click += new System.EventHandler(this.but_leave_Click);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 535);
            this.Controls.Add(this.but_leave);
            this.Controls.Add(this.prgBar_timer);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.lbl_joueur);
            this.Controls.Add(this.txtbox_difficulte);
            this.Controls.Add(this.txtbox_joueur);
            this.Controls.Add(this.but_validation);
            this.Controls.Add(this.grpbox_rep);
            this.Controls.Add(this.picbox_img);
            this.Controls.Add(this.txtbox_tempstot);
            this.Controls.Add(this.txtbox_question);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_tempstot);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.lbl_quizz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jeu";
            this.grpbox_rep.ResumeLayout(false);
            this.grpbox_rep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_quizz;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Label lbl_tempstot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_question;
        private System.Windows.Forms.TextBox txtbox_tempstot;
        private System.Windows.Forms.PictureBox picbox_img;
        private System.Windows.Forms.GroupBox grpbox_rep;
        private System.Windows.Forms.CheckBox chkbox_rep5;
        private System.Windows.Forms.CheckBox chkbox_rep2;
        private System.Windows.Forms.CheckBox chkbox_rep3;
        private System.Windows.Forms.CheckBox chkbox_rep4;
        private System.Windows.Forms.CheckBox chkbox_rep1;
        private System.Windows.Forms.Button but_validation;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.Label lbl_joueur;
        private System.Windows.Forms.TextBox txtbox_difficulte;
        private System.Windows.Forms.TextBox txtbox_joueur;
        private System.Windows.Forms.ProgressBar prgBar_timer;
        private System.Windows.Forms.Button but_leave;
    }
}