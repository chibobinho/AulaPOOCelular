using System;

namespace aulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular xiaomi = new celular();

            Console.WriteLine("Quer ligar o celular? (S/N)");

            string desejo = Console.ReadLine().ToLower();
            while (xiaomi.ligado == false)
            {

                if (desejo == "s")
                {
                    Console.WriteLine($@"
__________________________
|           o            |
|                        |
|    1 - Fazer ligação   |
|                        |
|    2 - Mandar          |
|       mensagem         |
|                        |
|    3 - Propriedades    |
|                        |
|    0 - Desligar        |
|                        |
==========================
            ");
                }
                else if (desejo == "n")
                {
                    xiaomi.ligado = true;
                    Console.WriteLine("Quer ir embora mesmo? Digite 0");
                }

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    xiaomi.ligado = false;
                    Console.WriteLine($@"
__________________________
|           o            |
|                        |
|                        |
|                        |
|       Ligação não      |
|        atendida        |
|           :(           |
|                        |
|                        |
|                        |
|                        |
==========================
            ");
                }
                else if (opcao == 2)
                {
                    xiaomi.ligado = false;
                    Console.WriteLine($@"
__________________________
|           o            |
|                        |
|                        |
|                        |
|      Mensagem foi      |
|        enviada!        |
|                        |
|                        |
|                        |
|                        |
|                        |
==========================
            ");
                }
                else if (opcao == 3)
                {
                    xiaomi.ligado = false;
                    Console.WriteLine($@"
__________________________
|           o            |
|                        |
|                        |
| modelo {xiaomi.modelo} |
| cor {xiaomi.cor}             |
| tamanho {xiaomi.tamanho}              |
|                        |
|                        |
|                        |
|                        |
|                        |
==========================
            ");
                }
                else if (opcao == 0)
                {
                    xiaomi.ligado = true;
                    Console.WriteLine($@"
__________________________
|           o            |
|                        |
|                        |
|                        |
|                        |
|       desligado        |
|          :(            |
|                        |
|                        |
|                        |
|                        |
==========================
            ");
                }
            }
        }
    }
}


