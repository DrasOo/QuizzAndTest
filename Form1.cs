using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo_difficult.Items.AddRange(new string[] { "Facile", "Moyen", "Difficile", "Enfer" });
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            while (txt_nom.Text != "" && txt_prenom.Text != "" && combo_difficult.SelectedIndex >= 1 && combo_difficult.SelectedIndex <= 4)
            {
                MessageBox.Show("Bienvenue et bon jeu!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            /*else
            {
                if (txt_nom.Text != "")
                {
                    MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_prenom.Text != "")
                {
                    MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Aucun nom ou prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combo_difficult_Click(object sender, EventArgs e)
        {
            if (combo_difficult.SelectedItem.ToString() == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_difficult.Font = new Font(lbl_difficult.Font, FontStyle.Bold);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_difficult.Font = new Font(lbl_difficult.Font, FontStyle.Regular);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
            }
        }

        
    }
}
