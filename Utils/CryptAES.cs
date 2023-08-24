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


	//=======================================


		static void EncryptAesManaged(string raw) {
			try {
				// Create Aes that generates a new key and initialization vector (IV).    
				// Same key must be used in encryption and decryption    
				using (AesManaged aes = new AesManaged()) {
					// Encrypt string    
					byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
					// Print encrypted string    
					Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
					// Decrypt the bytes to a string.    
					string decrypted = Decrypt(encrypted, aes.Key, aes.IV);
					// Print decrypted string. It should be same as raw data    
					Console.WriteLine($"Decrypted data: {decrypted}");
				}
			} catch (Exception exp) {
				Console.WriteLine(exp.Message);
			}
			Console.ReadKey();
		}
		static byte[] Encrypt(string plainText, byte[] Key, byte[] IV) {
			byte[] encrypted;
			// Create a new AesManaged.    
			using (AesManaged aes = new AesManaged()) {
				// Create encryptor    
				ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
				// Create MemoryStream    
				using (MemoryStream ms = new MemoryStream()) {
					// Create crypto stream using the CryptoStream class. This class is the key to encryption    
					// and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
					// to encrypt    
					using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write)) {
						// Create StreamWriter and write data to a stream    
						using (StreamWriter sw = new StreamWriter(cs))
							sw.Write(plainText);
						encrypted = ms.ToArray();
					}
				}
			}
			// Return encrypted data    
			return encrypted;
		}
		static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV) {
			string plaintext = null;
			// Create AesManaged    
			using (AesManaged aes = new AesManaged()) {
				// Create a decryptor    
				ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
				// Create the streams used for decryption.    
				using (MemoryStream ms = new MemoryStream(cipherText)) {
					// Create crypto stream    
					using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read)) {
						// Read crypto stream    
						using (StreamReader reader = new StreamReader(cs))
							plaintext = reader.ReadToEnd();
					}
				}
			}
			return plaintext;
		}

	}
}
