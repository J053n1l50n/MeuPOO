namespace ProjetoUm.source.Entidade
{
    public class Heroi
    {
   
        public Heroi(string name, int level, int life, string TypeHero)
        {
            this.name = name;
            this.level = level;
            this.life = life;
            this.TypeHero = TypeHero;

        }
        public string name { get; set; }

        public int level { get; set; }
        public int life { get; set; }

        public string TypeHero { get; set; }

        public override string ToString()
        {
            return "Heroi: "+ this.name + " Cujo o nivel é  " + this.level +" cujo a barra de vida é "+ this.life + " cujo sua profissão é  "+ this.TypeHero;
        }
        public virtual string Atacar()
        {
            return this.name + " Atacou com sua lamina";
        }
    }
}