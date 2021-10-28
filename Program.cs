using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_de_moveis
{
    class Program
    {
        static void Main(string[] args)
        {

            tipos_de_moveis tp = new tipos_de_moveis();

            tp.cor = "marfim";
            tp.cozinha = "armario_de_parede";
            tp.tipo_de_material = "MDF";
            tp.tamanho = 2000;

            loja_de_moveis tp2 = new loja_de_moveis();
            tp2.nome_da_loja = "tudo_de_primeira";
            tp2.endereço_da_loja = "avenida_piraporinha";
            tp2.numero_do_endereço = 777;
            tp2.telefone = 1140492222;


        }
    }
}
    
            


    }