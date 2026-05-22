using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorestaSim
{


    // Base de dados geradas com auxílio de IA, pois pensar/pesquisar
    // essa gama de dados era um trabalho adicional não essencial
    public static class CatalogoEspecies
    {
        // [nome, tipo, altMedia, diamMedio, galhos, textura, folhagem, cor]
        public static readonly object[][] Dados = new object[][]
        {
            // Tropicais
            new object[] { "Jatoba",          "Tropical",   35.0, 120.0, 18, "Rugosa profunda",    "Perene densa",       "Castanho escuro"  },
            new object[] { "Ipê Amarelo",      "Tropical",   12.0,  45.0, 22, "Escamosa",           "Caduca aberta",      "Cinza claro"      },
            new object[] { "Ipê Roxo",         "Tropical",   14.0,  50.0, 20, "Escamosa",           "Caduca aberta",      "Cinza esverdeado" },
            new object[] { "Mogno",            "Tropical",   40.0, 150.0, 14, "Lisa com fissuras",  "Perene densa",       "Marrom avermelhado"},
            new object[] { "Cedro",            "Tropical",   30.0,  80.0, 16, "Fibrosa",            "Perene media",       "Marrom claro"     },
            new object[] { "Andiroba",         "Tropical",   25.0,  70.0, 12, "Escamosa grossa",    "Perene densa",       "Cinza escuro"     },
            new object[] { "Castanha-do-Para", "Tropical",   50.0, 200.0,  8, "Lisa acinzentada",   "Perene muito densa", "Cinza azulado"    },
            new object[] { "Seringueira",      "Tropical",   20.0,  60.0, 15, "Lisa com latex",     "Perene media",       "Verde acinzentado"},
            new object[] { "Acai",             "Tropical",   15.0,  20.0,  5, "Anelada",            "Perene palmiforme",  "Verde escuro"     },
            new object[] { "Buriti",           "Tropical",   20.0,  30.0,  6, "Anelada grossa",     "Perene palmiforme",  "Marrom dourado"   },

            // Temperadas
            new object[] { "Araucaria",        "Temperada",  30.0,  80.0, 30, "Escamosa placas",    "Perene conica",      "Marrom acinzentado"},
            new object[] { "Bracatinga",       "Temperada",  15.0,  30.0, 25, "Fibrosa fina",       "Caduca media",       "Cinza claro"      },
            new object[] { "Erva-mate",        "Temperada",   8.0,  20.0, 20, "Lisa esverdeada",    "Perene arbustiva",   "Verde escuro"     },
            new object[] { "Canela",           "Temperada",  12.0,  35.0, 18, "Aromática fissuras", "Perene densa",       "Marrom canela"    },
            new object[] { "Imbuia",           "Temperada",  25.0,  90.0, 14, "Rugosa profunda",    "Perene media",       "Marrom escuro"    },
            new object[] { "Timbo",            "Temperada",  18.0,  45.0, 16, "Lisa com placas",    "Caduca aberta",      "Cinza esverdeado" },
            new object[] { "Jerivá",           "Temperada",  10.0,  25.0,  4, "Anelada fina",       "Perene palmiforme",  "Cinza claro"      },
            new object[] { "Pitangueira",      "Temperada",   5.0,  15.0, 28, "Lisa esverdeada",    "Perene densa",       "Verde acinzentado"},
            new object[] { "Jabuticabeira",    "Temperada",   6.0,  18.0, 22, "Descamante lisa",    "Perene densa",       "Bege rosado"      },
            new object[] { "Guabiroba",        "Temperada",   7.0,  20.0, 20, "Fibrosa fina",       "Perene media",       "Cinza claro"      },

            // Cerrado
            new object[] { "Pequi",            "Cerrado",    10.0,  30.0, 16, "Rugosa corticosa",   "Caduca media",       "Cinza bege"       },
            new object[] { "Baru",             "Cerrado",    15.0,  40.0, 14, "Escamosa irregular", "Caduca aberta",      "Marrom avermelhado"},
            new object[] { "Cagaita",          "Cerrado",     8.0,  20.0, 18, "Lisa fina",          "Caduca densa",       "Cinza claro"      },
            new object[] { "Murici",           "Cerrado",     5.0,  12.0, 22, "Fibrosa",            "Perene arbustiva",   "Marrom claro"     },
            new object[] { "Mangaba",          "Cerrado",     6.0,  15.0, 15, "Lisa com latex",     "Perene media",       "Cinza esverdeado" },
            new object[] { "Lixeira",          "Cerrado",    12.0,  35.0, 10, "Áspera corrugada",   "Caduca aberta",      "Cinza escuro"     },
            new object[] { "Favela",           "Cerrado",     8.0,  18.0, 30, "Espinhosa",          "Caduca espinhosa",   "Marrom acinzentado"},
            new object[] { "Angico",           "Cerrado",    20.0,  55.0, 16, "Escamosa placas",    "Caduca media",       "Bege acinzentado" },
            new object[] { "Copaiba",          "Cerrado",    25.0,  70.0, 14, "Lisa com resina",    "Perene densa",       "Cinza claro"      },
            new object[] { "Aroeira",          "Cerrado",    10.0,  28.0, 20, "Fibrosa fina",       "Perene media",       "Marrom avermelhado"},

            // Caatinga
            new object[] { "Juazeiro",         "Caatinga",   10.0,  30.0, 18, "Rugosa escamosa",    "Perene media",       "Cinza esverdeado" },
            new object[] { "Catingueira",      "Caatinga",    8.0,  20.0, 14, "Fibrosa fina",       "Caduca aberta",      "Cinza claro"      },
            new object[] { "Mandacaru",        "Caatinga",    5.0,  25.0,  0, "Colunar espinhosa",  "Suculenta colunar",  "Verde brilhante"  },
            new object[] { "Umbuzeiro",        "Caatinga",    6.0,  30.0, 12, "Rugosa grossa",      "Caduca media",       "Cinza esverdeado" },
            new object[] { "Imburana",         "Caatinga",    8.0,  22.0, 10, "Descamante colorida","Caduca aberta",      "Amarelo esverdeado"},
            new object[] { "Xique-xique",      "Caatinga",    3.0,  15.0,  0, "Colunar espinhosa",  "Suculenta arbustiva","Verde azulado"    },
            new object[] { "Mufumbo",          "Caatinga",    4.0,  10.0, 20, "Fibrosa espinhosa",  "Caduca aberta",      "Cinza claro"      },
            new object[] { "Jatoba-do-Serrao", "Caatinga",   20.0,  60.0, 12, "Rugosa profunda",    "Perene densa",       "Castanho escuro"  },
            new object[] { "Quixabeira",       "Caatinga",    6.0,  18.0, 22, "Espinhosa irregular","Perene densa",       "Cinza escuro"     },
            new object[] { "Algaroba",         "Caatinga",   10.0,  25.0, 16, "Fibrosa corrugada",  "Perene media",       "Marrom claro"     },

            // Mata Atlantica
            new object[] { "Jequitiba",        "Mata Atlantica", 40.0, 180.0,  8, "Lisa acinzentada",  "Perene muito densa", "Cinza claro"   },
            new object[] { "Pau-Brasil",       "Mata Atlantica", 15.0,  50.0, 18, "Escamosa espinhosa","Caduca media",       "Laranja avermelhado"},
            new object[] { "Embauba",          "Mata Atlantica", 12.0,  25.0, 10, "Lisa anelada",      "Perene aberta",      "Verde claro"   },
            new object[] { "Guarapuvu",        "Mata Atlantica", 20.0,  60.0, 22, "Escamosa fina",     "Caduca aberta",      "Cinza esverdeado"},
            new object[] { "Caixeta",          "Mata Atlantica", 15.0,  35.0, 16, "Lisa fina",         "Perene media",       "Bege claro"    },
            new object[] { "Palmito-juçara",   "Mata Atlantica", 12.0,  18.0,  3, "Anelada fina",      "Perene palmiforme",  "Verde escuro"  },
            new object[] { "Quaresmeira",      "Mata Atlantica",  8.0,  20.0, 24, "Lisa esverdeada",   "Caduca florida",     "Cinza esverdeado"},
            new object[] { "Canjarana",        "Mata Atlantica", 25.0,  70.0, 14, "Fibrosa grossa",    "Perene densa",       "Marrom escuro" },
            new object[] { "Louro-Preto",      "Mata Atlantica", 20.0,  55.0, 16, "Rugosa fissuras",   "Perene densa",       "Cinza escuro"  },
            new object[] { "Figueira",         "Mata Atlantica", 30.0, 120.0, 35, "Raizes tabulares",  "Perene muito densa", "Cinza claro"   },
        };
    }
}
