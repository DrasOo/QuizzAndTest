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
    public partial class Donnees : Form
    {
        public Donnees()
        {
            InitializeComponent();
        }

        private void but_leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
