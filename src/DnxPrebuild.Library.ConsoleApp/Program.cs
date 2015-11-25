﻿using System;
using System.IO;

namespace DnxPrebuild.Library.ConsoleApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("DnxPrebuild.Library.ConsoleApp");
			var filePath = Path.Combine(Environment.CurrentDirectory, "dnx-prebuild.log");
			File.AppendAllText(filePath, DateTime.Now.ToLongTimeString() + Environment.NewLine);
		}
	}
}