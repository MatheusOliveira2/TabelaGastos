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
            try
            {
                StreamReader ler = new StreamReader("../gastos-data/classes.json");
                string json = ler.ReadToEnd();
                Resumo classes = JsonConvert.DeserializeObject<Resumo>(json);
                ler.Close();
                return classes;
            }
            catch
            {
                StreamWriter salvar = new StreamWriter("../gastos-data/classes.json");
                string jsonClasses = JsonConvert.SerializeObject(this);
                salvar.WriteLine(jsonClasses);
                salvar.Close();
                return this;
            }
        }

        public void salvarClasses()
        { 
            StreamWriter salvar = new StreamWriter("../gastos-data/classes.json");
            string jsonClasses = JsonConvert.SerializeObject(this);
            salvar.WriteLine(jsonClasses);
            salvar.Close();
        }
    }
}

