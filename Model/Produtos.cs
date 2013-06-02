using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using BasisCore;

namespace MarketHelperClient.Model
{
    public class Produtos : ModelBase
    {
        public String Nome { get; set; }

        public Double Preco { get; set; }

        public Classe Classe { get; set; }

        public SubClasse SubClasse { get; set; }


    }
}
