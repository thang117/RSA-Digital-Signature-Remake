using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Signature_RemakeV1
{
    public partial class frStart : Form
    {
        public frStart()
        {
            InitializeComponent();
        }

        private void btnCreateFrom_Click(object sender, EventArgs e)
        {
            frCreateSignature f1 = new frCreateSignature();
            this.Visible = false;
            f1.ShowDialog();
            this.Visible = true;
        }

        private void btnVertificationFrom_Click(object sender, EventArgs e)
        {
            frVertification f2 = new frVertification();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAuthor f4 = new frAuthor();
            f4.ShowDialog();
        }

        private void digitalSignatureCreationProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProcess f5 = new frProcess();
            f5.ShowDialog();
        }

        private void appInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAppInformation f6 = new frAppInformation();
            f6.ShowDialog();
        }
    }
}
