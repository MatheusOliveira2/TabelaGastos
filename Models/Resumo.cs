using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace gastos.Models
{
    public class Resumo
    {
        public List<string> nomes { get; set; }
        
        public List<string> lerClasses(){
            return nomes;
        }

        public static void salvarClasses(){
            StreamWriter salvar = new StreamWriter("teste.txt");
            salvar.WriteLine("CONTEUDO");
            salvar.Close();
        }
    }

}
