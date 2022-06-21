using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Numerics;
using System.Xml;
using System.Diagnostics;

using System.IO.Compression;

namespace RSA_Signature_RemakeV1
{
    public partial class frVertification : Form
    {
        public frVertification()
        {
            InitializeComponent();
        }
        #region Declare
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();      // khai báo thư viện RSA

        String pathKeyRSApublic = "";                         //đường dẫn khoá công khai để giải mã
        string pathSignatureExtract = "";
        string pathFileData = "";
        string nameFileSignature = "";
        string getPathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // lấy đường dẫn desktop|| C:\Users\[current user name]\Desktop
        string pathFolderExtract = "";
        string extractPath = "";

        private void frVertification_Load(object sender, EventArgs e)
        {
            tbInputSignaturePath.Clear();
            lbVertification.Text = "No data to verify";
            lbVertification.ForeColor = System.Drawing.Color.Blue;
            rdbDesktop.Checked = true;
            btnGoToFile2.Enabled = false;
            btnVertificationSignature.Enabled = true;
        }


        #endregion



        #region Method

        private void ReadSignatureZipFile(string path)
        {
            string  zipPath = "";

            OpenFileDialog op = new OpenFileDialog();
            //op.Filter = "ALL File (*.rar)|*.rar|(*.zip)|*.zip" ;
            if (op.ShowDialog() == DialogResult.OK)
            {
                zipPath = op.FileName;
                tbInputSignaturePath.Text = zipPath;
                extractPath = Path.Combine(path, "SignatureExtract");
                DirectoryInfo directory1 = new DirectoryInfo(extractPath);
                for (int i = 1; i < 100; i++)
                {
                    if (directory1.Exists)
                    {
                        extractPath = Path.Combine(path, "SignatureExtract"+i);// nếu thư mục đã tồn tại thì tạo thêm thư mục+1
                        directory1 = new DirectoryInfo(extractPath);
                    }
                }
               

                directory1.Create();

                #region Unzip
                
                try
                {
                    using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            Console.WriteLine("Found: " + entry.FullName);

                            // Tìm kiếm các Entry có đuôi .xml
                            if (entry.FullName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))// tim file khóa.xml
                            {
                                string entryOutputPath1 = Path.Combine(extractPath, entry.FullName);
                                entry.ExtractToFile(entryOutputPath1, true);
                                #region Nap khóa công khai
                                pathKeyRSApublic = entryOutputPath1;
                                XmlDocument xml = new XmlDocument();
                                xml.LoadXml(File.ReadAllText(pathKeyRSApublic)); //đọc khoá công khai
                                try
                                {
                                    XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue");

                                }
                                catch
                                {
                                    MessageBox.Show("Error input key");
                                }
                                #endregion
                            }
                            else if (entry.FullName.EndsWith(".qvst", StringComparison.OrdinalIgnoreCase))
                            {
                                string entryOutputPath2 = Path.Combine(extractPath, entry.FullName);
                                entry.ExtractToFile(entryOutputPath2, true);                               
                                pathSignatureExtract = entryOutputPath2;
                              
                                nameFileSignature = Convert.ToString(entry.FullName);                             
                            }
                            else //if(entry.FullName.Contains(nameFileSignature) )
                            {
                                string entryOutputPath3 = Path.Combine(extractPath, entry.FullName);
                                entry.ExtractToFile(entryOutputPath3, true);
                                pathFileData = entryOutputPath3;
                            }

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error! The file inserted is not a zip file or not file signature!");
                }
                #endregion
            }
        }

        private void Dencrypt()
        {
            string inputFileName = "", outputFileName = "";
            inputFileName = pathSignatureExtract;
            outputFileName = "hash.txt";// vị trí giải mã chữ ký

            RSA = new RSACryptoServiceProvider();// khởi tao khóa

            RSA.FromXmlString(File.ReadAllText(this.pathKeyRSApublic));//lấy khóa cong khai

            ClassShareMethod.RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), false);//đem vào hàm mã hóa / giải mã

        }

        private void Vertification()
        {
            //string s = ClassShareMethod.SHA256(pathFileData);
            string s1 = Convert.ToString(ClassShareMethod.SHA256(pathFileData));
            string s2 = File.ReadAllText("hash.txt");
            if (String.Compare(s1, s2) == 0)
            {
                lbVertification.Text = "✔️Success! Signature correct!";
                lbVertification.ForeColor = System.Drawing.Color.Green;
                
            }
            else
            {             
                lbVertification.Text = "❌Warning! This signature is incorrect!";
                lbVertification.ForeColor = System.Drawing.Color.Red;
            }
            DirectoryInfo directory1 = new DirectoryInfo("SinatureExtract");

            if (directory1.Exists)
            {
                directory1.Delete(true);
            }
        }

        #endregion

        #region Event
        private void btnGoCreateFrom_Click(object sender, EventArgs e)
        {
            frCreateSignature f2 = new frCreateSignature();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbInputSignaturePath.Clear();
            lbVertification.Text = "No data to verify";
            lbVertification.ForeColor = System.Drawing.Color.Blue;
            btnGoToFile2.Enabled = false;
            btnVertificationSignature.Enabled = true;
        }

        private void btnImportSignature_Click(object sender, EventArgs e)
        {
            ClassShareMethod.xoaHash(pathSignatureExtract);
            if(rdbDesktop.Checked==true)
            {
               
                pathFolderExtract = getPathToDesktop;
                ReadSignatureZipFile(pathFolderExtract);
            }
            else if(rdbElective.Checked==true)
            {

                FolderBrowserDialog op = new FolderBrowserDialog(); //khởi tạo chọn đường dẫn
                MessageBox.Show("Choose locate to save extract file.","Notice");
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pathFolderExtract = op.SelectedPath; //lấy đường dẫn thư mực vừa chọn
                    MessageBox.Show("Choose your signature file.", "Notice");
                    ReadSignatureZipFile(pathFolderExtract);
                }
            }
            
        }

        private void btnVertificationSignature_Click(object sender, EventArgs e)
        {
            if (tbInputSignaturePath.TextLength != 0)
            {
                Dencrypt();

                Vertification();

                btnVertificationSignature.Enabled = false;
                btnGoToFile2.Enabled = true;

            }

            else
            {
                MessageBox.Show("Please input signature!", "Warning");
            }
        }

        #endregion

        private void btnGoToFile2_Click(object sender, EventArgs e)
        {
            if (tbInputSignaturePath.TextLength != 0)
            {
                var process = new System.Diagnostics.Process();

                process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = extractPath };

                process.Start();
            }
            else
            {
                MessageBox.Show("No Signature have been create!", "Warning");
            }
        }
    }
}



