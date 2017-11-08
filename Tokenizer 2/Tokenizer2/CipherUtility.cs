using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using static Tokenizer_2.Settings;

namespace Tokenizer_2
{
    public class CipherUtility
    {
        public CipherUtility()
        {
        }

        public string Decrypt(string text)
        {
            string end;
            DeriveBytes rgb = new Rfc2898DeriveBytes(Settings.Default.CepKey, Encoding.Unicode.GetBytes(Settings.Default.CepSalt));
            SymmetricAlgorithm algorithm = new RijndaelManaged();
            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
            byte[] rgbIv = rgb.GetBytes(algorithm.BlockSize >> 3);
            ICryptoTransform transform = algorithm.CreateDecryptor(rgbKey, rgbIv);
            MemoryStream buffer = new MemoryStream(Convert.FromBase64String(text));
            try
            {
                CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read);
                try
                {
                    StreamReader reader = new StreamReader(stream, Encoding.Unicode);
                    try
                    {
                        end = reader.ReadToEnd();
                    }
                    finally
                    {
                        if (reader != null)
                        {
                            ((IDisposable)reader).Dispose();
                        }
                    }
                }
                finally
                {
                    if (stream != null)
                    {
                        ((IDisposable)stream).Dispose();
                    }
                }
            }
            finally
            {
                if (buffer != null)
                {
                    ((IDisposable)buffer).Dispose();
                }
            }
            return end;
        }

        public string Encrypt(string value)
        {
            string base64String;
            DeriveBytes rgb = new Rfc2898DeriveBytes(Settings.Default.CepKey, Encoding.Unicode.GetBytes(Settings.Default.CepSalt));
            SymmetricAlgorithm algorithm = new RijndaelManaged();
            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
            byte[] rgbIv = rgb.GetBytes(algorithm.BlockSize >> 3);
            ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIv);
            MemoryStream buffer = new MemoryStream();
            try
            {
                CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write);
                try
                {
                    StreamWriter writer = new StreamWriter(stream, Encoding.Unicode);
                    try
                    {
                        writer.Write(value);
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            ((IDisposable)writer).Dispose();
                        }
                    }
                }
                finally
                {
                    if (stream != null)
                    {
                        ((IDisposable)stream).Dispose();
                    }
                }
                base64String = Convert.ToBase64String(buffer.ToArray());
            }
            finally
            {
                if (buffer != null)
                {
                    ((IDisposable)buffer).Dispose();
                }
            }
            return base64String;
        }
    }
}
