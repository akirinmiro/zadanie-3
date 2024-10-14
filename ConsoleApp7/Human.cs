using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static IEnumerable<Human> Where(IEnumerable<Human> humans, Func<Human, bool> predicate)
        {
            foreach (var human in humans)
            {
                if (predicate(human))
                {
                    yield return human;
                }
            }
        }
        public static IEnumerable<Human> OrderBy(IEnumerable<Human> humans, Func<Human, int> keySelector)
        {
            return humans.OrderBy(keySelector);
        }
    
    }
}
