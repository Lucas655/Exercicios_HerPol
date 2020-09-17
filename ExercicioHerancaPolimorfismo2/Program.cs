using ExercicioHerancaPolimorfismo2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioHerancaPolimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cria a lista de produtos*/
            List<Product> products = new List<Product>();


            /*Pede quantos itens serão adicionados*/
            Console.Write("Enter the number of products: ");
            int numProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numProducts; i++)
            {

                Product p; // Cria uma variavel do tipo produto para armazenar os produtos;

                Console.WriteLine("Product #"+(i+1)+" data: ");

                //Escolhe o tipo de produto;
                Console.Write("Common, used or imported (c/u/i)? ");
                char choice = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                /*
                    Teste para cadastrar cada produto;
                
                    Como estamos trabalhando com herança, apenas instanciando um produto, é possível
                 criar qualquer tipo de produto, desde que esse seja subclasse de produto;

                 Logo após, adicionamos o produto instanciado na lista;

                 */
                if (choice == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    p = new ImportedProduct(name, price, customsFee);                   
                    products.Add(p);                    
                }
                else if(choice == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    p = new UsedProduct(name, price, date);
                    products.Add(p);
                }
                else
                {
                    p = new Product(name, price);
                    products.Add(p);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");


            /*
                Imprime os itens de cada produto (PriceTag);
             */
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }




        }
    }
}
