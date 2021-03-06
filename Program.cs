using System;
using System.Collections.Generic;

namespace BA3C
{
	class Program
	{ 
		public static string Prefix(string s)
			{
			return s.Substring(0, s.Length-1 );
			}
		public static string Sufix(string s)
		{
			return s.Substring(1, s.Length-1);
		}
		public static SortedDictionary<string, List<string>> Overlap(List<string> lista)
		{
			SortedDictionary<string, List<string>> pairs = new SortedDictionary<string, List<string>>();
			int pat = lista.Count;
			for (int i = 0; i < pat; i++)
			{for (int j = 0; j < pat; j++)
				{ if (i != j & Sufix(lista[i]) == Prefix(lista[j]) & pairs.ContainsKey(lista[i]))
					{
						pairs[lista[i]].Add(lista[j]);
					}
					if (i != j & Sufix(lista[i]) == Prefix(lista[j]))
					{
						List<string> l1 = new List<string>();
						l1.Add(lista[j]);
						pairs.Add(lista[i], l1);
					}
				}
			}
			return pairs;
		}
		static void Main(string[] args)
		{
			List<string> l = new List<string>();
			l.Add("ATGCG");
			l.Add("GCATG");
			l.Add("CATGC");
			l.Add("AGGCA");
			l.Add("GGCAT");
			SortedDictionary<string, List<string>> k = Overlap(l);
			foreach (string key in k.Keys)
			{foreach (string value in k[key])
				{
					Console.WriteLine(key + "->" + value + ",");
				}
			}
			Console.WriteLine("kraj");
				
		}
	}
}
