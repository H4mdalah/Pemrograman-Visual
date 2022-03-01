/*
 * Created by SharpDevelop.
 * User: rober
 * Date: 01/03/2022
 * Time: 21:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Koding
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Tulis nama anda : ");
			String nama = Console.ReadLine();
			
			
			Console.WriteLine("Hai "+nama+" ganteng");
			Console.Write("Sampai jumpa "+nama+" ganteng");
			Console.ReadKey(true);
		}
	}
}