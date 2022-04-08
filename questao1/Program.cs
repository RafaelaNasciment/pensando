using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            
            Console.WriteLine("Bem vindo ao PENSANDO!");
            Console.WriteLine("Escolha uma das opcoes abaixo e verifique: ");
            Console.WriteLine("1 - O maior valor de dois numeros\n2 - Se o valor é negativo ou positivo");
            Console.WriteLine("3 - Se é Masculino ou Feminino\n4 - Se é vogal ou consoante");
            Console.WriteLine("5 - Se foi aprovado na matéria\n6 - O maior numero inserido");
            Console.WriteLine("0 - Para sair");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: maiorNum(); break;
                case 2: posouNeg(); break;
                case 3: femouMas(); break;
                case 4: vogal(); break;
                case 5: nota(); break;
                case 6: maior(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            //Console.ReadLine();
        }

        static void maiorNum()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo! Digite dois numeros e descobra qual o maior!");
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pensando....");
            Thread.Sleep(3000);
            
            if (num1 == num2) { Console.WriteLine("Poxa, os numeros são iguais, como iremos descobrir assim?"); }
            else if (num1 > num2) { Console.WriteLine($"O maior numero é {num1}"); }
            else { Console.WriteLine($"O maior numero é {num2}"); }
            Console.WriteLine("Pressione ENTER para retornar ao menu");
            Console.ReadLine();
            Menu();
        }

        static void posouNeg()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo! Informe um valor e descubra se é positivo ou negativo!\nQual numero deseja descobrir?");
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("Pensando....");
            Thread.Sleep(3000);
            bool cont = true;
            while(cont == true)
            {
                if (num < 0) 
                { 
                    Console.WriteLine("Informe um numero positivo: ");
                    num = int.Parse(Console.ReadLine());
                }
                else { cont = false; }  
            }
            
            if (num %2 == 1) { Console.WriteLine($"O {num} é positivo!"); }
            else { Console.WriteLine($"O {num} é negativo!"); }
            Console.WriteLine("Pressione ENTER para retornar ao menu");
            Console.ReadLine();
            Menu();
        }
        
        static void femouMas()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo! Informe uma letra e descubra o sexo (F ou M será melhor)");
            var letter = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Pensando....");
            Thread.Sleep(3000);
            bool cont = true;
            while (cont == true)
            {
                if (letter != 'M' && letter != 'F')
                {              
                    Console.WriteLine("Sexo invalido!\nTente novamente: ");
                    letter = char.Parse(Console.ReadLine().ToUpper());
                    Console.Clear();
                    Console.WriteLine("Pensando....");
                    Thread.Sleep(1000);
                }
                else { cont = false; }
            }

            //if (letter != 'M' && letter != 'F') { Console.WriteLine("Sexo invalido!"); }
            if(letter == 'M') { Console.WriteLine("Sexo MASCULINO escolhido!"); }
            else { Console.WriteLine("Sexo FEMININO escolhido!"); }
            Console.WriteLine("Pressione ENTER para retornar ao menu");
            Console.ReadLine();
            Menu();
        }

        static void vogal()
        {
            var array = new[] { "a", "e", "i", "o", "u" };
            //var array = new[] { "aeiou" };
           
            Console.Clear();
            Console.WriteLine("Bem vindo! Informe uma letra e descubra se é vogal ou consoante: ");
            var letter = Console.ReadLine().ToLower();

            Console.WriteLine("Pensando....");
            Thread.Sleep(3000);

            foreach (var item in array)
            {
                if(letter == item){ Console.WriteLine($"A letra >>{letter}<< é uma vogal!"); break; }
                else { Console.WriteLine($"A letra >>{letter}<< é uma consoante!"); break; }
            }
            Console.WriteLine("Pressione ENTER para retornar ao menu");
            Console.ReadLine();
            Menu();
        }
        
        static void nota()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo! Digite suas notas e descubra se foi aprovado!");
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Pensando....");
            Thread.Sleep(3000);

            double media = (nota1 + nota2) / 2.0;

            if(media >= 7.0) { Console.WriteLine($"Parabens sua média é {media} e você está aprovado!"); }
            else if(media == 10.0) { Console.WriteLine($"Parabens sua média é {media} e você está aprovado com DISTINÇÃO!"); }
            else { Console.WriteLine($"Sua média é {media} e infelizmente você não foi aprovado!"); }
            Console.WriteLine("Pressione ENTER para retornar ao menu");
            Console.ReadLine();
            Menu();
        }
        static void maior()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo! Digite 3 numeros e descubra o maior!");
            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());
            teste();
            Console.WriteLine("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());
            testf();
            Console.WriteLine("Digite o terceiro numero: ");
            double num3 = double.Parse(Console.ReadLine());
            testej();

            void teste()
            {
                if (num1 < 0)
                {
                    Console.WriteLine("Tente novamente. Informe numeros maiores que 0! "); Thread.Sleep(1000); maior();
                }
            }
            void testf()
            {
                if (num2 < 0)
                {
                    Console.WriteLine("Tente novamente. Informe numeros maiores que 0! "); Thread.Sleep(1000); maior();
                }
            }
            void testej()
            {
                if (num3 < 0) 
                    { 
                        Console.WriteLine("Tente novamente. Informe numeros maiores que 0! "); Thread.Sleep(1000); maior(); 
                    }
            }
            
            double maiorPrimeiro = Math.Max(num1, num2);

            Console.WriteLine("Pensando....");
            Thread.Sleep(3000);

            if (num3 > maiorPrimeiro){Console.WriteLine($"O maior numero é {num3}");}
            else { Console.WriteLine($"O maior numero é {maiorPrimeiro}"); }

            Console.WriteLine("Pressione ENTER para retornar ao menu");
            Console.ReadLine();
            Menu();
        }
    }
}
