using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himu.ConsoleApp1
{
    internal class Player
    {
        public String name = "harry";
        private int health = 49;
        public void setHealth(int h)
        {
            health = h;
        }
        public int getHealth()
        {
            return health;
        }
    }

}
