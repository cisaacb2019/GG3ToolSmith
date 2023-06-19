using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GG3GrblProbe
{
    public partial class AnyCrypt : Form
    {
        private string filePath;
        private bool isEncryptionMode;
        private byte[] defaultSalt = Encoding.UTF8.GetBytes("DEFAULT SALT");

        public AnyCrypt()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            isEncryptionMode = true;
            PromptFileAndProceed();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            isEncryptionMode = false;
            PromptFileAndProceed();
        }

        private void PromptFileAndProceed()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Filter = "DD Files|*.dd";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                string prompt = isEncryptionMode ? "Enter password to encrypt:" : "Enter password to decrypt:";
                string password = PromptPassword(prompt);

                if (!string.IsNullOrEmpty(password))
                {
                    string salt = PromptSalt("Enter salt value (leave empty for default):");

                    byte[] saltBytes = string.IsNullOrEmpty(salt) ? defaultSalt : Encoding.UTF8.GetBytes(salt);

                    try
                    {
                        if (isEncryptionMode)
                        {
                            byte[] encryptedBytes = EncryptFileToBytes(filePath, password, saltBytes);

                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Title = "Save encrypted file";
                            saveFileDialog.Filter = "All Files|*.*";
                            saveFileDialog.FileName = "Encrypted" + Path.GetFileNameWithoutExtension(filePath) + ".dd";
                            saveFileDialog.RestoreDirectory = true;

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllBytes(saveFileDialog.FileName, encryptedBytes);
                                MessageBox.Show("File encrypted successfully!", "Encryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            byte[] encryptedBytes = File.ReadAllBytes(filePath);
                            byte[] decryptedBytes = DecryptBytesToBytes(encryptedBytes, password, saltBytes);

                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Title = "Save decrypted file";
                            saveFileDialog.Filter = "All Files|*.*";
                            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(filePath) + ".dd";
                            saveFileDialog.RestoreDirectory = true;

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllBytes(saveFileDialog.FileName, decryptedBytes);
                                MessageBox.Show("File decrypted successfully!", "Decryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = isEncryptionMode ? "Encryption failed" : "Decryption failed";
                        MessageBox.Show($"{errorMessage}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string PromptPassword(string prompt)
        {
            string password = string.Empty;

            while (string.IsNullOrEmpty(password))
            {
                password = Microsoft.VisualBasic.Interaction.InputBox(prompt, "Enter Password");
            }

            return password;
        }

        private string PromptSalt(string prompt)
        {
            string salt = Microsoft.VisualBasic.Interaction.InputBox(prompt, "Enter Salt");
            return salt;
        }

        private byte[] EncryptFileToBytes(string filePath, string password, byte[] salt)
        {
            byte[] encrypted;

            using (AesManaged aes = new AesManaged())
            {
                aes.KeySize = 256; // Set key size to 256 bits
                aes.BlockSize = 128; // Set block size to 128 bits
                aes.Key = DeriveKeyFromPassword(password, aes.KeySize / 8, salt);
                aes.IV = new byte[16]; // Use a random IV for simplicity. Don't do this in production!

                aes.Mode = CipherMode.CBC; // Use CBC mode
                aes.Padding = PaddingMode.PKCS7; // Use PKCS7 padding

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            fileStream.CopyTo(cs);
                        }
                    }

                    encrypted = ms.ToArray();
                }
            }

            return encrypted;
        }

        private byte[] DecryptBytesToBytes(byte[] cipherText, string password, byte[] salt)
        {
            byte[] decrypted;

            using (AesManaged aes = new AesManaged())
            {
                aes.KeySize = 256; // Set key size to 256 bits
                aes.BlockSize = 128; // Set block size to 128 bits
                aes.Key = DeriveKeyFromPassword(password, aes.KeySize / 8, salt);
                aes.IV = new byte[16]; // Use the same IV used during encryption. Don't do this in production!

                aes.Mode = CipherMode.CBC; // Use CBC mode
                aes.Padding = PaddingMode.PKCS7; // Use PKCS7 padding

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream outputMs = new MemoryStream())
                        {
                            cs.CopyTo(outputMs);
                            decrypted = outputMs.ToArray();
                        }
                    }
                }
            }

            return decrypted;
        }

        private byte[] DeriveKeyFromPassword(string password, int keySize, byte[] salt)
        {
            using (Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, salt))
            {
                return deriveBytes.GetBytes(keySize);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}