using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariany_twins_project
{
   

    class siEsMayorEdad 
    {

        private string nombre;
        private int edad;
        //Método de Inicializar()
        public void Inicializar()

        {
           
                Console.Write("Ingrese nombre:");
                nombre = Console.ReadLine();
                string linea;
                Console.Write("Ingrese edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);


            
        }
        //Método Imprimir()
        public void Imprimir()
        {

         // Console.Clear();
                Console.Write("Nombre:");
                Console.WriteLine(nombre);
                Console.Write("Edad:");
                Console.WriteLine(edad);
            EsMayorEdad();
        }
        //Método es EsMayorEdad() 
        public void EsMayorEdad()

        {
            
            bool valor;
            if (edad >= 18)
            {
              
                Console.WriteLine("Es mayor de edad \n");
                Console.WriteLine("////////////////////");
            
            }
            else
            {
                valor = false;
                Console.Write("No es mayor de edad \n");
                Console.WriteLine("////////////////////");

                if (valor == false)
                {
                    int num = 18;
                    while(edad <num)
                    {

                        Inicializar();
                        Imprimir();
                     
                    }
                }

            }



        }
        //Main principal del programa 
        static void Main(string[] args)


        {
            Console.WriteLine("Bienvenidos al programa Si es mayor de Edad \n");
            Console.WriteLine("Realizado por: \n ");
            Console.WriteLine("Grupo Technology Twins \n");
            Console.WriteLine("Sección 0463 \n"); 
            Console.WriteLine("Arianny Cadena          16-siit-1-008");
            Console.WriteLine("Marleny Ferreira        16-siit-1-009 \n");
            Console.WriteLine("Este programa consiste en encontrar personas que sean mayores de edad \n");


        

        

            

            siEsMayorEdad per1 = new siEsMayorEdad(); 
            per1.Inicializar(); //Llamando al método Inicializar();
            per1.Imprimir();    //Llamando al método Imprimir();
        //  per1.EsMayorEdad(); //Llamando al método EsMayorEdad



            Console.ReadKey();



        }
    }
}
