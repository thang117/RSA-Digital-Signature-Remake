using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Signature_RemakeV1
{
    public partial class frNameForSignature : Form
    {
        private string strNameSignature;

        private string pathDesktop;

        private string pathDir;
        public frNameForSignature()
        {
            InitializeComponent();
        }

        public string StrNameSignature
        {
            get { return strNameSignature; } 
            set { strNameSignature = value; } 
        }

        public string PathDesktop 
        {
            get { return pathDesktop; }
            set { pathDesktop = value; }
        }

        public string PathDir 
        {
            get { return pathDir; }
            set { pathDir = value; }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbNameSignature.TextLength != 0)
            {
                pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // lấy đường dẫn desktop|| C:\Users\[current user name]\Desktop
                pathDir = Path.Combine(pathDesktop, tbNameSignature.Text);
                while(Directory.Exists(pathDir))
                {
                    MessageBox.Show("This name has really exist in this desktop!");                   
                    pathDir = Path.Combine(pathDesktop, tbNameSignature.Text);
                    return;
                }
                StrNameSignature = tbNameSignature.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter folder name!");
            }    
        }

        private void frNameForSignature_Load(object sender, EventArgs e)
        {

        }
    }
}
