using StarWars.Warriors;
using System;

namespace StarWars.Sides
{
    class Side
    {
        readonly static Random _rand = new Random();
        readonly IWarriorSource _warriorSource;
        public Warrior[] Warriors
        {
            get { return _warriorSource.Warriors; }
        }

        Warrior _current;

        public int Morale { get; set; }
        public bool HanSoloDied { get; set; }

        public Side(IWarriorSource warriorSource)
        {
            _warriorSource = warriorSource;   
            Morale = AvgPower();
        }

        public Warrior GetWarrior()
        {
            var result = _current ?? (_current = _warriorSource.Next());
            if (HanSoloDied)
            {
                HanSoloDied = false;
                if (_current is LukeSkywalker)
                    _current.DecreasePower(-5);
            }
            result?.OnJoinBattle();
            return result;
        }

        public void KillWarrior()
        {
            _current.OnLeaveBattle();
            Console.WriteLine($"{_current.Name} kiesett");
            _current = null;
        }

        public int AvgPower()
        {
            var sum = 0;
            foreach (var warrior in Warriors)
                if (warrior != null)
                    sum += warrior.Power;
            return sum / Warriors.Length;
        }
    }
}
