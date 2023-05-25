using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2
{
    internal class Program
    {
        public static void Ex1()
        {
            int quant = 1, quantt = 0, v, vt, vtt = 0;

            do
            {
                Console.WriteLine("Digite a quantidade do novo produto: ");
                quant = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preço do novo produto: ");
                v = int.Parse(Console.ReadLine());

                vt = v * quant;
                vtt += vt;
                quantt += quant;

            } while (quant > 0);
            Console.WriteLine("Quantidade total de itens adquiridos:" + quantt);
            Console.WriteLine("Valor total da compra:" + vtt);
            Console.ReadKey();
        }
        public static void Ex2()
        {
            int nItens, parar = 2;
            float menorV, maiorV, p;
            string nome = "", nomeMa = "", nomeMe = "";

            menorV = float.MaxValue;
            maiorV = float.MinValue;

            do
            {
                Console.WriteLine("Digite o produto: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a quantidade do produto: ");
                nItens = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preço do produto: ");
                p = float.Parse(Console.ReadLine());

                float total = nItens * p;

                if (total > maiorV)
                {
                    maiorV = total;
                    nomeMa = nome;
                }
                else if (total < menorV)
                {
                    menorV = total;
                    nomeMe = nome;
                }
                Console.WriteLine("Digite 1 para sair e 2 para continuar");
                parar = int.Parse(Console.ReadLine());
            } while (parar != 1);
            Console.WriteLine("Maior quantia investida no produto " + nomeMa + " é: " + maiorV);
            Console.WriteLine("Menor quantia investida no produto " + nomeMe + " é: " + menorV);
            Console.ReadKey();
        }
        public static void Ex3()
        {
            int av = 0, cont = 1;
            float p, peso, speso = 0, h;

            do
            {
                Console.WriteLine("Digite o número de avaliações que planeja dar esse bimestre: ");
                av = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso da avaliação " + cont++);
                peso = float.Parse(Console.ReadLine());

                speso += peso;
            } while (cont <= av);

            if (speso < 100)
            {
                Console.WriteLine("A soma total dos pesos é insuficiente (não chaga a 100%)");
            }
            else if (speso > 100)
            {
                Console.WriteLine("A soma total dos pesos é excedente (maior que 100%)");
            }
            else
            {
                Console.WriteLine("A soma total dos pesos é adequada (igual 100%)");
            }
            Console.ReadKey();
        }
        public static void Ex4()
        {
            string sg;

            Console.WriteLine("===MENU===");
            Console.WriteLine("RS");
            Console.WriteLine("SC");
            Console.WriteLine("PR");
            Console.WriteLine("Digite uma sigla de estado: ");
            sg = Console.ReadLine();

            switch (sg)
            {
                case "RS":
                    Console.WriteLine("Rio Grande do Sul");
                    break;
                case "SC":
                    Console.WriteLine("Santa Catarina");
                    break;
                case "PR":
                    Console.WriteLine("Paraná");
                    break;
                default:
                    Console.WriteLine("Sigla inválida");
                    break;
            }
            Console.ReadKey();
        }
        public static void Ex5()
        {
            int num, dia;

            Console.WriteLine("Digite um número inteiro ente 1 e 12 que representará um mês do ano: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Verão");
                    break;
                case 2:
                    Console.WriteLine("Verão");
                    break;
                case 3:
                    Console.WriteLine("Digite um dia");
                    dia = int.Parse(Console.ReadLine());

                    if (dia < 20)
                    {
                        Console.WriteLine("Verão");
                    }
                    else
                    {
                        Console.WriteLine("Outono");
                    }
                    break;
                case 4:
                    Console.WriteLine("Outono");
                    break;
                case 5:
                    Console.WriteLine("Outono");
                    break;
                case 6:
                    Console.WriteLine("Digite um dia");
                    dia = int.Parse(Console.ReadLine());

                    if (dia < 21)
                    {
                        Console.WriteLine("Outono");
                    }
                    else
                    {
                        Console.WriteLine("Inverno");
                    }
                    break;
                case 7:
                    Console.WriteLine("Inverno");
                    break;
                case 8:
                    Console.WriteLine("Inverno");
                    break;
                case 9:
                    Console.WriteLine("Digite um dia");
                    dia = int.Parse(Console.ReadLine());

                    if (dia < 23)
                    {
                        Console.WriteLine("Inverno");
                    }
                    else
                    {
                        Console.WriteLine("Primavera");
                    }
                    break;
                case 10:
                    Console.WriteLine("Primavera");
                    break;
                case 11:
                    Console.WriteLine("Primavera");
                    break;
                case 12:
                    Console.WriteLine("Digite um dia");
                    dia = int.Parse(Console.ReadLine());

                    if (dia < 22)
                    {
                        Console.WriteLine("Primavera");
                    }
                    else
                    {
                        Console.WriteLine("Verão");
                    }
                    break;
            }
            Console.ReadKey();
        }
        public static void Ex6()
        {
            float peso, h, IMC;

            Console.WriteLine("Digite o seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura em metros: ");
            h = float.Parse(Console.ReadLine());

            IMC = peso / (h * h);

            if (IMC < 18.5f)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (IMC >= 18.5f && IMC <= 24.9f)
            {
                Console.WriteLine("Você está com o peso normal");
            }
            else if (IMC >= 25.0f && IMC <= 29.9f)
            {
                Console.WriteLine("Você está sobre peso");
            }
            else if (IMC >= 30.0f && IMC <= 34.9f)
            {
                Console.WriteLine("Você está com obesidade grau 1");
            }
            else if (IMC >= 35.0f && IMC <= 39.9f)
            {
                Console.WriteLine("Você está com obesidade grau 2");
            }
            else if (IMC >= 40.0f)
            {
                Console.WriteLine("Você está com obesidade grau 3 (mórbida)");
            }
            Console.ReadKey();
        }
        public static void Ex7()
        {
            int i = 0, N;

            Console.WriteLine("Digite um número: ");
            N = int.Parse(Console.ReadLine());

            do
            {
                i++;
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            } while (N > 0);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine("Quer continuar: 0-não, 1-sim");
                x = int.Parse(Console.ReadLine());
                Console.ReadKey();

                int op;

                Console.WriteLine("Exercício 1");
                Console.WriteLine("Exercício 2");
                Console.WriteLine("Exercício 3");
                Console.WriteLine("Exercício 4");
                Console.WriteLine("Exercício 5");
                Console.WriteLine("Exercício 6");
                Console.WriteLine("Exercício 7");
                Console.WriteLine("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Obrigada por usar meu programa!");
                        break;
                    case 1:
                        Ex1();
                        break;
                    case 2:
                        Ex2();
                        break;
                    case 3:
                        Ex3();
                        break;
                    case 4:
                        Ex4();
                        break;
                    case 5:
                        Ex5();
                        break;
                    case 6:
                        Ex6();
                        break;
                    case 7:
                        Ex7();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                } 
            }while (x != 0);
        }
    }
}
