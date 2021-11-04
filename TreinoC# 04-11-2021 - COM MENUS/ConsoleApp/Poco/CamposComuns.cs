using System;

namespace ConsoleApp.Poco
{
    public abstract class CamposComuns : CamposDeData
    {
        protected String descricao;

        public string Descricao 
        { 
            get => this.descricao;
            set => this.descricao = value;
        }
    }
}
