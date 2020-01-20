using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

namespace gastos.Models
{
    public class Resumo
    {
        public List<string> Resumos { get; set; }
        public List<string> Origens { get; set; }

        public Resumo lerClasses()
        {
            StreamReader ler = new StreamReader("teste.json");
            string json = ler.ReadToEnd();
            Resumo classes = JsonConvert.DeserializeObject<Resumo>(json);
            return classes;
        }

        public void salvarClasses()
        { 
            StreamWriter salvar = new StreamWriter("teste.json");
            string jsonClasses = JsonConvert.SerializeObject(this);
            salvar.WriteLine(jsonClasses);
            salvar.Close();
        }
    }

}

