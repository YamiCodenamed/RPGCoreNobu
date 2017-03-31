using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGCoreNobu.Classes
{
    class ItemController
    {
        private static bool LoadItem(int itemID)
        {
            //missing db and implementation here
            return true;
        }

        public static void LoadItem(params int[] toLoad)
        {
            Parallel.ForEach(toLoad, (itemID) =>
            {
                if (!LoadItem(itemID))
                {
                    //store error somewhere
                }
            });
        }
    }
}
