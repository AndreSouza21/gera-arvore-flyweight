using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorestaSim
{
    public class FabricaEspecies
    {
        private readonly Dictionary<string, EspecieArvore> _pool
            = new Dictionary<string, EspecieArvore>();

        //Garante que a especie é imutavel e apenas 1 objeto
        public EspecieArvore ObterEspecie(string nome, string tipo,
                                          double alturaMedia, double diametroMedio,
                                          int galhos, string textura,
                                          string folhagem, string cor)
        {
            if (!_pool.ContainsKey(nome))
            {
                _pool[nome] = new EspecieArvore(nome, tipo, alturaMedia,
                                                diametroMedio, galhos,
                                                textura, folhagem, cor);
            }
            return _pool[nome];
        }

        public int TotalEspeciesCriadas { get { return _pool.Count; } }

        public IEnumerable<EspecieArvore> TodasEspecies()
        {
            return _pool.Values;
        }
    }
}
