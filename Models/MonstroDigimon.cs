namespace Digimon.Models
{
    public class MonstroDigimon
    {
        internal int id;
        protected string nome;
        protected int level;
        protected int hp;
        protected int espirito;

        public MonstroDigimon(string nome, int level)
        {
            this.nome = nome;
            this.level = level;
        }

        public string GetNome()
        {
            return nome;
        }

        public int GetLevel()
        {
            return level;
        }

        public virtual void Atacar()
        {
            Console.WriteLine("O Digimon ataca!");
        }

        public virtual int SubirLevel()
        {
            this.level++;
            return this.level;
        }

        public virtual void Evoluir(string novaForma)
        {
            Console.WriteLine($"O Digimon evolui para {novaForma}!");
        }
    }
}
