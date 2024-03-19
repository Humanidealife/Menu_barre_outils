using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_barre_outils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouvrir");
        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A propos de cette application");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void jauneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tâche terminée";
            toolStripProgressBar1.Value = 56;
        }

        private void choix1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exellent choix");
        }
    }
}
