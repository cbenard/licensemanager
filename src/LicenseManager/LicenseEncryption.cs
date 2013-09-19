using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LicenseManager
{
    internal class LicenseEncryption
    {
        public static string Encrypt(string product, DateTime? expiration, string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(privateKey);

                byte[] sourceBytes = GetSourceBytes(product, expiration);

                byte[] signature = rsa.SignData(sourceBytes, CryptoConfig.MapNameToOID("SHA512"));

                string licenseString = CreateLicenseString(product, GetDateString(expiration), signature);

                return licenseString;
            }
        }

        private static string CreateLicenseString(string product, string dateString, byte[] signature)
        {
            XElement license = new XElement("license",
                new XAttribute("product", product),
                new XAttribute("expires", dateString),
                new XAttribute("signature", Convert.ToBase64String(signature)));

            return license.ToString();
        }

        private static byte[] GetSourceBytes(string product, DateTime? expiration)
        {
            string date = GetDateString(expiration);

            string dataString = product + "~|~" + date;

            byte[] result = Encoding.ASCII.GetBytes(dataString);

            return result;
        }

        private static string GetDateString(DateTime? expiration)
        {
            string date;

            if (expiration.HasValue)
            {
                date = expiration.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                date = "never";
            }

            return date;
        }

        internal static LicenseInformation Decrypt(string license, string publicKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(publicKey);

                var doc = XDocument.Parse(license);
                if (doc.Root.Name != "license")
                {
                    throw new Exception("Invalid XML root: " + doc.Root.Name);
                }

                string product = doc.Root.Attribute("product").Value;
                string expirationString = doc.Root.Attribute("expires").Value;
                string signatureText = doc.Root.Attribute("signature").Value;
                byte[] signature = Convert.FromBase64String(signatureText);

                DateTime? expiration;
                if (expirationString == "never")
                {
                    expiration = null;
                }
                else
                {
                    expiration = DateTime.Parse(expirationString);
                }

                LicenseInformation info = new LicenseInformation
                {
                    Product = product,
                    Expiration = expiration
                };

                byte[] sourceBytes = GetSourceBytes(product, expiration);

                info.IsValid = rsa.VerifyData(sourceBytes, CryptoConfig.MapNameToOID("SHA512"), signature);

                return info;
            }
        }
    }
}
