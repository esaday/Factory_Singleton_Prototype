using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsole.Lib
{
    class HomoErectus : Homo
    {
        /// <summary>
        /// Uses parent specified version of this method can be extended and must be implemented!
        /// </summary>

        internal HomoErectus(){}

        public override void GivenSkills()
        {
            base.GivenSkills(4);
        }

        //No purpose just for example
        public override void LiveorDie()
        {
            Console.WriteLine("I'm alive!!!!");
        }
    }
}
