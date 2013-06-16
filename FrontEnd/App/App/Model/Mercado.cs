

using System;
using Core.Library.LibraryUtil;
using Core.Basis.BasisCore;

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
                        
                        
                        //AppResources.LogradouroAlameda,
                        //AppResources.LogradouroAvenida,
                        //AppResources.LogradouroBeco,
                        //AppResources.LogradouroBoulevard,
                        //AppResources.LogradouroCais,
                        //AppResources.LogradouroCaminho,
                        //AppResources.LogradouroCampo,
                        //AppResources.LogradouroEscada,
                        //AppResources.LogradouroEstrada,
                        //AppResources.LogradouroFavela,
                        //AppResources.LogradouroFazenda,
                        //AppResources.LogradouroFloresta,
                        //AppResources.LogradouroIlha,
                        //AppResources.LogradouroJardim,
                        //AppResources.LogradouroLadeira,
                        //AppResources.LogradouroLargo,
                        //AppResources.LogradouroLoteamento,
                        //AppResources.LogradouroLugar,
                        //AppResources.LogradouroMorro,
                        //AppResources.LogradouroParque,
                        //AppResources.LogradouroPasseio,
                        //AppResources.LogradouroPraca,
                        //AppResources.LogradouroPraia,
                        //AppResources.LogradouroRecanto,
                        //AppResources.LogradouroRodovia,
                        //AppResources.LogradouroRua,
                        //AppResources.LogradouroServidao,
                        //AppResources.LogradouroTravessa,
                        //AppResources.LogradouroVia,
                        //AppResources.LogradouroVila
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
