using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            //Resumo object = (Resumo)JsonSerializer.Deserialize(json);
            ler.Close();
            
            return this;
        }

        public void salvarClasses()
        { 
            StreamWriter salvar = new StreamWriter("teste.json");
            string jsonClasses = JsonSerializer.Serialize(this);
            salvar.WriteLine(jsonClasses);
            salvar.Close();
        }
    }

}

