using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExercicioHerancaPolimorfismo2.Entities
{
    class Product
    {

        /*
            Atributos
         */

        public string Name { get; set; }
        public double Price { get; set; }


        /*
            Construtores
        */
        public Product()
        {
        }
               
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /*         
            Método para imprimir uma etiqueta do produto;
         */
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2",CultureInfo.InvariantCulture);
        }
        


    }
}
