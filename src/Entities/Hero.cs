namespace NewDot.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return "Name: " + this.Name + " " +"Level: " + this.Level + "\n" + "Hero Type: " + this.HeroType + "\n";
        }

        public virtual string Attack(int Bonus)
        {
            return this.Name + " Atacou usando bola de fogo";
        }
    }
}