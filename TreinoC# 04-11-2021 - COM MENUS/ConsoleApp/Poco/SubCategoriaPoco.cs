namespace ConsoleApp.Poco
{
    public class SubCategoriaPoco : CamposComuns
    {
        private int subCategoriaID;
        private int categoriaID;

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
