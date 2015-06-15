using System.Text;
using System.Security.Cryptography;
using System;

namespace HashText
{
	public class Hasher
	{
		public static string HashString(string raw)
		{
			if (string.IsNullOrWhiteSpace (raw)) {
				return "";
			}

			return getSha256(raw);
		}

		public static string getSha256(string text)
		{
			SHA256Managed hashstring = new SHA256Managed();
			byte[] hash = hashstring.ComputeHash(Encoding.UTF8.GetBytes(text));

			string hashString = "";
			foreach (byte x in hash)
			{
				// "x2": hex
				hashString += String.Format("{0:x2}", x);
			}
			return hashString;
		}
	}
}

