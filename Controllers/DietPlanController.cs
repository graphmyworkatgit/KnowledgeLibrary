using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeLibrary.Constants;
using KnowledgeLibrary.Models;

namespace KnowledgeLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DietPlanController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<MedicineController> _logger;

        public DietPlanController(ILogger<MedicineController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MedicineDetails> Get()
        {
            var rng = new Random();
            var tr = new List<MedicineDetails>();

            var t = new List<string>();
            //{ OrganNames.brain,OrganNames.liver };
            t.Add(OrganNames.liver);
            t.Add(OrganNames.eyes);
            t.Add(OrganNames.kidney);

            var langs = new List<PlantNamesByLanguage>();
            langs.Add(new PlantNamesByLanguage("Phyllanthus Niruri", "", "Keelanelli", ""));
            
            tr.Add(new MedicineDetails(langs, "", "https://www.wildturmeric.net/keelanelli-plant-health-benefits-medicinal-uses/", t ));

            return tr;
        }
    }
}
