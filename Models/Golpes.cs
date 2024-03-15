namespace Digimon.Models
{
    public class Golpes
    {
        protected string nome;
        protected int poder;
        protected string descricao;

        public Golpes(string nome, int poder, string descricao)
        {
            this.nome = nome;
            this.poder = poder;
            this.descricao = descricao;
        }

        protected void Aplicar()
        {
            Console.WriteLine("Aplicando golpe");
        }
    }
}
