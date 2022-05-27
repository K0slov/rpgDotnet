namespace NewDot.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, TypeClass HeroType, int Life) : base(Name, Level, (TypeClass)HeroType, Life)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = (TypeClass)HeroType;
            this.Life = Life;
        }
        
        public override string Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " Ataque magico super efetivo, bonus no ataque de " + Bonus + "\n";
            }else if(Bonus > 0){
                return this.Name + " Ataque magico com bonus no ataque de " + Bonus + "\n";
            }else if (Bonus < 0){
                return this.Name + " Ataque magico não efetivo" + "\n";
            }else{
            return this.Name + " Atacou usando bola de fogo" + "\n";
            }
            
        }
        }
    }