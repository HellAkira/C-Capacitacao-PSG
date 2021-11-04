using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Poco;
using ConsoleApp.FakeDB;

namespace ConsoleApp.DAO
{
    public class ProdutoDAO
    {
        public ProdutoDAO()
        {
            var a = EstoqueFakeDB.Produtos;
        }

        public void Create(ProdutoPoco poco)
        {
            EstoqueFakeDB.Produtos.Add(poco);
        }

        private ProdutoPoco Procura(int id)
        {
            return EstoqueFakeDB.Produtos
                  .SingleOrDefault(c => c.ProdutoID == id);
        }
        public ProdutoPoco Read(int ProdutoID)
        {
            return this.Procura(ProdutoID);

        }
        public List<ProdutoPoco> ReadAll()
        {

            return EstoqueFakeDB.Produtos;

        }

        public void Update(ProdutoPoco poco)
        {

            ProdutoPoco Busca = this.Procura(poco.ProdutoID);

            EstoqueFakeDB.Produtos.Remove(Busca);
            EstoqueFakeDB.Produtos.Add(poco);

        }

        public void Delete(int ProdutoID)
        {
            ProdutoPoco Busca = this.Procura(ProdutoID);
            EstoqueFakeDB.Produtos.Remove(Busca);
        }
        

    }
}

