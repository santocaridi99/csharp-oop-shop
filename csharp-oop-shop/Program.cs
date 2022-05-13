using System;

namespace csharp_oop_shop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto1 = new Prodotto("pallina", "una pallina", 2, 1);
            Console.WriteLine("il prodotto  è {0}", prodotto1.ExtendedName());
            Console.WriteLine("nome prodotto è {0}",prodotto1.Nome);
            Console.WriteLine("Descrizione: {0}", prodotto1.Description);
            Console.WriteLine("Il prezzo del prodotto è {0} euro", prodotto1.Price);
            Console.WriteLine("l'iva del prodotto {0} euro ", prodotto1.Iva);
            Console.WriteLine("Prezzo Iva inclusa è  {0} euro", prodotto1.IvaPrice());


            Console.WriteLine("--------------------------------------------------------");


            Prodotto prodotto2 = new Prodotto("racchetta", "una racchetta", 20, 1);
            Console.WriteLine("il prodotto è {0}", prodotto2.ExtendedName());
            Console.WriteLine("nome prodotto è {0}", prodotto2.Nome);
            Console.WriteLine("Descrizione: {0}", prodotto2.Description);
            Console.WriteLine("Il prezzo del prodotto è {0} euro", prodotto2.Price);
            Console.WriteLine("l'iva del prodotto {0} euro ", prodotto2.Iva);
            Console.WriteLine("Prezzo Iva inclusa è  {0} euro", prodotto2.IvaPrice());
        }
    }
}