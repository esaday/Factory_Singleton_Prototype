using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsole.Lib
{

    class HomoFactory
    {
        /// <summary>
        /// Factory Method Implementation
        /// </summary>
        /// <param name="supremacy"></param>
        /// <returns></returns>
        public static Homo makeHomo(int supremacy)
        {
            switch (supremacy)
            {
                case 0:
                    return new HomoNeanderthals();
                case 1:
                    return new HomoErectus();
                case 2:
                    return new HomoSapiens();
                default:
                    return null;
            }
        }
    }
}
