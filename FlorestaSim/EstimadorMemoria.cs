using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorestaSim
{
    
    public static class EstimadorMemoria
    {
        // .NET: overhead de objeto = 16 bytes; string = 26 bytes + 2 bytes/char
        private static int TamanhoString(int chars) { return 26 + chars * 2; }

        private const int CHARS_NOME     = 16;
        private const int CHARS_TIPO     = 14;
        private const int CHARS_TEXTURA  = 20;
        private const int CHARS_FOLHAGEM = 20;
        private const int CHARS_COR      = 18;

        // EspecieArvore (imutavel): 5 strings + 2 doubles + 1 int + overhead
        public static long TamanhoEspecieArvore()
        {
            return 16
                 + TamanhoString(CHARS_NOME)
                 + TamanhoString(CHARS_TIPO)
                 + TamanhoString(CHARS_TEXTURA)
                 + TamanhoString(CHARS_FOLHAGEM)
                 + TamanhoString(CHARS_COR)
                 + 8   // AlturaMedia
                 + 8   // DiametroMedio
                 + 4   // NumeroDeGalhos
                 + 4;  // padding
        }

        // InstanciaArvore (mutavel): 3 doubles + 2 ints + 1 referencia + overhead
        public static long TamanhoInstanciaArvore()
        {
            return 16  // overhead
                 + 8   // AlturaReal
                 + 8   // DiametroReal
                 + 4   // GalhosReais
                 + 4   // Idade
                 + 8   // Saude
                 + 8;  // referencia ao Flyweight (ponteiro 64-bit)
        }

        // ArvoreSemFlyweight: tudo junto, sem compartilhamento
        public static long TamanhoArvoreSemFlyweight()
        {
            return 16
                 + TamanhoString(CHARS_NOME)
                 + TamanhoString(CHARS_TIPO)
                 + TamanhoString(CHARS_TEXTURA)
                 + TamanhoString(CHARS_FOLHAGEM)
                 + TamanhoString(CHARS_COR)
                 + 8   // AlturaMedia
                 + 8   // DiametroMedio
                 + 4   // NumeroDeGalhos
                 + 8   // AlturaReal
                 + 8   // DiametroReal
                 + 4   // GalhosReais
                 + 4   // Idade
                 + 8;  // Saude
        }

        public static long MemoriaComFlyweight(int totalArvores, int totalEspecies)
        {
            return totalEspecies * TamanhoEspecieArvore()
                 + totalArvores  * TamanhoInstanciaArvore();
        }

        public static long MemoriaSemFlyweight(int totalArvores)
        {
            return totalArvores * TamanhoArvoreSemFlyweight();
        }
    }
}
