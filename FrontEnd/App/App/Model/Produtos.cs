using System;
using Core.Basis.BasisCore;


namespace MarketHelperClient.Model
{
    public class Produtos : ModelBase
    {
        public String Nome { get; set; }
        public Int16 Quantidade { get; set; }
        public Double Preco { get; set; }
        public Classe Classe { get; set; }
        public SubClasse SubClasse { get; set; }
    }
}
