using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioHerancaPolimorfismo2.Entities
{
    class UsedProduct : Product
    {

        /*
            Atributos;
         */
        public DateTime ManufactureDate { get; set; }


        /*
            Construtores;
         */
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        /*
            Método para imprimir etiqueta;
         */
        public override string PriceTag()
        {
            return Name + "(Used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy") + ")"; 
        }

    }
}
