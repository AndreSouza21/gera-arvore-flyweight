using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorestaSim
{
    
    public class InstanciaArvore
    {
        //mutavel de cada arvore
        private double alturaReal;   
        private double diametroReal;   
        private int galhosReais;  
        private int idade;   
        private double saude;   

        //Referencia ao Flyweight (estado imutavel compartilhado)
        private EspecieArvore especie;

        public InstanciaArvore(EspecieArvore especie,
                               double alturaReal, double diametroReal,
                               int galhosReais, int idade, double saude)
        {
            this.especie      = especie;
            this.alturaReal   = alturaReal;
            this.diametroReal = diametroReal;
            this.galhosReais  = galhosReais;
            this.idade        = idade;
            this.saude        = saude;
        }

        public void ExibirDados()
        {
            Console.WriteLine("{0,-22} {1,-16} {2,7:N1} {3,8:N1} {4,7} {5,5} {6,5:N2}",
                              especie.GetNome(), especie.GetTipo(),
                              alturaReal, diametroReal,
                              galhosReais, idade, saude);
        }
    }
}
