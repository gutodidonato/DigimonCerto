using System;

namespace Digimon.Models
{
    public class Treinador : MonstroDigimon
    {
        protected MonstroDigimon monstroDigimon;
        protected string[] itens;

        public Treinador(string nome, MonstroDigimon monstroDigimon) : base(monstroDigimon.GetNome(), monstroDigimon.GetLevel())
        {
            this.monstroDigimon = monstroDigimon;
            this.nome = nome;
            this.itens = new string[] { }; 
        }

        public void TreinarDigimon(MonstroDigimon monstroDigimon)
        {
            Console.WriteLine($"O treinador treina o Digimon {monstroDigimon.GetNome()}.");
        }

        public void AdicionarItem(string item)
        {
            Array.Resize(ref this.itens, this.itens.Length + 1);
            this.itens[this.itens.Length - 1] = item;
        }

        public override void Evoluir(string novaForma)
        {
            if (Array.Exists(this.itens, item => item == "DigiArmadura"))
            {
                Console.WriteLine($"O treinador {nome} usou a DigiArmadura e evoluiu para {novaForma}");
            }
            else
            {
                Console.WriteLine("Não foi possível evoluir. Item necessário: Armadura da sorte");
            }
        }
    }
}
