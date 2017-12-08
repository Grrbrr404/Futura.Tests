using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreisRechner {
	class Program {

		public enum PriceType {
			Normal,
			High,
			German
		}


		/*
		 * Die Methode CalculateTex verstößt gegen das so genannte Open-Closed Prinzip.
		 * Baue die Methode um, sodass dieses Prinzip nicht mehr verletzt wird. 
		 * Tip: Strategy-Pattern anwenden
		 */


		static void Main(string[] args) {
			var price = 200m;
			var tax = CalculateTax(price, PriceType.High);
			Console.WriteLine(tax);
			Console.ReadLine();
		}

		private static decimal CalculateTax(decimal amount, PriceType type) {
			switch (type) {
				case PriceType.Normal:
					return amount * 0.03m;
				case PriceType.High:
					return amount * 0.07m;
				case PriceType.German:
					return amount * 0.19m;
				default:
					throw new ArgumentOutOfRangeException("type", type, null);
			}
		}
	}
}
