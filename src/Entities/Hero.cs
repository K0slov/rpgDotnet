namespace NewDot.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Life)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int Life;

        public override string ToString()
        {
            return "Name: " + this.Name + " " + "Life: " + this.Life + "\n" +"Level: " + this.Level + " " + "Hero Type: " + this.HeroType + "\n";
        }

        public virtual string Attack(int Bonus)
        {
            return this.Name + " Atacou usando bola de fogo";
        }
    }
}