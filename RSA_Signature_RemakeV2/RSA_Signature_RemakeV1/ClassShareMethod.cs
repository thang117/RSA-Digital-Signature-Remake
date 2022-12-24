using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Signature_RemakeV1
{
    public class ClassShareMethod
    {
        public static void RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {
            try
            {
                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read); //Đọc file input
                FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write); //Tạo file output
                fsCiperText.SetLength(0);
                byte[] bin, encryptedData;
                long rdlen = 0;
                long totlen = fsInput.Length;
                int len;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.ImportParameters(RSAKeyInfo); //Nhập thông tin khoá RSA (bao gồm khoá riêng)

                int maxBytesCanEncrypted;
                //RSA chỉ có thể mã hóa các khối dữ liệu ngắn hơn độ dài khóa, chia dữ liệu cho một số khối và sau đó mã hóa từng khối và sau đó hợp nhất chúng
                if (isEncrypt)
                    maxBytesCanEncrypted = ((RSA.KeySize - 384) / 8) + 37;      // + 7: OAEP - Đệm mã hóa bất đối xứng tối ưu
                else
                    maxBytesCanEncrypted = (RSA.KeySize / 8);
                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    if (totlen - rdlen < maxBytesCanEncrypted)
                    {
                        maxBytesCanEncrypted = (int)(totlen - rdlen);
                    }
                    bin = new byte[maxBytesCanEncrypted];
                    len = fsInput.Read(bin, 0, maxBytesCanEncrypted);

                    if (isEncrypt) encryptedData = RSA.Encrypt(bin, false); //Mã Hoá
                    else encryptedData = RSA.Decrypt(bin, false); //Giải mã

                    fsCiperText.Write(encryptedData, 0, encryptedData.Length);
                    rdlen = rdlen + len;

                }

                fsCiperText.Close(); //save file
                fsInput.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }
        public static string SHA256(string path)                         //hàm băm SHA256
        {
            try
            {
                using (FileStream stream = File.OpenRead(path))           //tiến hành băm dữ liệu từ đường dẫn
                {
                    SHA256Managed sha = new SHA256Managed();
                    byte[] hash = sha.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", String.Empty);
                }
            }
            catch
            {
                MessageBox.Show("Path file error!");
                return "";
            }
        }
        public static void xoaHash(string filePath)
        //hàm xoá file hash lưu trữ
        {
            if (File.Exists(filePath))
            {
                // Xóa file
                System.IO.File.WriteAllText(filePath, "");
            }
        }
    }
}
