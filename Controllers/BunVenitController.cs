using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Olteanu_Carla_Lab1_MPA.Models;

namespace Olteanu_Carla_Lab1_MPA.Controllers
{
    public class BunVenitController : Controller
    {
        public string Index()
        {
            return "Bun venit!";
        }

        public string Salut()
        {
            return "Salut!";
        }

        public string AfiseazaDate(string nume, int varsta)
        {
            return $"Salut {nume}, ai {varsta} ani.";
        }
    }
}
