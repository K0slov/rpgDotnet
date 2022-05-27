namespace NewDot.src.Entities
{
    public class Archer : Hero
    {
        public Archer(int Id, string Name, int Level, TypeClass HeroType, int Life) : base(Id, Name, Level, (TypeClass)HeroType, Life)
        {
            this.Id = Id;
            this.Name = Name;
            this.Level = Level;
            this.HeroType = (TypeClass)HeroType;
            this.Life = 80;
        }
        public override string Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " Ataque com a flecha super efetivo, bonus no ataque de " + Bonus + "\n";
            }else if(Bonus > 0){
                return this.Name + " Ataque com a flecha com bonus no ataque de " + Bonus + "\n";
            }else if (Bonus < 0){
                return this.Name + " Ataque com a flecha não efetivo" + "\n";
            }else{
            return this.Name + " Atirou uma flecha" + "\n";
            }
    }
}}