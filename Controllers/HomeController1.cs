using Microsoft.AspNetCore.Mvc;

namespace Calus_Mario_Lab1.Controllers
{
    public class HomeController1 : Controller
    {
        public string Index()
        {
            return "Welcome!";
        }

        public string Greeting()
        {
            return "Hello dear user!";
        }

        public string personalData(String name, int age)
        {
            return name + "your age is " + age;
        }
    }
}
