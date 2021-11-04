using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Poco;
using ConsoleApp.FakeDB;

namespace ConsoleApp.DAO
{
    public class CategoriaDAO
    {
        public CategoriaDAO()
        {
            var a = EstoqueFakeDB.Categorias;
        }

        public void Create(CategoriaPoco poco)
        {
            EstoqueFakeDB.Categorias.Add(poco);
        }

        private CategoriaPoco Procura(int id)
        {
            return EstoqueFakeDB.Categorias
                  .SingleOrDefault(c => c.CategoriaID == id);
        }
        public CategoriaPoco Read(int categoriaID)
        {
            return this.Procura(categoriaID);

        }
        public List<CategoriaPoco> ReadAll()
        {

            return EstoqueFakeDB.Categorias;

        }

        public void Update(CategoriaPoco poco)
        {

            CategoriaPoco busca = this.Procura(poco.CategoriaID);

            EstoqueFakeDB.Categorias.Remove(busca);
            EstoqueFakeDB.Categorias.Add(poco);

        }

        public void Delete(int categoriaID)
        {
            CategoriaPoco busca = this.Procura(categoriaID);
            EstoqueFakeDB.Categorias.Remove(busca);
        }


    }
}

