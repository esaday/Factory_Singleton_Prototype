using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsole.Lib
{
    class HomoSapiens : Homo
    {

        internal HomoSapiens() { }

        /// <summary>
        /// Uses parent specified version of this method can be extended and must be implemented!
        /// </summary>
        public override void GivenSkills()
        {
            GivenSkills(8);
        }

        public override void LiveorDie()
        {
            Console.WriteLine("Regret!!!");
        }
    }
}
