﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Utils
{
    public class Encryption
    {
		public static string ComputeMd5Hash(string message)
		{
			using (MD5 md5 = MD5.Create())
			{
				byte[] input = Encoding.ASCII.GetBytes(message);
				byte[] hash = md5.ComputeHash(input);

				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hash.Length; i++)
				{
					sb.Append(hash[i].ToString("X2"));
				}
				return sb.ToString();
			}
		}
	}
}
