using BasisCore;

using System;
using Core.Library.LibraryUtil;

namespace TestProject1.Model
{
    public class Mercado : ModelBase
    {
        public String Nome { get; set; }
        public Int16 Logradouro { get; set; }

        public String[] rua;
        public String[] Rua
        {
            get
            {
                if (rua == null)
                {
                    rua = new String[]{
                        LibraryStrings.LogradouroAlameda,
                        LibraryStrings.LogradouroAvenida,
                        LibraryStrings.LogradouroBeco,
                        LibraryStrings.LogradouroBoulevard,
                        LibraryStrings.LogradouroCais,
                        LibraryStrings.LogradouroCaminho,
                        LibraryStrings.LogradouroCampo,
                        LibraryStrings.LogradouroEscada,
                        LibraryStrings.LogradouroEstrada,
                        LibraryStrings.LogradouroFavela,
                        LibraryStrings.LogradouroFazenda,
                        LibraryStrings.LogradouroFloresta,
                        LibraryStrings.LogradouroIlha,
                        LibraryStrings.LogradouroJardim,
                        LibraryStrings.LogradouroLadeira,
                        LibraryStrings.LogradouroLargo,
                        LibraryStrings.LogradouroLoteamento,
                        LibraryStrings.LogradouroLugar,
                        LibraryStrings.LogradouroMorro,
                        LibraryStrings.LogradouroParque,
                        LibraryStrings.LogradouroPasseio,
                        LibraryStrings.LogradouroPraca,
                        LibraryStrings.LogradouroPraia,
                        LibraryStrings.LogradouroRecanto,
                        LibraryStrings.LogradouroRodovia,
                        LibraryStrings.LogradouroRua,
                        LibraryStrings.LogradouroServidao,
                        LibraryStrings.LogradouroTravessa,
                        LibraryStrings.LogradouroVia,
                        LibraryStrings.LogradouroVila
                    };
                }
                return rua;
            }
            set
            {
                rua = value;
            }
        }
        public Int16 Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String[] estado;
        public String[] Estado
        {
            get
            {
                if (estado == null)
                {
                    estado = new String[] { 
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
                return estado;
            }
            set
            {
                estado = value;
            }
        }
    }
}
