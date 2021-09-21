using KnowledgeLibrary.Constants;
using KnowledgeLibrary.Models;
using System;
using System.Collections.Generic;

namespace KnowledgeLibrary
{
    public class MedicineDetails
    {
        public DateTime Date { get; set; }

        public List<PlantNamesByLanguage> NamesByLanguages {get;set;}

        public string Summary { get; set; }
        public string WebLink { get; set; }

        public List<string> Organs { get; set; }
        public List<PlantNamesByLanguage> LanguageLists { get; set; }

        

        /// <summary>
        /// /
        /// </summary>
        /// <param name="eName"></param>
        /// <param name="tName"></param>
        /// <param name="summ"></param>
        /// <param name="webLink"></param>
        /// <param name="lis"></param>
        public MedicineDetails( List<PlantNamesByLanguage> langs, string summ, string webLink, List<string> lis)
        {
            NamesByLanguages = langs;
            Summary = summ;
            WebLink = webLink;
            Organs = lis;
        }
    }

  
}
