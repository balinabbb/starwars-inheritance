namespace StarWars
{
    abstract class ForceUser : Warrior
    {
        protected ForceUser(int power) : base(power)
        {
        }

        public override bool IsStrongerThan(Warrior other)
        {
            if (other is ForceUser)
                return base.IsStrongerThan(other);
            return Power + 2 > other.Power;
        }
    }
}
