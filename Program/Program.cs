using System;
using System.Collections.Generic;
using System.Text;
using Veiculoo.br.com.gft.model;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {

            }
            Carro fusca = new Carro("Fusca", 50, 4, 30, "Volkswagen", 2, 1990);
            Carro ferrari = new Carro("Ferrari F800", 300, 4, 40, "Ferrari", 2, 2019);
            Carro golf = new Carro("Golf MK1", 110, 4, 20, "Volkswagen", 2, 1975);
            Aviao fic = new Aviao("Generico", 1000, 200, 500, "Comercial", "Transporte de Pessoas");
            Aviao con = new Aviao("Concorde", 2469, 100, 600, "Super Sônico", "Voar");
            Aviao b29 = new Aviao("B-29 Superfortress", 574, 11, 300, "Bombardeiro Estratégico", "Explodir Coisas");
            Console.WriteLine("##############################################################################");
            Console.WriteLine("##############################################################################");
            Console.WriteLine("DIGITE /lista carros PARA VER AS INFORMAÇÕES DO CARRO" + "\n" + "DIGITE /AVIAO PARA VER A LISTA DO AVIÃO");
            string escolha;
            while (true)
                {
                    escolha = Console.ReadLine();
                    switch (escolha)
                    {
                        //LISTA DOS CARROS//
                     case "/lista carros":
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine(fusca.modelo + "\n" + ferrari.modelo + "\n" + golf.modelo);
                        break;
                    case "Fusca":
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("Modelo: " + fusca.modelo + "\n" + "Passageiros: " + fusca.passageiros + "\n" + "Combustível: " + fusca.combustivel + "\n" + "Velocidade: " + fusca.velocidade + "\n" + "Fabricante: " + fusca.marca + "\n" + "Passageiros: " + fusca.passageiros + "\n" + "Portas: " + fusca.portas);    
                        break;

                    case "Ferrari F800":
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("Modelo: " + ferrari.modelo + "\n" + "Passageiros: " + ferrari.passageiros + "\n" + "Combustível: " + ferrari.combustivel + "\n" + "Velocidade: " + ferrari.velocidade + "\n" + "Fabricante: " + ferrari.marca + "\n" + "Passageiros: " + ferrari.passageiros + "\n" + "Portas: " + ferrari.portas);
                        break;

                    case "Golf MK1":
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("Modelo: " + golf.modelo + "\n" + "Passageiros: " + golf.passageiros + "\n" + "Combustível: " + golf.combustivel + "\n" + "Velocidade: " + golf.velocidade + "\n" + "Fabricante: " + golf.marca + "\n" + "Passageiros: " + golf.passageiros + "\n" + "Portas: " + golf.portas);
                        break;
                        
                    case "/lista aviao":
                        for(int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine(fic.modelo + "\n" + con.modelo + "\n" + b29.modelo);
                        break;
                    case "Generico":
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("Modelo: " + fic.modelo + "\n" + "Passageiros: " + fic.passageiros + "\n" + "Combustível: " + fic.combustivel + "\n" + "Velocidade: " + fic.velocidade + "\n" + "Tipo: " + fic.passageiros + "\n" + "Passageiros: " + fic.passageiros + "\n" + "Uso: " + fic.uso);
                        break;
                    case "Concorde":
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("Modelo: " + con.modelo + "\n" + "Passageiros: " + con.passageiros + "\n" + "Combustível: " + con.combustivel + "\n" + "Velocidade: " + con.velocidade + "\n" + "Tipo: " + con.passageiros + "\n" + "Passageiros: " + con.passageiros + "\n" + "Uso: " + con.uso);
                        break;
                    case "B-29":
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("Modelo: " + b29.modelo + "\n" + "Passageiros: " + b29.passageiros + "\n" + "Combustível: " + b29.combustivel + "\n" + "Velocidade: " + b29.velocidade + "\n" + "Tipo: " + b29.passageiros + "\n" + "Passageiros: " + b29.passageiros + "\n" + "Uso: " + b29.uso);
                        break;


                }
                }
        }
    }
}
    
