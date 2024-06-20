using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FirstProject.Controllers
{
	public class WeatherController : Controller
	{
		public IActionResult Index()
		{
 
			string api = "4555623f4b5f235427590131a9d5dca7";
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&mode=xml&appid="+api;

			XDocument xDocument = XDocument.Load(connection);
			ViewBag.v1= xDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value;

			return View();




		}
	}
}
