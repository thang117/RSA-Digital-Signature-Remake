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
    public partial class frCreateSignature : Form
    {
        public frCreateSignature()
        {
            InitializeComponent();
        }

        #region Declare
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();      // khai báo thư viện RSA
        string pathKeysXMLPrivate = "";                                     //đường dẫn khoá bí mật
        string pathKeysXMLPublic = "";                                  //đường dẫn khoá công khai
        string pathSignatureEnCrypt = "";                         //đường dẫn chữ ký số
        string nameFolderSignature = "";
        String pathKeyRSApublic = "";
        String pathKeyRSAPrivate = "";
        string pathDir = "";
        string getfilePathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // lấy đường dẫn desktop|| C:\Users\[current user name]\Desktop
        private void frCreateSignature_Load(object sender, EventArgs e)
        {
            //tạo option cho combobox độ dài key (tuỳ chọn xổ xuống)
            cbbSizeKey.Items.Add("512 bits");
            cbbSizeKey.Items.Add("1024 bits");
            cbbSizeKey.Items.Add("2048 bits");
            cbbSizeKey.Items.Add("4096 bits");
            cbbSizeKey.Text = "1024 bits";         //mặc định là 1024 bits
            tbInputDataPath.Clear();
            getfilePathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // lấy đường dẫn desktop|| C:\Users\[current user name]\Desktop
            btnGoToFile1.Enabled = false;

        }
   
        #endregion

        #region Method     
        public void CreateKey(string path) 
        {
            #region Tạo file lưu khoá bí mật
            // Tạo file chứa khoá bí mật
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = path + "\\PrivateKey.xml";      
            saveFileDialog1.RestoreDirectory = true;
            pathKeyRSAPrivate = saveFileDialog1.FileName;   //pathkeyRSAPrivate giữ đường dẫn file khoá bí mật
            #endregion

            #region Tạo file lưu khoá công khai
            //tạo file chứa khoá công khai
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.FileName = path + "\\PublicKey.xml";
            saveFileDialog2.RestoreDirectory = true;
            pathKeyRSApublic = saveFileDialog2.FileName; //pathKeyRSApublic giữ đường dẫn file khoá công khai
            #endregion


            #region Tạo khoá bằng thư viện RSA
            //lấy giá trị độ dài key
            int lengthKey = 0;
            if (this.cbbSizeKey.Text == "1024 bits") lengthKey = 1024;
            else if (this.cbbSizeKey.Text == "512 bits") lengthKey = 512;
            else if (this.cbbSizeKey.Text == "2048 bits") lengthKey = 2048;
            else if (this.cbbSizeKey.Text == "4096 bits") lengthKey = 4096;

            //tạo key có độ dài lengthKey
            RSA = new RSACryptoServiceProvider(lengthKey);

            // Lưu khoá bí mật vào đường dẫn pathKeyRSA
            File.WriteAllText(pathKeyRSApublic, RSA.ToXmlString(true)); // đối với RSA, mã hoá bằng public key=(RSA.ToXmlString(false)), giải mã bằng private=(RSA.ToXmlString(true))
                                                                        // nhưng đây là chữ ký số mã hoá bằng private, giải mã bằng publicKey nên chức năng của 2 khoá sẽ ngược lại
                                                                        // suy ra chung ta sẽ tạo khoá công khai của RSA (RSA.ToXmlString(flase))  để mã hoá chữ ký
                                                                        // và chúng ta tạo khoá bí mật của RSA (RSA.ToXmlString(true)) để giải mã chữ ký
                                                                        // Lưu khoá bí mật vào đường dẫn pathKeyRSApublic
            File.WriteAllText(pathKeyRSAPrivate, RSA.ToXmlString(false));
            #endregion

        }

       
        private void ReadKeyFormFileXml()
        {
            #region read Private key
            pathKeysXMLPrivate = pathKeyRSAPrivate;
            if (File.Exists(pathKeysXMLPrivate))
            {
                if (Path.GetExtension(pathKeysXMLPrivate) == ".xml") //kiểm tra định dạng
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXMLPrivate)); //đọc khoá bí mật
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue");
                    }
                    catch
                    {
                        MessageBox.Show("Fail to read Private key ");
                    }
                }
            }
            #endregion

            #region Read Public Key
            //đọc file xml khoá công khai
            pathKeysXMLPublic = pathKeyRSApublic;
            if (File.Exists(pathKeysXMLPublic))
            {
                if (Path.GetExtension(pathKeysXMLPublic) == ".xml") //kiểm tra định dạng
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXMLPublic)); //đọc khoá công khai
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue");                     
                    }
                    catch
                    {
                        MessageBox.Show("Fail to read Public key");
                    }
                }
            }
            #endregion
        }

        private void Encrypt(string path)
        {          
            try
            {


                string inputFileName = "hash.txt",   // chuỗi inputFileName lưu giá trị của chuỗi băm hash
                    outputFileName = "";          // chuỗi outputFileName dùng để tạo đường dẫn              

                outputFileName = pathSignatureEnCrypt + "\\" + Path.GetFileName(tbInputDataPath.Text) + ".qvst";   //tạo file chữ ký có tên là file_gốc.qvst tạo đường dẫn thư mục lưu chữ ký

                //get Keys.

                RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(File.ReadAllText(this.pathKeysXMLPrivate));       //chuẩn bị mã hoá sử dụng đường dẫn đến khoá bí mật, dùng hàm đọc all file xml

                ClassShareMethod.RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(false), true);                         //gọi hàm xử lý RSA

              
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        private void zipFileSignature(string path)
        {
            #region nén vào một thư mục

            //công đoạn nén file
            // sơ đồ thư mục lưu trữ: desktop\Folder\signature\
            //trong đó:
            //      folder là thư mục do người dùng tạo chứa thư mục signature 
            //      thư mục signature là thư mục được tạo tự động, là thư mục con nằm trong vị trí được chọn, chứa file inputcopy
            //      thư mục signature.zip là thư mục được tạo tự động, là thư mục con của signature, cùng cấp với file inputcopy, chứa file khoá công khai copy và file chữ ký copy, đây cũng là thư mục được nén zip có pass


            string folderArchive = path;


            //tạo thư mục con tại vị trí đã chọn để lưu file input, thư mục signature (gồm chữ ký và khoá công khai) và signature.zip
            // 1. Đường dẫn tới thư mục cần tạo 
            string path1 = folderArchive + "\\Signature\\";

            // 2.Khai báo một thể hiện của lớp DirectoryInfo
            DirectoryInfo directory1 = new DirectoryInfo(path1);

            // Kiểm tra thư mục chưa tồn tại mới sử dụng phương thức tạo
            if (!directory1.Exists)
            {
                // 3.Sử dụng phương thức Create để tạo thư mục.
                directory1.Create();
            }
            else
            {
                directory1.Delete(true);
                directory1.Create();
            }

            string duongDanInput = tbInputDataPath.Text;                                                                   //tạo biến lưu đường dẫn đến input để copy
            string duongDanChuKy = pathSignatureEnCrypt + "\\" + Path.GetFileName(tbInputDataPath.Text) + ".qvst";
            string duongDanKhoaCongKhai = pathKeysXMLPublic;


            string tenInput = Path.GetFileName(tbInputDataPath.Text);                                                     //tạo biến lưu tên file input
            string tenChuKy = Path.GetFileName(tbInputDataPath.Text + ".qvst");                                                     //tạo biến lưu tên file input
            string tenKhoaCongKhai = Path.GetFileName(pathKeysXMLPublic);                                                     //tạo biến lưu tên file input


            File.Copy(duongDanInput, folderArchive + "\\Signature\\" + tenInput, true);                        //copy file input vào thư mục
            File.Move(duongDanChuKy, folderArchive + "\\Signature\\" + tenChuKy, true);       //move file chữ ký vào thư mục Signature của thư mục đã chọn 
            File.Copy(duongDanKhoaCongKhai, folderArchive + "\\Signature\\" + tenKhoaCongKhai, true);          //copy file khoá công khai vào thư mục con secretSignature của thư mục đã chọn 


            string pathFolderinput = folderArchive + "\\Signature";
            string pathFolderoutput = folderArchive + "\\Signature.zip";
            if (File.Exists(pathFolderoutput))
            {
                File.Delete(pathFolderoutput);
            }

            //CreateSample(folderArchive + "\\signature\\secret.zip", "P@ssw0rdC@nnOtbeKn@w4cr3ck", folderArchive + "\\signature\\secret");           // tạo 1 thư mục con secret trong thư mục đã chọn, sau đó nén thư mục secret
            ZipFile.CreateFromDirectory(pathFolderinput, pathFolderoutput);           // tạo 1 thư mục con signature trong thư mục đã chọn, sau đó nén thư mục lai

            Directory.Delete(pathFolderinput, true);

            MessageBox.Show("Success created digital signature at the path " + pathSignatureEnCrypt, "Confirm");

            
            #endregion

        }
        #endregion

        #region Event
        private void btnGoVertificationFrom_Click(object sender, EventArgs e)
        {
            frVertification f1 = new frVertification();
            this.Visible = false;
            f1.ShowDialog();
            this.Visible = true;
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            frStart f0 = new frStart();
            this.Visible = false;
            f0.ShowDialog();
            this.Visible = true;
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbInputDataPath.Text = dialog.FileName;            //tbInput.Text giữ đường dẫn dẫn tới file cần băm  
                }
            }
            btnImportData.Enabled = false;
        }
        private void btnCreateSignature_Click(object sender, EventArgs e)
        {
            if(tbInputDataPath.TextLength!=0)
            {
                ClassShareMethod.xoaHash("hash.txt");
                System.IO.File.WriteAllText("hash.txt", ClassShareMethod.SHA256(tbInputDataPath.Text)); // xuất ra file hash.txt chứ dữ liệu đã được hash

                frNameForSignature f3 = new frNameForSignature();
                f3.ShowDialog();
                nameFolderSignature = f3.StrNameSignature;// lấy tên folder

                pathDir = Path.Combine(getfilePathDesktop, nameFolderSignature);
                Directory.CreateDirectory(pathDir);

                CreateKey(pathDir);

                ReadKeyFormFileXml();

                pathSignatureEnCrypt = pathDir;

                Encrypt(pathDir);

                zipFileSignature(pathDir);

                btnGoToFile1.Enabled = true;
                btnCreateSignature.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please input data!","Warning");
            }

        }



        #endregion

        private void btnGoToFile1_Click(object sender, EventArgs e)
        {
            if(tbInputDataPath.TextLength!=0)
            {
                var process = new System.Diagnostics.Process();

                process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = pathDir };

                process.Start();
            }
            else
            {
                MessageBox.Show("No Signature have been create!","Warning");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbInputDataPath.Clear();
            btnGoToFile1.Enabled = false;
            btnCreateSignature.Enabled = true;
            btnImportData.Enabled = true;
        }
    }
}
