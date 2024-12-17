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
           string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "projects.json");
           string encryptedJson = File.ReadAllText(filePath);
           string decryptedJson = DecryptString(encryptedJson);

           Project.projects = JsonSerializer.Deserialize<List<Project>>(decryptedJson);
        }

        public static void readJsonUsers()
        {
           string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "users.json");
           string encryptedJson = File.ReadAllText(filePath);
           string decryptedJson = Tools.DecryptString(encryptedJson);

           User.users = JsonSerializer.Deserialize<List<User>>(decryptedJson);
        }


        public static void writeJsonProjects()
        {
            MessageBox.Show($"ESCRIBIENDO...");
            try
            {
                // Aquí usamos AppDomain.CurrentDomain.BaseDirectory para obtener la raíz del proyecto
                string rootPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string jsonFolderPath = Path.Combine(rootPath, "Json");

                // Verifica si la carpeta Json existe. Si no, la crea.
                if (!Directory.Exists(jsonFolderPath))
                {
                    Directory.CreateDirectory(jsonFolderPath);
                }

                // Define la ruta donde se guardará el archivo
                string filePath = Path.Combine(jsonFolderPath, "projects.json");

                // Serializa el objeto Project.projects a JSON con una estructura legible
                string jsonString = JsonSerializer.Serialize(Project.projects, new JsonSerializerOptions { WriteIndented = true });

                // Encripta el JSON antes de guardarlo
                string encryptedJson = EncryptString(jsonString);

                // Escribe el JSON encriptado en el archivo
                File.WriteAllText(filePath, encryptedJson);
                MessageBox.Show($"ESCRITO");
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de fallar
                MessageBox.Show($"Error al escribir el archivo: {ex.Message}");
            }
        }


        public static void writeJsonUsers()
        {
            MessageBox.Show($"ESCRIBIENDO...");
            try
            {
                // Aquí usamos AppDomain.CurrentDomain.BaseDirectory para obtener la raíz del proyecto
                string rootPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string jsonFolderPath = Path.Combine(rootPath, "Json");

                // Verifica si la carpeta Json existe. Si no, la crea.
                if (!Directory.Exists(jsonFolderPath))
                {
                    Directory.CreateDirectory(jsonFolderPath);
                }

                // Define la ruta donde se guardará el archivo de usuarios
                string filePath = Path.Combine(jsonFolderPath, "users.json");

                // Serializa el objeto User.users a JSON con una estructura legible
                string jsonString = JsonSerializer.Serialize(User.users, new JsonSerializerOptions { WriteIndented = true });

                // Encripta el JSON antes de guardarlo
                string encryptedJson = EncryptString(jsonString);

                // Escribe el JSON encriptado en el archivo
                File.WriteAllText(filePath, encryptedJson);
                MessageBox.Show($"ESCRITO");
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de fallar
                MessageBox.Show($"Error al escribir el archivo de usuarios: {ex.Message}");
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
