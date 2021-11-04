namespace ConsoleApp.Poco
{
    public class CategoriaPoco : CamposComuns
    {
        private int categoriaID;

        public int CategoriaID 
        {
            get => categoriaID;
            set => categoriaID = value;
        }

        public CategoriaPoco()
        {}
    }
}
