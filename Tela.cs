using System;
using System.Collections.Generic;
using System.Globalization;
using dominio;
using System.Text;

namespace UdemyAula48
{
    // Classe responsavel por conter operações que interagem com o usuário
    // no modo console

    class Tela
    {
        /// <summary>
        /// Essa função mostra o menu e as opções para seleção
        /// </summary>
        public static void mostrarMenu()
        {
            Console.WriteLine("1 – Listar artistas ordenadamente");
            Console.WriteLine("2 – Cadastrar artista");
            Console.WriteLine("3 – Cadastrar filme");
            Console.WriteLine("4 – Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");

        }

        /// <summary>
        /// Essa função mostra os artistas cadastrados, código e respectivos cachês
        /// </summary>
        public static void mostrarArtista()
        {
            for (int i=0; i<Program.artistas.Count; i++)
            {
                Console.WriteLine(Program.artistas[i]);
            }
        Console.WriteLine();
        
        }
    }
}