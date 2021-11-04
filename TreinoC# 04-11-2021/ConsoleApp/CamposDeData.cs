using System;

namespace ConsoleApp
{
    public abstract class CamposDeData
    {
        protected DateTime dataInsert;

        public DateTime DataInsert
        {
            get => this.dataInsert;
            set => this.dataInsert = value;
        }
    }
}
