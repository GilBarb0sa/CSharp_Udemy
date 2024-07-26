using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


	public interface ILoca
	{
		string Assinar(string nome);
	}

	public class NovaLoca: ILoca
	{
		public  string Assinar(string nome)
		{
			return nome.ToUpper();
		}
	}

	public class AntigaLoca : ILoca
	{
		public  string Assinar(string nome)
		{
			return nome.ToLower();
		}
	}

	public static class Visualizar
	{
		public static void Exibir(this ILoca loca, string nome)
		{
			Console.WriteLine(loca.Assinar(nome));
		}

	}
}
