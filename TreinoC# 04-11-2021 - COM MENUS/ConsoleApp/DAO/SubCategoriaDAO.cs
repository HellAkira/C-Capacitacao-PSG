using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Poco;
using ConsoleApp.FakeDB;

namespace ConsoleApp.DAO
{
    public class SubCategoriaDAO    {
        public SubCategoriaDAO()
        {
            var a = EstoqueFakeDB.SubCategorias;
        }

        public void Create(SubCategoriaPoco poco)
        {
            EstoqueFakeDB.SubCategorias.Add(poco);
        }

        private SubCategoriaPoco Search(int id)
        {
            return EstoqueFakeDB.SubCategorias
                  .SingleOrDefault(c => c.SubCategoriaID == id);
        }
        public SubCategoriaPoco Read(int SubCategoriaID)
        {
            return this.Search(SubCategoriaID);

        }
        public List<SubCategoriaPoco> ReadAll()
        {

            return EstoqueFakeDB.SubCategorias;

        }

        public void Update(SubCategoriaPoco poco)
        {

            SubCategoriaPoco Busca = this.Search(poco.SubCategoriaID);

            EstoqueFakeDB.SubCategorias.Remove(Busca);
            EstoqueFakeDB.SubCategorias.Add(poco);

        }

        public void Delete(int SubCategoriaID)
        {
            SubCategoriaPoco Busca = this.Search(SubCategoriaID);
            EstoqueFakeDB.SubCategorias.Remove(Busca);
        }
        

    }
}

