using System;
using System.Numerics;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace CréditoTarjeta
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
            
            Console.Clear();
            string NumerodeTarjeta;
            int MasterCard = 51, MasterCard2 = 52, MasterCard3 = 53, MasterCard4 = 54, MasterCard5 = 55;
            int AmericanExpress = 34, Americanespress2 = 37;
            int Visa = 4;

            Console.WriteLine("Ingrése el número de la tarjeta: ");
            NumerodeTarjeta = Console.ReadLine().Trim();
            int.TryParse(NumerodeTarjeta.Substring(0,2),out MasterCard);
            int.TryParse(NumerodeTarjeta.Substring(0,2),out MasterCard2);
            int.TryParse(NumerodeTarjeta.Substring(0,2),out MasterCard3);
            int.TryParse(NumerodeTarjeta.Substring(0,2),out MasterCard4);
            int.TryParse(NumerodeTarjeta.Substring(0,2),out MasterCard5);
            int.TryParse(NumerodeTarjeta.Substring(0,2),out AmericanExpress);
            int.TryParse(NumerodeTarjeta.Substring(0,2),out Americanespress2);
            int.TryParse(NumerodeTarjeta.Substring(0,2),out Visa);
            if (MasterCard == 51)
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta MasterCard con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de MasterCard con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }
            if (MasterCard2 == 52)
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta MasterCard con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de MasterCard con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }
            if (MasterCard3 == 53)
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta MasterCard con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de MasterCard con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }
            if (MasterCard4 == 54)
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta MasterCard con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de MasterCard con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }
            if (MasterCard5 == 55)
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta MasterCard con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de MasterCard con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }
            if (AmericanExpress == 34)
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta AmericanExpress con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de AmericanExpress con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }
            if (Americanespress2 == 37)
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta AmericanExpress con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de AmericanExpress con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }
            if (Visa <= 40)
            {
                
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"Tarjeta VISA con número --{NumerodeTarjeta}-- ingresado es ¡VÁLIDO! :).", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El intento de VISA con número --{NumerodeTarjeta}-- es ¡INVÁLIDO! >:U.");
                    }

                    Console.Read();
            }else
            {
                if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"El número {NumerodeTarjeta} ingresado es ¡VÁLIDO!.", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El número {NumerodeTarjeta} es ¡INVÁLIDO!.");
                    }

                    Console.Read();
                    Console.Clear();
            }



            if (VerifiTarjeta(NumerodeTarjeta))
                    {
                        Console.Clear();
                        Console.WriteLine($"El número {NumerodeTarjeta} ingresado es ¡VÁLIDO!.", NumerodeTarjeta);
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine($"El número {NumerodeTarjeta} es ¡INVÁLIDO!.");
                    }

                    Console.Read();
                    Console.Clear();

             
        }
        public static bool VerifiTarjeta(string tarjeta)
        {
            int suma = 0;
            bool flag = true;

            for (int i = tarjeta.Length - 1; i >=0; i--)
            {
                if (!flag)
                {
                    int tmp = (tarjeta[i] - '0') << 1;
                    suma += tmp >= 10? tmp - 9: tmp;
                }else
                {
                    suma += (tarjeta[i] -  '0');
                }
                flag = !flag;
            }         
            return suma % 10 == 0;
            
        }    
    }    
}


/*
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string NumerodeTarjeta;
            Console.WriteLine("Ingrése el número de la tarjeta: ");
            NumerodeTarjeta = Console.ReadLine().Trim();

            if (VerifiTarjeta(NumerodeTarjeta))
            {
                Console.WriteLine($"El número {NumerodeTarjeta} ingresado es ¡VÁLIDO!", NumerodeTarjeta);
            }else
            {
                Console.WriteLine($"El número {NumerodeTarjeta} es ¡INVÁLIDO!.");
            }

            Console.Read();

        }
        public static bool VerifiTarjeta(string tarjeta)
        {
            int suma = 0;
            bool flag = true;

            for (int i = tarjeta.Length - 1; i >=0; i--)
            {
                if (!flag)
                {
                    int tmp = (tarjeta[i] - '0') << 1;
                    suma += tmp >= 10? tmp - 9: tmp;
                }else
                {
                    suma += (tarjeta[i] -  '0');
                }
                flag = !flag;
            }         
            return suma % 10 == 0;
        }
    }
} 

namespace CréditoTarjeta
{
    class Program
    {
        static void Main(string[] args)
        {
            char Tarjeta;
            
            Console.Clear();
            Console.WriteLine("A-.Americanespress");
            Console.WriteLine("M-.MasterCard");
            Console.WriteLine("(-Elija el tipo de tarjeta con la inicial del nombre. ¡MAYÚSCULA!-)");
            Tarjeta = Console.ReadKey().KeyChar;
            
            
            switch (Tarjeta)
            {
                case 'A':
                {
                    int Uno,Dos,tres,Cuatro,Cinco,Seis,Siete,Ocho;
                    

                    Console.Clear();
                    Console.WriteLine("AmericanExpress seleccionada!");
                    
                    Console.WriteLine("Número de tarjeta (15 Dígitos *Obligatorio*): ");
                    string Numerodetarjeta = Console.ReadLine();

                    int.TryParse(Numerodetarjeta.Substring(1,1),out Uno);
                    int.TryParse(Numerodetarjeta.Substring(3,1),out Dos);
                    int.TryParse(Numerodetarjeta.Substring(5,1),out tres);
                    int.TryParse(Numerodetarjeta.Substring(7,1),out Cuatro);
                    int.TryParse(Numerodetarjeta.Substring(9,1),out Cinco);
                    int.TryParse(Numerodetarjeta.Substring(11,1),out Seis);
                    int.TryParse(Numerodetarjeta.Substring(13,1),out Siete);
                    int.TryParse(Numerodetarjeta.Substring(15,1),out Ocho);

                    
                    
                    int Suma = Uno * 2;
                    var Suma2 = Dos * 2;
                    var Suma3 = tres * 2;
                    var Suma4 = Cuatro * 2;
                    var Suma5 = Cinco * 2;
                    var Suma6 = Seis * 2;
                    var Suma7 = Siete * 2;
                    var Suma8 = Ocho * 2; 
                    
                     if (Suma >= 10)
                    {
                        Console.Clear();
                        int Valor,Valor2;
                                              
                        string SumadeUno = Console.CapsLock.ToString();
                        int.TryParse(SumadeUno.Substring(0,1),out Valor);
                        int.TryParse(SumadeUno.Substring(1,1),out Valor2);
                        
                        
                        Console.WriteLine($"sas {Valor} {Valor2} {SumadeUno}");
                    }
                    -----------------------------------------------------------------------------------------
                     
                     if (Suma  < 10)
                    {
                        int Valor;
                        Console.WriteLine($"Menor {Suma}");
                        var SumadeUno = Console.ReadLine();
                        int.TryParse(SumadeUno.Substring(0,1),out Valor);
                        Console.WriteLine($"sas {Valor}");
                    }else
                    {
                        int Valor,Valor2;

                        var SumadeUno = Console.ReadLine();
                        int.TryParse(SumadeUno.Substring(0,0),out Valor);
                        int.TryParse(SumadeUno.Substring(1,1),out Valor2);
                        
                        Console.WriteLine($"sas {Valor} {Valor2}");
                    }
                    -----------------------------------------------------------------------------------------

                    break;
                }
                case 'M':
                {
                    int Uno,Dos,tres,Cuatro,Cinco,Seis,Siete,Ocho;
                    Console.Clear();
                    Console.WriteLine("MasterCard seleccionada!");
                    Console.WriteLine("Número de tarjeta (15 Dígitos *Obligatorio*): ");
                    var Numerodetarjeta = Console.ReadLine();

                    int.TryParse(Numerodetarjeta.Substring(1,1),out Uno);
                    int.TryParse(Numerodetarjeta.Substring(3,1),out Dos);
                    int.TryParse(Numerodetarjeta.Substring(5,1),out tres);
                    int.TryParse(Numerodetarjeta.Substring(7,1),out Cuatro);
                    int.TryParse(Numerodetarjeta.Substring(9,1),out Cinco);
                    int.TryParse(Numerodetarjeta.Substring(11,1),out Seis);
                    int.TryParse(Numerodetarjeta.Substring(13,1),out Siete);
                    int.TryParse(Numerodetarjeta.Substring(15,1),out Ocho);

                
                    int Total = Uno + Dos + tres + Cuatro + Cinco + Seis + Siete + Ocho; 
                    
                    Console.WriteLine("Hola " + Total);

                    break;
                }
                default: Console.WriteLine(" <===Letra ingresada no válida.");
                         Console.WriteLine("Asegurese de seguir las indicaciones.");
                break;
            }

            Console.ReadKey();
        }
    }
}/* */

