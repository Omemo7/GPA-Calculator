using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace GPACalculator
{
    public static class clsConfigCredentialManager
    {
        public static void SaveCredentials(string username, string password)
        {
           
                string data = $"{username}:{password}";
                byte[] encryptedData = ProtectedData.Protect(Encoding.UTF8.GetBytes(data), null, DataProtectionScope.CurrentUser);

                string encryptedString = Convert.ToBase64String(encryptedData);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["EncryptedCredentials"].Value = encryptedString;
                config.Save(ConfigurationSaveMode.Modified);
           
        }

        public static (string username, string password) LoadCredentials()
        {
            string encryptedString = ConfigurationManager.AppSettings["EncryptedCredentials"];
            if (string.IsNullOrEmpty(encryptedString))
                throw new InvalidOperationException("No credentials found in app.config.");

            byte[] encryptedData = Convert.FromBase64String(encryptedString);
            string decryptedData = Encoding.UTF8.GetString(
                ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser)
            );

            var parts = decryptedData.Split(':');
            if (parts.Length != 2)
                throw new FormatException("Invalid credential format.");

            return (parts[0], parts[1]);
        }
    }
}
