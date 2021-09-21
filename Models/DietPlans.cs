using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeLibrary.Models
{
    public interface IDietPlans
    {
        public List<string> Drinks { get; set; }
        public List<string> Snacks { get; set; }
        public List<string> LightFood { get; set; }

    }

    public class FatBurner: IDietPlans
    {
        public List<string> Drinks { get => getDrinks(); set => SetDrinks(); }
        public List<string> Snacks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> LightFood { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<string> getDrinks()
        {
            return Drinks;
        }
        public void SetDrinks()
        {
            Drinks.Add("");
        }
    }

    public class FoodDetails
    {
        public double MakingTime { get; set; }
        public List<string> Ingredients { get; set; }


    }
}
