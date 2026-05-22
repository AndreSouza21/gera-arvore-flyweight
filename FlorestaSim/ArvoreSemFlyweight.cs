using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorestaSim
{
    // EXEMPLO DE ESTRUTURA SEM USAR O FLYWEIGHT    
    public class ArvoreSemFlyweight
    {
        //DUPLICA TUDO OQUE ERA IMUTAVEL
        private string nome;            
        private string tipo;
        private double auraMedia;
        private double diametroMedio;
        private int numeroDeGalhos;
        private string textura;
        private string folhagem;
        private string cor;            


        // ESTADO MUTAVEL
        private double alturaReal;
        private double diametroReal;
        private int galhosReais;
        private int idade;
        private double saude;          
    }
}
