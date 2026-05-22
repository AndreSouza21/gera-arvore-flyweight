using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorestaSim
{
    public class EspecieArvore
    {
        //Estado imutavel
        private string nome;
        private string tipo;
        private double alturaMedia;
        private double diametroMedio;
        private int numeroDeGalhos;
        private string textura;
        private string folhagem;
        private string cor;

        public EspecieArvore(string nome, string tipo, double alturaMedia,
                             double diametroMedio, int numeroDeGalhos,
                             string textura, string folhagem, string cor)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.alturaMedia = alturaMedia;
            this.diametroMedio = diametroMedio;
            this.numeroDeGalhos = numeroDeGalhos;
            this.textura = textura;
            this.folhagem = folhagem;
            this.cor = cor;
        }

        public string GetNome() 
        { 
            return nome; 
        }
        public string GetTipo() 
        { 
            return tipo; 
        }
        public double GetAlturaMedia() 
        {
            return alturaMedia; 
        }
        public double GetDiametroMedio() 
        {
            return diametroMedio; 
        }
        public int GetNumeroDeGalhos() 
        { 
            return numeroDeGalhos; 
        }
        public string GetTextura() 
        { 
            return textura; 
        }
        public string GetFolhagem() 
        { 
            return folhagem; 
        }
        public string GetCor() 
        { 
            return cor; 
        }
    }
}
