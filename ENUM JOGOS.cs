using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDLLCalculadora
{
    public class Calculadora
    {

        #region [Propriedades Publicas -> Encapsulamento]
        private double N1 { get; set; }//Propriedade -> Encapsulamento
        #endregion
        #region [Atributos da Classe -> de regra devem ser privados]
        private double N2; //atributo      
        #endregion
        #region [getters e setters -> Encapsulamento ]
        public double SetN2(double n2)
        {
            this.N2 = n2;
        }
        public double Getn2()
        {
            return this.N2;
        }
    }
    #endregion
    #region [METODOS PUBLICOS DA CLASSE]       
    public double Somar(double n1, double n2)
    {
        double Adicao = 0;
        this.N1 = n1; this.N2 = n2;
        Adicao = this.N1 + this.N2;
        return Adicao;
    }
    #endregion
}