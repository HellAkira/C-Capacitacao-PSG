using System;
using ConsoleApp.Service;

namespace ConsoleApp.Principal
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("##                -- Menu Categoria --##\n");
            Console.WriteLine("\n                  =========================");
            Console.WriteLine("                  |     1 - Categoria       |");
            Console.WriteLine("                  |     2 - SubCategoria        |");
            Console.WriteLine("                  |     3 - Produto      |");
            Console.WriteLine("                  =========================\n");

            int id = Convert.ToInt32(Console.ReadLine());
            switch (id){
            case 1 : CategoriaService servicocat = new CategoriaService();
                    servicocat.exibirMenu();
                     Console.ReadLine();
                     break;
            case 2 : SubCategoriaService servicosub = new SubCategoriaService();
                     servicosub.exibirMenu();
                     Console.ReadLine();
                     break;
            case 3 : ProdutoService servicopro = new ProdutoService();
                    servicopro.exibirMenu();
                     Console.ReadLine();
                     break;    
            
            }
        }
    }
}
