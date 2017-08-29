using System;
using Prueba28.Modelo;

namespace Prueba28
{
    class Program
    {
        public static String tipo;

        static void Main(string[] args)
        {
            Console.WriteLine("Indique que motor de persistencia desea utilizar: \n 1: Oracle \n 2: MySql");
            tipo = Console.ReadLine();
            while(!tipo.Equals("1") && !tipo.Equals("2"))
            {
                Console.WriteLine("Por favor, inserte 1 o 2. \n 1: Oracle \n 2: MySql");
                tipo = Console.ReadLine();
            }
            Console.WriteLine(String.Concat("Introducido correctamente: ", tipo));
            Contexto Context = Contexto.GetUnicaInstancia(tipo);
            
            Context.Inicializar(typeof(Caja), typeof(Ticket));
            //TODO Resto de la aplicacion...
            Console.ReadLine();
        }
    }
}
