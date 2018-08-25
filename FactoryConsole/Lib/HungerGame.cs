using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsole.Lib
{
    /// <summary>
    /// Class for demonstration of The scenario and factory method pattern.
    /// </summary>
    public class HungerGame
    {
        //Needed variables for competition
        List<Homo> population = new List<Homo>();
        int[] additiveSurvS = { 0, 0, 0 };

        internal List<Homo> Population
        {
            get
            {
                return population;
            }

            set
            {
                population = value;
            }
        }

        public int[] AdditiveSurvS
        {
            get
            {
                return additiveSurvS;
            }

           private set
            {
                additiveSurvS = value;
            }
        }

        /// <summary>
        /// Creates populations of homo species -> each specie's pop. will be random.
        /// </summary>
        /// <param name="countPerPop">maximum count per population</param>
        public void CreatePop(int maxCountPerPop)
        {
            Random r = new Random();
            for (int i = 0; i <= 2; i++)
            { int popSize = r.Next(0, maxCountPerPop);
                for (int j = 0; j < popSize ; j++)
                {
                    population.Add(HomoFactory.makeHomo(i));
                    
                    AdditiveSurvS[i] += Population.ElementAt(population.Count-1).SurvivabilityScore;
                }

            }
        }

        /// <summary>
        /// Finds the index and value of the winner with the biggest additiveSurvS
        /// </summary>
        /// <returns>Winner Species name</returns>
       public string Winner()
        {
            var max = AdditiveSurvS.Select((value, index) => new { value, index })
                 .OrderByDescending(vi => vi.value)
                 .First();

            return "Winner is : " + HomoFactory.makeHomo(max.index).GetType().ToString().Split('.').Last();

        }

        /// <summary>
        /// Recursive decision making ?
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        //string Winner(int type)
        //{
        //    if (type == 1)
        //    {
        //        return Winner(1);
        //    }

        //    winner = additiveSurvS[type] > additiveSurvS[type-1] ?
        //            HomoFactory.makeHomo(type).GetType().ToString() :
        //            HomoFactory.makeHomo(type-1).GetType().ToString();
        //    return Winner(type - 1);
        //}

    }
}
