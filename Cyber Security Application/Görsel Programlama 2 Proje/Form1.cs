using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Görsel_Programlama_2_Proje
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMaterialSkin();
            InitializeAlgorithms();
        }

        private int viruses = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            materialButton6.Hide();
            materialButton5.Hide();
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900, Primary.Grey200, Accent.Red700, TextShade.WHITE);
            this.BackColor = Color.FromArgb(150, 150, 150); // Açık gri tonu (RGB: 150, 150, 150)
            materialProgressBar1.BackColor = Color.White;

        }

        private void StartBackgroundWorker()
        {
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }
        public enum PasswordStrength
        {
            VeryWeak,
            Weak,
            Medium,
            Strong,
            VeryStrong
        }

        private string GenerateStrongPassword()
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*()-_=+[]{};:'\"\\|,<.>/?";
            var random = new Random();

            var passwordChars = new List<char>();
            passwordChars.Add(upper[random.Next(upper.Length)]);
            passwordChars.Add(lower[random.Next(lower.Length)]);
            passwordChars.Add(digits[random.Next(digits.Length)]);
            passwordChars.Add(special[random.Next(special.Length)]);

            for (int i = 0; i < 8; i++)
            {
                string allChars = upper + lower + digits + special;
                passwordChars.Add(allChars[random.Next(allChars.Length)]);
            }

            return new string(passwordChars.OrderBy(x => random.Next()).ToArray());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string suggestedPassword = GenerateStrongPassword();
            materialTextBox1.Text = suggestedPassword;
        }
        private PasswordStrength CheckPasswordStrength(string password)
        {
            if (password.Length < 8)
            {
                return PasswordStrength.VeryWeak;
            }

            int score = 0;

            if (password.Any(char.IsUpper))
                score++;
            if (password.Any(char.IsLower))
                score++;
            if (password.Any(char.IsDigit))
                score++;
            if (password.Any(c => "!@#$%^&*()-_=+[]{};:'\"\\|,<.>/?".Contains(c)))
                score++;

            switch (score)
            {
                case 1:
                    return PasswordStrength.Weak;
                case 2:
                    return PasswordStrength.Medium;
                case 3:
                    return PasswordStrength.Strong;
                case 4:
                    return PasswordStrength.VeryStrong;
                default:
                    return PasswordStrength.VeryWeak;
            }
        }
        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {
            string password = materialTextBox2.Text;

            PasswordStrength strength = CheckPasswordStrength(password);

            string strengthMessage;
            Color strengthColor;

            switch (strength)
            {
                case PasswordStrength.VeryWeak:
                    strengthMessage = "Very weak password!";
                    strengthColor = Color.Red;
                    break;
                case PasswordStrength.Weak:
                    strengthMessage = "Weak password!";
                    strengthColor = Color.Orange;
                    break;
                case PasswordStrength.Medium:
                    strengthMessage = "Medium password!";
                    strengthColor = Color.Yellow;
                    break;
                case PasswordStrength.Strong:
                    strengthMessage = "Strong password!";
                    strengthColor = Color.Green;
                    break;
                case PasswordStrength.VeryStrong:
                    strengthMessage = "Very strong password!";
                    strengthColor = Color.Blue;
                    break;
                default:
                    strengthMessage = "Unknown strength";
                    strengthColor = Color.Black;
                    break;
            }

            materialLabel9.Text = strengthMessage;
            materialLabel9.ForeColor = strengthColor;
        }
        private void InitializeAlgorithms()
        {
            materialComboBox1.Items.Add("AES");
            materialComboBox1.Items.Add("DES");
            materialComboBox1.Items.Add("RSA");
        }
        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            string inputText = materialTextBox3.Text;
            string algorithm = materialComboBox1.SelectedItem?.ToString(); // Use null-conditional operator
            string result = "";

            if (string.IsNullOrEmpty(algorithm))
            {
                MessageBox.Show("Please choose an algorithm!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (algorithm)
            {
                case "AES":
                    result = EncryptAES(inputText);
                    break;
                case "DES":
                    result = EncryptDES(inputText);
                    break;
                case "RSA":
                    result = EncryptRSA(inputText);
                    break;
            }

            materialTextBox4.Text = result;
            StartBackgroundWorker();
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(100);
        }
        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            materialProgressBar1.Value = e.ProgressPercentage;
        }
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }
        private string EncryptAES(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedBytes;
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
                return Convert.ToBase64String(encryptedBytes);
            }
        }
        private string EncryptDES(string input)
        {
            string key = "01234567";
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] iv = new byte[8];

            using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
            {
                desAlg.Key = keyBytes;
                desAlg.IV = iv;

                ICryptoTransform encryptor = desAlg.CreateEncryptor(desAlg.Key, desAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                        byte[] encryptedBytes = msEncrypt.ToArray();
                        return Convert.ToBase64String(encryptedBytes);
                    }
                }
            }
        }
        private string EncryptRSA(string input)
        {
            using (RSACryptoServiceProvider rsaAlg = new RSACryptoServiceProvider())
            {
                string publicKey = rsaAlg.ToXmlString(false);

                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] encryptedBytes = rsaAlg.Encrypt(inputBytes, false);

                return Convert.ToBase64String(encryptedBytes);
            }
        }

        private void materialButton4_Click(object sender, EventArgs e) //SCAN FOLDER
        {
            folderBrowserDialog1.ShowDialog();
            materialLabel7.Text = "Selected Location : " + folderBrowserDialog1.SelectedPath;
            viruses = 0;
            progressBar1.Value = 0;
            materialListBox2.Items.Clear();
            materialButton5.Show();
        }
        private void materialButton5_Click(object sender, EventArgs e) // scan
        {
            string[] search = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "."); // düzeltildi
            progressBar1.Maximum = search.Length;
            foreach (string item in search)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();
                    string[] virus = new string[] { "SUBSCRIBE", "LIKE", "COMMENT" };
                    foreach (string st in virus)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            viruses += 1;
                            var listItem = new MaterialSkin.MaterialListBoxItem(item); // item öğesini dönüştür
                            materialListBox2.Items.Add(listItem);
                            materialButton6.Show();
                            materialLabel8.Text = "Detected : " + viruses.ToString();
                        }
                        progressBar1.Increment(1);
                    }
                }
                catch
                {
                    string read = item;
                    string[] virus = new string[] { "VIRUSES", "INFECTED", "HACKED" };
                    foreach (string st in virus)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            viruses += 1;
                            var listItem = new MaterialSkin.MaterialListBoxItem(item); // item öğesini dönüştür
                            materialListBox2.Items.Add(listItem);
                            materialButton6.Show();
                            materialLabel8.Text = "Detected : " + viruses.ToString();
                        }
                        progressBar1.Increment(1);
                    }
                }
            }
        }
        private void materialButton6_Click(object sender, EventArgs e) // REMOVE
        {
            if (materialListBox2.SelectedItem != null)
            {
                // Seçilen öğeyi MaterialListBoxItem olarak al
                var selectedItem = (MaterialListBoxItem)materialListBox2.SelectedItem;
                string filePath = selectedItem.Text; // Dosya yolunu al

                try
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(filePath); // Dosyayı sil
                    materialListBox2.Items.Remove(selectedItem); // ListBox'tan öğeyi kaldır
                    MessageBox.Show("Selected Malware Successfully Removed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                materialButton9.Text = openFileDialog.FileName;
            }
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            string filePath = materialButton9.Text;
            string password = materialTextBox6.Text; // Şifre metin kutusundan alınacak

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte[] salt = GenerateSalt();

                using (RijndaelManaged rijndael = new RijndaelManaged())
                {
                    rijndael.GenerateIV();
                    rijndael.Key = GenerateKey(password, salt);
                    rijndael.Mode = CipherMode.CBC;

                    using (FileStream inputFileStream = new FileStream(filePath, FileMode.Open))
                    using (FileStream outputFileStream = new FileStream(filePath + ".encrypted", FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        outputFileStream.Write(salt, 0, salt.Length);

                        // Dosyanın içeriğini şifreleyerek kopyala
                        inputFileStream.CopyTo(cryptoStream);
                    }
                }

                // Şifrelenmiş dosya adını veritabanına kaydet
                SaveToFileDatabase(Path.GetFileName(filePath), password);

                MessageBox.Show("File encrypted and saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while encrypting the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        private byte[] GenerateKey(string password, byte[] salt)
        {
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(password, salt, 10000);
            return rfc2898.GetBytes(32);
        }

        private void SaveToFileDatabase(string fileName, string password)
        {
            string connectionString = "Data Source=DESKTOP-JJFORKS\\SQLEXPRESS;Initial Catalog=\"Encrypted Files\";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Veritabanı komutunu oluştur
                string query = "INSERT INTO EncryptedFiles (File_Name, Encrypted_Password) VALUES (@FileName, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@Password", password);

                    // Bağlantıyı aç ve komutu çalıştır
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

