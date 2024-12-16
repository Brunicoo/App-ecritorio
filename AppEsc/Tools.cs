using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace AppEsc
{
    public class Tools
    {
        private static readonly string key = "1234567890123456";
        public static void openNewForm(Form actualForm, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.CenterScreen;

            newForm.Show();
            actualForm.Hide();
        }

        public static void readJsonProjects()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "projects.json");
                string encryptedJson = File.ReadAllText(filePath);
                string decryptedJson = DecryptString(encryptedJson);

                Project.projects = JsonSerializer.Deserialize<List<Project>>(decryptedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }


        public static void readJsonUsers()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");
                string encryptedJson = File.ReadAllText(filePath);
                string decryptedJson = Tools.DecryptString(encryptedJson);
                User.users = JsonSerializer.Deserialize<List<User>>(decryptedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }

        public static void writeJsonProjects()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "projects.json");
                string jsonString = JsonSerializer.Serialize(Project.projects, new JsonSerializerOptions { WriteIndented = true });
                string encryptedJson = EncryptString(jsonString);
                File.WriteAllText(filePath, encryptedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir el archivo: {ex.Message}");
            }
        }


        public static void writeJsonUsers()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");
                string jsonString = JsonSerializer.Serialize(User.users, new JsonSerializerOptions { WriteIndented = true });
                string encryptedJson = EncryptString(jsonString);
                File.WriteAllText(filePath, encryptedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir el archivo: {ex.Message}");
            }
        }

        public static string EncryptString(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.GenerateIV();
                byte[] iv = aesAlg.IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(iv, 0, iv.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        public static string DecryptString(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                byte[] iv = new byte[16];
                Array.Copy(cipherBytes, 0, iv, 0, iv.Length);

                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes, iv.Length, cipherBytes.Length - iv.Length))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
