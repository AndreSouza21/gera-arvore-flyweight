using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorestaSim
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TOTAL_ARVORES = 100000;

            var fabrica = new FabricaEspecies();
            foreach (var d in CatalogoEspecies.Dados)
            {
                fabrica.ObterEspecie(
                    (string)d[0], (string)d[1],
                    (double)d[2], (double)d[3],
                    (int)   d[4],
                    (string)d[5], (string)d[6], (string)d[7]);
            }

            
            Console.WriteLine("Gerando {0:N0} arvores...", TOTAL_ARVORES);

            var especies   = new List<EspecieArvore>(fabrica.TodasEspecies());
            var instancias = new List<InstanciaArvore>(TOTAL_ARVORES);
            var rng        = new Random();
            int n          = especies.Count;

            for (int i = 0; i < TOTAL_ARVORES; i++)
            {
                EspecieArvore esp = especies[rng.Next(n)];
                double fA = 0.8 + rng.NextDouble() * 0.4;
                double fD = 0.8 + rng.NextDouble() * 0.4;
                int    gR = Math.Max(0, (int)(esp.GetNumeroDeGalhos() * (0.8 + rng.NextDouble() * 0.4)));

                instancias.Add(new InstanciaArvore(
                    esp,
                    alturaReal:   Math.Round(esp.GetAlturaMedia()   * fA, 1),
                    diametroReal: Math.Round(esp.GetDiametroMedio() * fD, 1),
                    galhosReais:  gR,
                    idade:        rng.Next(1, 300),
                    saude:        Math.Round(rng.NextDouble(), 2)
                ));
            }

            int totalArvores  = instancias.Count;
            int totalEspecies = fabrica.TotalEspeciesCriadas;

            
            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[ARVORES E ESPECIES]");
            Console.WriteLine("Total de arvores geradas : {0:N0}", totalArvores);
            Console.WriteLine("Total de especies        : {0}", totalEspecies);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[OBJETOS EM MEMORIA]");
            Console.WriteLine("Objetos MUTAVEIS  : {0:N0}", totalArvores);
            Console.WriteLine("(InstanciaArvore — 1 por arvore, carrega variacao individual)");
            Console.WriteLine("Objetos IMUTAVEIS : {0}", totalEspecies);
            Console.WriteLine("(EspecieArvore   — 1 por especie, compartilhado pelo pool)");
            Console.WriteLine("Total de objetos  : {0:N0}", totalArvores + totalEspecies);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sem Flyweight: {0:N0} objetos ArvoreSemFlyweight", totalArvores);
            Console.WriteLine("(cada um duplicaria os dados imutaveis da especie)");

            long memCom      = EstimadorMemoria.MemoriaComFlyweight(totalArvores, totalEspecies);
            long memSem      = EstimadorMemoria.MemoriaSemFlyweight(totalArvores);
            long economia    = memSem - memCom;
            double percEcon  = (double)economia / memSem * 100.0;

            Console.WriteLine();
            Console.WriteLine("[MEMORIA ESTIMADA]");
            Console.WriteLine("Tamanho EspecieArvore    (imutavel) : {0} bytes",
                              EstimadorMemoria.TamanhoEspecieArvore());
            Console.WriteLine("Tamanho InstanciaArvore  (mutavel)  : {0} bytes",
                              EstimadorMemoria.TamanhoInstanciaArvore());
            Console.WriteLine("Tamanho ArvoreSemFlyweight          : {0} bytes",
                              EstimadorMemoria.TamanhoArvoreSemFlyweight());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("COM Flyweight:");
            Console.WriteLine("Pool ({0,2} especies x {1} bytes)         : {2,10:N0} bytes  ({3:N2} KB)",
                              totalEspecies,
                              EstimadorMemoria.TamanhoEspecieArvore(),
                              (long)totalEspecies * EstimadorMemoria.TamanhoEspecieArvore(),
                              (long)totalEspecies * EstimadorMemoria.TamanhoEspecieArvore() / 1024.0);
            Console.WriteLine("Instancias ({0:N0} x {1} bytes)  : {2,10:N0} bytes  ({3:N2} MB)",
                              (long)totalArvores,
                              EstimadorMemoria.TamanhoInstanciaArvore(),
                              (long)totalArvores * EstimadorMemoria.TamanhoInstanciaArvore(),
                              (long)totalArvores * EstimadorMemoria.TamanhoInstanciaArvore() / (1024.0 * 1024.0));
            Console.WriteLine("TOTAL                                  : {0,10:N0} bytes  ({1:N2} MB)",
                              memCom, memCom / (1024.0 * 1024.0));

            Console.WriteLine();
            Console.WriteLine("SEM Flyweight:");
            Console.WriteLine("{0:N0} objetos x {1} bytes         : {2,10:N0} bytes  ({3:N2} MB)",
                              (long)totalArvores,
                              EstimadorMemoria.TamanhoArvoreSemFlyweight(),
                              memSem, memSem / (1024.0 * 1024.0));

            Console.WriteLine();
            
            Console.WriteLine("ECONOMIA : {0:N0} bytes  ({1:N2} MB)  =>  {2:N1}% menos memoria",
                              economia, economia / (1024.0 * 1024.0), percEcon);
         


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[AMOSTRA — PRIMEIRAS 10 ARVORES GERADAS]");
            
            Console.WriteLine("{0,-22} {1,-16} {2,7} {3,8} {4,7} {5,5} {6,5}",
                              "Especie", "Bioma", "Alt(m)", "Diam(cm)", "Galhos", "Idade", "Saude");
            
            for (int i = 0; i < 10 && i < instancias.Count; i++)
            {
                var a = instancias[i];
                a.ExibirDados();
            }

        }

    }
}
