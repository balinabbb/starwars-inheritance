using System;

namespace StarWars.Sides
{
    class LinearWarriorSource : IWarriorSource
    {
        public Warrior[] Warriors { get; private set; }

        public IWarriorSource Initialize(Warrior[] all, bool side)
        {
            var count = 0;
            foreach (var warrior in all)
                if (warrior.IsLightSide == side)
                    count++;
            Warriors = new Warrior[count];
            var index = 0;
            foreach (var warrior in all)
                if (warrior.IsLightSide == side)
                    Warriors[index++] = warrior;
            return this;
        }

        int _current;
        public Warrior Next()
        {
            try
            {
                return Warriors[_current++];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }
    }
}
