using System;
using System.Collections.Generic;
using System.Globalization;
using dominio;
using System.Text;

namespace UdemyAula48
{   
    class Program
   {
        //Cria a lista que será preenchida com as 3 infos dos artitas, em linha/string
        public static List<Artista> artistas = new List<Artista>();
        
        //Cria a lista que será preenchida com os códigos dos filmes
        public static List<int> codigofilmes = new List<int>();

        //não sei pq eu criei uma lista só com os códigos dos filmes, mas de qualquer forma
        //eu vou criar uma lista de filmes
        public static List<Filme> filmes = new List<Filme>();

        //Cria a lista que será preenchida com as participações
        public static List<int> participacoes = new List<int>();

        static void Main(string[] args){

            int opcao = 0;

            //Cadastro dos artistas obrigatórios do exercício
            artistas.Add(new Artista(101, "Scarlett Jowansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            //artistas.Sort();
           
            //Mostra o menu de opções
            Tela.mostrarMenu();

            while (opcao != 5)
            {
                Console.WriteLine();
                Console.Write("Digite a opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    //Mostra os artistas cadastrados na lista até o momento
                    Tela.mostrarArtista();
                }
                else if (opcao == 2)
                {
                    Console.Write("insira o novo codigo do artista: ");
                    int Codigo = int.Parse(Console.ReadLine());

                    Console.Write("insira o nome do artista: ");
                    string Name = Console.ReadLine();

                    Console.Write("insira o cachê do artista: ");
                    double Cache = double.Parse(Console.ReadLine());
                    

                    Artista A = new Artista(Codigo, Name, Cache);

                    artistas.Add(A);

                }
                else if (opcao == 3)
                {
                    
                    Console.Write("insira o novo codigo do filme: ");
                    int CodigoFilme = int.Parse(Console.ReadLine());

                    codigofilmes.Add(CodigoFilme);

                    

                    Console.Write("insira o novo título do filme: ");
                    string Titulo = Console.ReadLine();
                    //acho que eu tenho de criar o título do filme, ano, etc aqui

                    Console.Write("insira o ano do filme: ");
                    int Ano = int.Parse(Console.ReadLine());

                    Filme F = new Filme(CodigoFilme, Titulo, Ano);

                    filmes.Add(F);




                    Console.Write("Quantos artistas participam do filme? ");
                    int quantidadeArtistas = int.Parse(Console.ReadLine());

                    double totalPedido = 0;

                    List<int> itens = new List<int>();

                    for(int i = 0; i< quantidadeArtistas; i++)
                    {
                        Console.Write("Informe o codigo do artista: ");
                        int Codigo = int.Parse(Console.ReadLine());

                        int pos = Program.artistas.FindIndex(x => x.Codigo == Codigo);

                        Console.WriteLine();
                        Console.WriteLine(artistas[pos]);
                        Console.WriteLine();

                        Console.Write("Informe o desconto no cachê: ");
                        double desconto = double.Parse(Console.ReadLine());

                        Console.Write("Informe o cachê do artista: ");
                        double CacheProvisorio = double.Parse(Console.ReadLine());
                        
                        //Participacao part = new Participacao(Desconto, Program.artistas[pos], F);
                        //F.participacoes.Add(part);
                        
                        Participacao I = new Participacao(desconto, artistas[pos],F);

                        double X = I.Custo(desconto, CacheProvisorio);

                        Console.WriteLine();
                        Console.WriteLine("O custo da participação é R$" + X);
                        Console.WriteLine();

                        //totalPedido = totalPedido + X;
                        //itens.Add(i);
                    }

                    //Console.WriteLine("O valor total do pedido eh R$ " + totalPedido);

            Console.ReadLine();

                }
                else if (opcao == 4)
                {
                    Tela.mostrarArtista();

                    
            /* int pedido;
            * Console.WriteLine("Qual pedido? ");
            * pedido = Int.Parse(Console.ReadLine());
            Console.WriteLine(Pedido.pedido);
             */
        }
                else if (opcao == 5)
                {
                    Console.WriteLine("Fim do programa.");
                }
                else
                {
                    Console.WriteLine("Comando inválido");
                }
            }

            Console.ReadLine();
        

        }
    }
}



