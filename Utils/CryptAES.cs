using crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace SysEstoque.Utils {
	internal class AESAlgorithm {
		private static byte[] Key = Convert.FromBase64String("Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=");
		private static byte[] IV = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };
		private static byte[] salt = { 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x5, 0x4, 0x3, 0x2, 0x1, 0x0 };

		internal static void makeKey(string _Key) {
			Rfc2898DeriveBytes chave = new Rfc2898DeriveBytes(_Key, salt);

			Key = chave.GetBytes(16);
		}

		public static string Encriptar(string plainText) {
			// Check arguments. 
			if (plainText == null || plainText.Length <= 0)
				throw new ArgumentNullException("plainText");
			if (Key == null || Key.Length <= 0)
				throw new ArgumentNullException("Key");
			if (IV == null || IV.Length <= 0)
				throw new ArgumentNullException("IV");

			byte[] encrypted;
			byte[] bKey = Key;

			using (AesManaged aesAlg = new AesManaged()) {
				aesAlg.Key = bKey;
				aesAlg.IV = IV;

				// Create a decrytor to perform the stream transform.
				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				// Create the streams used for encryption. 
				using (MemoryStream msEncrypt = new MemoryStream()) {
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) {
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
							//Write all data to the stream.
							swEncrypt.Write(plainText);
						}
						encrypted = msEncrypt.ToArray();
					}
				}
			}

			return Convert.ToBase64String(encrypted);
		}

		public static string Decriptar(string plainText) {
			// Check arguments. 
			if (plainText == null || plainText.Length <= 0)
				throw new ArgumentNullException("plainText");
			if (Key == null || Key.Length <= 0)
				throw new ArgumentNullException("Key");
			if (IV == null || IV.Length <= 0)
				throw new ArgumentNullException("Key");

			byte[] cipherText = Convert.FromBase64String(plainText);
			byte[] bKey = Key;

			// Create an AesManaged object 
			// with the specified key and IV. 
			using (AesManaged aesAlg = new AesManaged()) {
				aesAlg.Key = bKey;
				aesAlg.IV = IV;

				// Create a decrytor to perform the stream transform.
				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

				// Create the streams used for decryption. 
				using (MemoryStream msDecrypt = new MemoryStream(cipherText)) {
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
						using (StreamReader srDecrypt = new StreamReader(csDecrypt)) {
							// Read the decrypted bytes from the decrypting stream 
							// and place them in a string.
							plainText = srDecrypt.ReadToEnd();
						}
					}
				}

			}

			return plainText;
		}
	}
}
