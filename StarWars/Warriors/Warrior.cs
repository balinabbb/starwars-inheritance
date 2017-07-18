using System;
using StarWars.Warriors;

namespace StarWars
{
    abstract class Warrior
    {
        /// <summary>
        /// Ez a függvény a fájlból beolvasott string alapján példányosít egy 
        /// megfelelő ObiWan, JarJar, DarthMaul, stb példányt, és azt visszadja.
        /// </summary>
        /// <returns>A létrehozott warrior példányt</returns>
        /// <param name="s">A beolvasott fájl egy sora</param>
        public static Warrior FromString(string s)
        {
            var data = s.Substring(1).Split('#');
            var name = data[0].Replace('_', ' ');
            var power = int.Parse(data[1]);
            switch (name)
            {
                case "Boba Fett":
                    return new BobaFett(power);
                case "Darth Maul":
                    return new DarthMaul(power);
                case "Darth Sidius":
                    return new DarthSidius(power);
                case "Darth Vader":
                    return new DarthVader(power);
                case "Han Solo":
                    return new HanSolo(power);
                case "Jabba":
                    return new Jabba(power);
                case "Luke Skywalker":
                    return new LukeSkywalker(power);
                case "Mace Windu":
                    return new MaceWindu(power);
                case "Obi Wan Kenobi":
                    return new ObiWanKenobi(power);
                case "Yoda":
                    return new Yoda(power);
                case "Jar Jar":
                    return new JarJar(power);
            }
            throw new NotImplementedException();
        }

        public int Power { get; protected set; }
        public virtual bool IsLightSide { get; }
        public abstract string Name { get; }

        protected Warrior(int power)
        {
            Power = power;
        }

        public abstract void OnJoinBattle();
        public abstract void OnLeaveBattle();
        public abstract void PreCombatEffect();
        public abstract void PostCombatEffect();
        public virtual void DecreasePower(int power)
        {
            Power -= power;
        }

        public virtual bool IsStrongerThan(Warrior other)
        {
            var side = IsLightSide ? Simulator.Instance.LightSide : Simulator.Instance.DarkSide;
            var otherSide = side == Simulator.Instance.LightSide ? Simulator.Instance.DarkSide : Simulator.Instance.LightSide;
            var ownPower = (1.0 + (side.Morale / 100.0)) * Power;
            var otherPower = (1.0 + (otherSide.Morale / 100.0)) * other.Power;
            Console.WriteLine($"{Power} erő összehasonlítása {side.Morale} morállal ({ownPower}), ellenfél: {other.Power} erő {otherSide.Morale} morállal ({otherPower})");
            return ownPower > otherPower;
        }
    }
}
