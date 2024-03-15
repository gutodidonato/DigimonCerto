using Digimon.Models;
using Microsoft.AspNetCore.Mvc;

public class BatalhaController : Controller
{
    public IActionResult Index()
    {

        MonstroDigimon agumon = new MonstroDigimon("Agumon", 5);
        Treinador treinador = new Treinador("Tai", agumon);
        Mapa florestaDigital = new Mapa("Floresta Digital");

        ViewData["Treinador"] = treinador.GetNome();
        ViewData["Digimon"] = agumon.GetNome();
        ViewData["mapa"] = florestaDigital.NomeMapa;

        return View();
    }
}