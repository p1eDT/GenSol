using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome7
{
    public class Restraurant : IWork
    {
        public void Work()
        {
            IWork cleaner = new Cleaner("Vasya");
            IWork cook = new Cook("T.Valya");
            IWork manager = new Manager("Lopar");
            cleaner.Work();
            cook.Work();
            manager.Work();
        }
    }
}
