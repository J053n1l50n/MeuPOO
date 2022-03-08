namespace ProjetoUm.source.Entidade
{
    public class MagoN:Heroi
    {
         public MagoN(string name, int level, int life, string TypeHero) : base(name, level, life, TypeHero)
        {
         this.name = name;
            this.level = level;
            this.life = life;
            this.TypeHero = TypeHero;
        }
        public override string Atacar()
        {
            return this.name + " Atacou com sua Magia";
        }
        public string Atacar(int bonus)
        {
            if(bonus > 6){
                return this.name + " Atacou com sua Magia super efetiva, cujo o Bonus é: "+ bonus;
            }else{
                return this.name + " Atacou com sua Magia não tão efetiva com Bonus de:  "+ bonus;
            }
            
        }
    }
}