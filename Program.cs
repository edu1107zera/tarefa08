using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade08
{
    class Program
    {
        static List<string> nomes = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de usuários!");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Buscar");
            Console.WriteLine("3 - Deletar");
            Console.WriteLine("4 - Alterar");
            Console.WriteLine("5 - listar");
            int opcao = Int32.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome que deseja cadastrar:");
                nomes.Add(Console.ReadLine());
                Console.WriteLine("Cadastro feito com sucesso");
                Main(null);
            }
            if (opcao == 2)
            {
                if (nomes.Count > 0)
                {
                    Console.WriteLine("Digite a posição que deseja buscar:");
                    int busca = Int32.Parse(Console.ReadLine());

                    if (busca >= 0 && busca < nomes.Count)
                    {
                        Console.WriteLine(nomes[busca]);
                        Main(null);
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida");
                    }
                }
                else
                {
                    Console.WriteLine("A lista está vazia");
                }
            }



            if (opcao == 3)
            {
                Console.WriteLine("Qual posição deseja deletar?");
                int del;
                del = int.Parse(Console.ReadLine());
                nomes.RemoveAt(del - 1);
                Console.WriteLine("Opção deletada com sucesso!!");
                Main(null);
            }
            if (opcao == 4)
            {
                int contador = 0;
                string nome;
                Console.WriteLine("Qual o nome que voce deseja altera?");
                nome =   Console.ReadLine();

                while(contador<nomes.Count)
                {
                    if (nome == nomes[contador])
                    {
                        Console.WriteLine("insira um novo nome:");
                        nome = Console.ReadLine();
                        nomes[contador] = nome;
                    }
                    contador++;

                   

                }
            }

          if(opcao == 5)
          {

            
             int contador1 = 0;
             while(contador1<nomes.Count)
             {
                 Console.WriteLine("nomes:"+nomes[contador1]);
                 contador1++;
                    
             }
                Main(null);
          }
           
            Console.ReadKey();
        }














    }
}

