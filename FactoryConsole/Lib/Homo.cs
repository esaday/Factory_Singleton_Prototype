using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsole.Lib
{
    enum Skills
    {
        Collecting = 1,
        SimpleHunting = 2,
        Sheltering = 3,
        MakingTools = 4,
        AdvancedHunting = 5,
        SimpleGrouping = 6,
        Gossiping = 8
    }

    /// <summary>
    /// Homo class for deriving
    /// </summary>
    abstract class Homo
    {
        //Common homo attributes : common encapsulation
        bool isAlive;
        int walkSpeed, height, avgLife, survivabilityScore;
        List<Skills> skills;

        //Survivability score prop : virtual for specified(?) changes!
        public virtual int SurvivabilityScore
        {
            set { survivabilityScore = value; }
            get
            { 
                return survivabilityScore;
            }
        }

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }

            set
            {
                isAlive = value;
            }
        }

        public int WalkSpeed
        {
            get
            {
                return walkSpeed;
            }

            set
            {
                walkSpeed = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int AvgLife
        {
            get
            {
                return avgLife;
            }

            set
            {
                avgLife = value;
            }
        }

        public List<Skills> Skills
        {
            get
            {
                return skills;
            }

            set
            {
                skills = value;
            }
        }

        /// <summary>
        /// Common constructor : default value assigning
        /// </summary>
        protected Homo()
        {
            IsAlive = true; WalkSpeed = 22; Height = 166; AvgLife = 40; survivabilityScore = CombinedSurvS(Skills);

            GivenSkills();
        }

        /// <summary>
        /// Must be implemented!
        /// </summary>
        public abstract void LiveorDie();

        /// <summary>
        /// Given skill func - virtual for specified definition - With this we have a body of abstract function
        /// </summary>
        /// <param name="lvl"></param>
        protected virtual void GivenSkills(int lvl)
        {
            List<Skills> s = new List<Skills>();
            foreach (Skills item in Enum.GetValues(typeof(Skills)))
            { if ((int)item <= lvl) { s.Add(item); } }

            Skills = s;
            survivabilityScore = CombinedSurvS(Skills);
        }

        /// <summary>
        /// Calculation of given set of skills (can be virtual ?)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private int CombinedSurvS(List<Skills> s)
        {
            int result = 0;
            if (Skills != null)
            {
                foreach (var item in s)
                {
                    result += (int)item;
                }
            }
            return result;
        }

        /// <summary>
        /// Must be implemented! Purpose : Each specie need to have its own given skills!
        /// </summary>
        public abstract void GivenSkills();

    }
}
