using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace CurrencyConverterApp.Controllers
{
    public class CurrencyConverterController : Controller
    {
        // GET: CurrencyConverter
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConvertCurrency(double amount, string targetCurrency)
        {
            // Simple conversion rates for example purposes
            double conversionRate = GetConversionRate(targetCurrency);
            double convertedAmount = amount * conversionRate;

            // Store the result in ViewBag
            ViewBag.ConvertedAmount = convertedAmount;
            ViewBag.TargetCurrency = targetCurrency;

            return View("Index");
        }

        private double GetConversionRate(string targetCurrency)
        {
            // Simple static conversion rates for demonstration
            switch (targetCurrency)
            {
                case "USD":
                    return 0.0036;
                case "EUR":
                    return 0.0034;
                case "JPY":
                    return 0.55;
                default:
                    return 1.0; // Default to USD
            }
        }
    }
}
