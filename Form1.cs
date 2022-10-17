using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindowsKontrola
{
    public partial class FormaProgram : Form
    {
        public FormaProgram()
        {
            InitializeComponent();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme", "Obavještenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText text = new FormaText();
            text.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeste li sigurni da želite zatvoriti iz aplikacije?", "Potvrda", MessageBoxButtons.YesNo);
        }

        private void cmbProgrami_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProgrami.SelectedIndex = 1)
            {

            }
        }
    }
}
