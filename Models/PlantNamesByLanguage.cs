using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeLibrary.Models
{
    public interface ILanguages
    {

    }
    public class PlantNamesByLanguage
    {
        public string Botanical { get; set; }
        public string English { get; set; } //Chanca Piedra
        public string Tamil { get; set; } //Chanca Piedra
        public string Spanish { get; set; } //Chanca Piedra

        public PlantNamesByLanguage(string botanical,string en, string ta, string spa)
        {
            Botanical = botanical;
            English = en;
            Tamil = ta;
            Spanish = spa;
        }

    }
}
