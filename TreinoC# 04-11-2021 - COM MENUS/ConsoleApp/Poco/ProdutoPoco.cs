using System;

namespace ConsoleApp.Poco
{
    public class ProdutoPoco : CamposComuns
    {
    private int produtoID;
    
    private int subCategoriaID;

    private int categoriaID;

        public int ProdutoID 
        { 
            get => produtoID; 
            set => produtoID = value; 
            }
        public int SubCategoriaID 
        { 
            get => subCategoriaID; 
            set => subCategoriaID = value; 
        }
        public int CategoriaID 
        { 
            get => categoriaID; 
            set => categoriaID = value; 
        }
    }
}
