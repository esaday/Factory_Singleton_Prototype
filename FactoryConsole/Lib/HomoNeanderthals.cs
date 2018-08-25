using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsole.Lib
{
    class HomoNeanderthals : Homo
    {
        internal HomoNeanderthals() { }

        /// <summary>
        /// Uses parent specified version of this method and some extensions.s
        /// </summary>
        public override void GivenSkills()
        {

            base.GivenSkills(3);
            Skills.Add(Lib.Skills.SimpleGrouping);

        }

        public override void LiveorDie()
        {
            Console.WriteLine("Dunno");
        }
    }
}
