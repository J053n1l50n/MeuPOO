namespace ProjetoUm.source.Entidade
{
    public class Cavaleiro:Heroi
    {
         public Cavaleiro(string name, int level, int life, string TypeHero):base(name, level, life, TypeHero)
        {
            this.name = name;
            this.level = level;
            this.life = life;
            this.TypeHero = TypeHero;
        }
    }
}