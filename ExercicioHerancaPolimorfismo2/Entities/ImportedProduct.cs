using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioHerancaPolimorfismo2.Entities
{
    class ImportedProduct : Product
    {

        /*
            Atributos
         */
        public double CustomsFee { get; set; }


        /*         
            Construtores
         */
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee): base(name, price)
        {
            CustomsFee = customsFee;
        }


        /*
            Método para calcular o preço de um item importado;
         */
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        /*
            Método para imprimir a priceTag;
         */
        public override string PriceTag()
        {

           return Name + " $ "+TotalPrice().ToString("F2",CultureInfo.InvariantCulture)
                +" (Customs fee: $ " + CustomsFee.ToString("F2",CultureInfo.InvariantCulture) + ")";
        }

        
    }
}
