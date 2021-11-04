using System;
using ConsoleApp.DAO;
using ConsoleApp.Poco;

namespace ConsoleApp.Service
{
    public class SubCategoriaService
    {
        private SubCategoriaDAO dao;

        public SubCategoriaService()
        {
            dao = new SubCategoriaDAO();
        }


        private int printMenu()
        {

            Console.WriteLine("##                -- Menu SubCategoria --##\n");
            Console.WriteLine("\n                  =========================");
            Console.WriteLine("                  |     1 - Inserir       |");
            Console.WriteLine("                  |     2 - Listar        |");
            Console.WriteLine("                  |     3 - Detalhes      |");
            Console.WriteLine("                  |     4 - Alterar       |");
            Console.WriteLine("                  |     5 - Excluir       |");
            Console.WriteLine("                  |     0 - Sair          |");
            Console.WriteLine("                  =========================\n");

            return Convert.ToInt32(Console.ReadLine());
        }

        private void printMenuInserir()
        {


            Console.WriteLine("Digite qual o ID da SubCategoria");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite qual a descricao");
            String desc = Console.ReadLine();

            SubCategoriaPoco poco = new SubCategoriaPoco();
            poco.SubCategoriaID = id;
            poco.Descricao = desc;
            this.dao.Create(poco);

            SubCategoriaPoco item = this.dao.Read(id);

            if (this.dao.Read(id) != null)
            {
                Console.WriteLine("\nSubCategoria Adicionada com sucesso");
            }
            else
            {
                Console.WriteLine("\nErro ao adicionar a SubCategoria");
            }

        }

        public void exibirMenu(){
        bool sair = false;
        do{
            
           int op = this.printMenu();
           
           switch(op){
               case 1:
                   this.printMenuInserir();
                       break;
               case 2:
                   this.printMenuListar();
                       break;
               case 3:
                   this.printMenuDetalhar();
                       break;
               case 4:
                   this.printMenuAlterar();
                       break;
               case 5:
                   this.printMenuExcluir();
                       break;
               case 0:
                   sair = true;
                       break;
               default:
                   Console.WriteLine("Opção selecionada não disponível. Tente novamente.");
                       break;
         
           }
        
        }
        while(sair != true);
    }

        private void printMenuListar()
        {



            foreach (SubCategoriaPoco item in this.dao.ReadAll())
            {
                Console.WriteLine("                 # Menu SubCategoria - Listar #\n");
                Console.WriteLine("\n                  =========================");
                Console.WriteLine("                  |     SubCategoria ID: {0}\n", item.SubCategoriaID);
                Console.WriteLine("                  |     Categoria ID: {0}\n", item.CategoriaID);
                Console.WriteLine("                  |     Descricao: {0}\n", item.Descricao);
                Console.WriteLine("                  =========================\n");
            }





        }


        private void printMenuDetalhar()
        {
            Console.WriteLine("Digite Qual SubCategoria");
            int op = Convert.ToInt32(Console.ReadLine()); ;

            SubCategoriaPoco item = this.dao.Read(op);
            if (item == null)
            {
                Console.WriteLine("Opção selecionada não disponível. Tente novamente.");
            }

            Console.WriteLine("                 # Menu SubCategoria - Listar #\n");
            Console.WriteLine("\n                  =========================");
            Console.WriteLine("                  |     SubCategoria ID: {0}\n", item.SubCategoriaID);
            Console.WriteLine("                  |     Categoria ID: {0}\n", item.CategoriaID);
            Console.WriteLine("                  |     Descricao: {0}\n", item.Descricao);
            Console.WriteLine("                  =========================\n");

        }


        private void printMenuAlterar()
        {


            Console.WriteLine("Digite Qual SubCategoria");
            int op = Convert.ToInt32(Console.ReadLine());
            SubCategoriaPoco item = this.dao.Read(op);
            if (item == null)
            {
                Console.WriteLine("Opção selecionada não disponível. Tente novamente.");
            }

            Console.WriteLine("                 # Menu SubCategoria - Listar #\n");
            Console.WriteLine("\n                  =========================");
            Console.WriteLine("                  |     SubCategoria ID: {0}\n", item.SubCategoriaID);
            Console.WriteLine("                  |     Categoria ID: {0}\n", item.CategoriaID);
            Console.WriteLine("                  |     Descricao: {0}\n", item.Descricao);
            Console.WriteLine("                  =========================\n");


            Console.WriteLine("Digite qual a descricao\n");

            String desc = Console.ReadLine();
            item.Descricao = desc;




        }
        private void printMenuExcluir()
        {

            Console.WriteLine("Digite Qual SubCategoria");
            int op = Convert.ToInt32(Console.ReadLine());
            SubCategoriaPoco item = this.dao.Read(op);
            if (item == null)
            {
                Console.WriteLine("Opção selecionada não disponível. Tente novamente.");
            }

            Console.WriteLine("                 # Menu SubCategoria - Listar #\n");
            Console.WriteLine("\n                  =========================");
            Console.WriteLine("                  |     SubCategoria ID: {0}\n", item.SubCategoriaID);
            Console.WriteLine("                  |     Categoria ID: {0}\n", item.CategoriaID);
            Console.WriteLine("                  |     Descricao: {0}\n", item.Descricao);
            Console.WriteLine("                  =========================\n");

            this.dao.Delete(item.SubCategoriaID);

            SubCategoriaPoco itemDeletado = this.dao.Read(op);

            if (itemDeletado == null)
            {

                Console.WriteLine("Item Deletado");
            }

        }


    }
}
