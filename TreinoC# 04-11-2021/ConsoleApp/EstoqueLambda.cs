using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class EstoqueLambda
    {
        public EstoqueLambda()
        {
            var c = EstoqueFakeDB.Categorias;
            var s = EstoqueFakeDB.SubCategorias;
            var p = EstoqueFakeDB.Produtos;
        }

        public void TestarExibicao(){
        this.exibirCategorias();
        Console.WriteLine("Selecione a Categoria (ID) para exibir as SubCategorias disponíveis:");
        int catid = Convert.ToInt32(Console.ReadLine());
        if ((catid != 1) && (catid != 2) && (catid != 3)){
            Console.WriteLine("\tA Categoria selecionada não está disponível.");
        }
        else{
            this.exibirSubCategorias(catid);
            Console.WriteLine("\t\tSelecione a SubCategoria (ID) para exibir os produtos disponíveis:");
            int subcatid = Convert.ToInt32(Console.ReadLine());;
            this.exibirProdutos(subcatid);
        }        
    }
        private void exibirCategorias()
        {
            Console.WriteLine("As seguintes Categorias estão disponíveis:");
            Console.WriteLine("------------------------------------------");

            EstoqueFakeDB.Categorias
                    .Where(c => c.CategoriaID > 0 && c.CategoriaID <= 3)
                    .ToList()
                    .ForEach(cat => {
                Console.WriteLine("Categoria ID: {0}" , cat.CategoriaID);
                Console.WriteLine("Descrição: {0}", cat.Descricao);
                Console.WriteLine("------------------------------------------");
                    });
        }
            private void exibirSubCategorias(int catid){
        EstoqueFakeDB.SubCategorias
                .Where(sub => sub.CategoriaID == catid)
                .ToList()
                .ForEach(subcat => {
                    Console.WriteLine("\tSubCategoria ID: " + subcat.SubCategoriaID);
                    Console.WriteLine("\tCategoria ID: " + subcat.CategoriaID);
                    Console.WriteLine("\tDescrição: " + subcat.Descricao);
                    Console.WriteLine("\t------------------------------------------");
                });
        }
                private void exibirProdutos(int subcatid){
        EstoqueFakeDB.Produtos
                .Where(pro => pro.SubCategoriaID == subcatid)
                .ToList()
                .ForEach(prod => {
                    Console.WriteLine("\t\tProduto ID: " + prod.ProdutoID);
                    Console.WriteLine("\t\tSubCategoria ID: " + prod.SubCategoriaID);
                    Console.WriteLine("\t\tCategoria ID: " + prod.CategoriaID);
                    Console.WriteLine("\t\tDescrição: " + prod.Descricao);
                    Console.WriteLine("\t\t------------------------------------------");
                });
    }  


    }
}
