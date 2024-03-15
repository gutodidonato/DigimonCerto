using Digimon.Models;

public class Mapa : IMundo
{
    public string NomeMapa { get; set; }
    internal int IdMapa { get; set; }

    public Mapa(string nomeMapa)
    {
        NomeMapa = nomeMapa;
    }

    public void Iniciar()
    {
        Console.WriteLine("O mapa do Digimon começou!");
    }

    public void Terminar()
    {
        Console.WriteLine("O mapa do Digimon acabou!");
    }

}