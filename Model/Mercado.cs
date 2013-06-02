using BasisCore;
using System;

namespace TestProject1.Model
{
    public class Mercado : ModelBase
    {
        public String Nome { get; set; }
        public Int16 Logradouro { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String[] Estado
        {
            get
            {
                return new String[] { 
                "AC",
                "AL",
                "AP",
                "AM",
                "BA",
                "CE",
                "DF",
                "ES",
                "GO",
                "MA",
                "MT",
                "MS",
                "MG",
                "PA",
                "PB",
                "PR",
                "PE",
                "PI",
                "RJ",
                "RN",
                "RS",
                "RO",
                "RR",
                "SC",
                "SP",
                "SE",
                "TO"};
            }
            set;
        }
    }
}
