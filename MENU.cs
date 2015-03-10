using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        [STAThread]
        
         static void Main(string[] args)  
        {
            String primernumero, segundonumero;
            int numero1, numero2, suma, resta, multiplicacion, division, areatriangulo,areacuadrado;
            float circulo;


          
            
            
            Console.WriteLine("1-) SUMA" + "\n" + "2-) RESTA" + "\n" + "3-) MULTIPLICACION" + "\n" + "4-) DIVISION" + "\n" + "5-) AREA TRIANGULO" + "\n" + "6-) AREA CUADRADO" + "\n" + "7-) AREA CIRCULO" + "\n");
            Console.WriteLine("SELECCIONA UNA OPCION:" + "\n");
            
             
            
          
            switch (Console.Read())
            {
                case '1': Console.Write("******  ESCOGISTE LA OPCION 1 SUMA ******" + "\n");
                    
                    Console.WriteLine("INGRESA EL PRIMER NUMERO:");
                    primernumero = Console.ReadLine();
                    numero1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA EL SEGUNDO NUMERO:");
                    segundonumero = Console.ReadLine();
                    numero2 = Int32.Parse(segundonumero);
                    suma = numero1 + numero2;
                    Console.WriteLine("EL RESULTADO DE LA SUMA ES: {0}",suma);
                

                   break;
                case '2': Console.Write("****** ESCOGISTE LA OPCION 2 RESTA ******" +"\n ");
                    
                    Console.WriteLine("INGRESA EL PRIMER NUMERO:");
                    primernumero = Console.ReadLine();
                    numero1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA EL SEGUNDO NUMERO:");
                    segundonumero = Console.ReadLine();
                    numero2 = Int32.Parse(segundonumero);
                    resta = numero1 - numero2;
                    Console.WriteLine("EL RESULTADO DE LA RESTA ES: {0}",resta);
        
                    break;

                case '3': Console.Write("****** ESCOGISTE LA OPCION 3 MULTIPLICACION ******" + "\n ");

                    Console.WriteLine("INGRESA EL PRIMER NUMERO:");
                    primernumero = Console.ReadLine();
                    numero1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA EL SEGUNDO NUMERO:");
                    segundonumero = Console.ReadLine();
                    numero2 = Int32.Parse(segundonumero);
                    multiplicacion = numero1 * numero2;
                    Console.WriteLine("EL RESULTADO DE MULTIPLICACION ES: {0}", multiplicacion + "\n ");
                    
                    break;

                case '4': Console.Write("****** ESCOGISTE LA OPCION 4 DIVISION ******" + "\n ");

                    Console.WriteLine("INGRESA EL PRIMER NUMERO:");
                    primernumero = Console.ReadLine();
                    numero1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA EL SEGUNDO NUMERO:");
                    segundonumero = Console.ReadLine();
                    numero2 = Int32.Parse(segundonumero);
                    division = numero1 / numero2;
                    Console.WriteLine("EL RESULTADO DE DIVISION ES: {0}", division);

                    break;
                case '5': Console.Write("****** ESCOGISTE LA OPCION 5 AREA DEL TRIANGULO ******" + "\n ");

                    Console.WriteLine("INGRESA BASE:");
                    primernumero = Console.ReadLine();
                    numero1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA ALTURA:");
                    segundonumero = Console.ReadLine();
                    numero2 = Int32.Parse(segundonumero);
                    areatriangulo = numero1 * numero2 / 2;
                    Console.WriteLine("EL RESULTADO DEL AREA DEL TRIANGULO ES: {0}", areatriangulo);
                break;
                
                case '6': Console.Write("****** ESCOGISTE LA OPCION 6 AREA DEL CUADRADO ******" + "\n ");
                    Console.WriteLine("INGRESA ANCHO DEL CUADRADO:");
                    primernumero = Console.ReadLine();
                    numero1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA ALTURA DEL CUADRADO:");
                    segundonumero = Console.ReadLine();
                    numero2 = Int32.Parse(segundonumero);
                    areacuadrado = numero1 * numero2;
                    Console.WriteLine("EL RESULTADO DEL AREA DEL CUADRADO ES: {0}", areacuadrado);
                    break;


                case '7': Console.Write("****** ESCOGISTE LA OPCION 7 AREA DEL CIRCULO ******" + "\n ");
                    Console.WriteLine("INGRESA EL RADIO DEL CIRCULO:");
                    primernumero = Console.ReadLine();
                    numero1 = Int32.Parse(Console.ReadLine());
                    circulo = ((numero1 * 3.1416f));
                    Console.WriteLine("EL RESULTADO DEL AREA DEL CIRCULO ES: {0}", circulo);
                    
                    break;
            }
         
             Console.ReadKey();
    } } 
        }
    

