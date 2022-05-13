using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int code;
        public string nome;
        public string description;
        public double price;
        public double iva;
       
        //faccio i get e i set 
        // Get=lettura prendo il valore della variabile
        // Set = Viene eseguito al momento della scrittura , set viene eseguito quando viene assegnato un Nuovo valore alla variabile
        public int Code
        {
            get { return code; }
            set { code = value; }   
        }

        public string Nome
        {
            get { return nome; }    
            set { nome = value; }
        }

        public string Description
        {
            get { return description; }     
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Iva
        {
            get { return iva; }     
            set { iva = value; }
        }

        private Random randomNum;

        //costruttore 
        public Prodotto(string nome , string description , double price , double iva)
        {
            randomNum = new Random();
            Code = randomNum.Next();
            this.Nome = nome;
            this.Description = description;
            this.Price = price;
            this.Iva = iva;
        }

        public double IvaPrice()
        {
            return Price + Iva ;
        }

        public string ExtendedName()
        {
            string extendedName;
            return extendedName = Code + Nome;
        }
    }
}
