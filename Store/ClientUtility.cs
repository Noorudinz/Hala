using HALA.DTO.RequestResponseWrappers;
using HALA.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Store
{
    public class ClientUtility
    {
        public static string WebApiUri = ConfigurationManager.AppSettings["WebApiUri"].ToString();
        public static string FrontEndWebUri = ConfigurationManager.AppSettings["WebFrontEndUri"].ToString();

        public HALA.DTO.RequestResponseWrappers.OAuthTokenResponse UserInfo;
        public HALA.Utility.DataServiceManager serviceManger;

        public static string IsTestEnvironment = ConfigurationManager.AppSettings["Test"].ToString();
        //public static string HALACLogUrl = ConfigurationManager.AppSettings["HALACLogUrl"].ToString();

        public ClientUtility()
        {
            UserInfo = new HALA.DTO.RequestResponseWrappers.OAuthTokenResponse();
        }
    }


    public static class CommonMethods
    {
        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6f702";
        public static readonly string UserInfoKey = "HALAOnlineUserInfo";
        public static readonly string UserTempInfoKey = "HALAOnlineTempUserInfo";

        public static string Encrypt(this string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(this string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        public static DataServiceManager GetLogedInService(string key = "")
        {
            key = string.IsNullOrEmpty(key) ? UserInfoKey : key;
            string value = "";
            if (HttpContext.Current.Request.Cookies.AllKeys.Contains(key))
            {
                value = HttpContext.Current.Request.Cookies[key].Value;
                value = value.Decrypt();
            }

            if (!string.IsNullOrEmpty(value))
            {
                OAuthTokenResponse info = JsonConvert.DeserializeObject<OAuthTokenResponse>(value);
                return new DataServiceManager(ClientUtility.WebApiUri, info.AccessToken, false);
            }
            else
            {
                return new DataServiceManager(ClientUtility.WebApiUri, "", false);
            }

        }

        public static OAuthTokenResponse GetUserDetails(string key = "")
        {
            key = string.IsNullOrEmpty(key) ? UserInfoKey : key;
            string value = "";
            if (HttpContext.Current.Request.Cookies.AllKeys.Contains(key))
            {
                value = HttpContext.Current.Request.Cookies[key].Value;
                value = value.Decrypt();
            }

            OAuthTokenResponse info = JsonConvert.DeserializeObject<OAuthTokenResponse>(value);
            return info;
        }

        public static bool IsCookieAvailable(string key = "")
        {
            key = string.IsNullOrEmpty(key) ? UserInfoKey : key;
            if (!HttpContext.Current.Request.Cookies.AllKeys.Contains(key))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static void DeleteCookie(string key = "")
        {
            key = string.IsNullOrEmpty(key) ? UserInfoKey : key;
            try
            {
                if (HttpContext.Current.Request.Cookies.AllKeys.Contains(key))
                {
                    var httpCookie = HttpContext.Current.Request.Cookies[key];
                    HttpContext.Current.Request.Cookies.Remove(key);
                    httpCookie.Value = null;
                    httpCookie.Expires = DateTime.Now.AddDays(-10);
                    HttpContext.Current.Response.SetCookie(httpCookie);

                }
            }
            catch (System.Exception ex)
            {
            }
        }

        public static string ConverToLocalFormat(this DateTime? value)
        {
            return value.HasValue ? value.Value.ToString("dd-MMM-yyyy") : "";
        }

        public static string ConvertToLocalFormat1(this DateTime? value)
        {
            return value.HasValue ? value.Value.ToString("dd/MM/yyyy") : "";
        }

        public static string ConverToLocalFormat(this DateTime value)
        {
            return value.ToString("dd-MMM-yyyy");
        }

        public static String GetClientIP()
        {
            string ip = "";

            try
            {
                ip =
                    HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
            }
            catch (System.Exception exc)
            {
                ip = "";
            }

            return ip;
        }

    }
}