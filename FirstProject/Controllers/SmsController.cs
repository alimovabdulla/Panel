using FirstContext1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FirstProject.Controllers
{
    public class SmsController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        // Ваши учетные данные Twilio
        private const string accountSid = "AC312dd64a3eab4bee1cf1f2a2bf088960";
        private const string authToken = "1940cbb5beaf4e74120d84e74c7f7a51";
 

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Действие для отправки SMS
        [HttpPost]
        public IActionResult Index(string phoneNumber, string message)
        {
            // Проверяем, что номер телефона и сообщение заполнены
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(message))
            {
                // Можно добавить логику обработки ошибки или вернуть на страницу с сообщением об ошибке
                return RedirectToAction("Index");
            }

            // Инициализация Twilio клиента
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber(phoneNumber); // Номер получателя (введенный пользователем)
            var from = new PhoneNumber("+19034824706"); // Ваш Twilio номер телефона

            var twilioMessage = MessageResource.Create(
                to: to,
                from: from,
                body: message // Текст сообщения (введенный пользователем)
            );

            // Для примера, выведем SID сообщения в консоль
            System.Console.WriteLine($"Message SID: {twilioMessage.Sid}");

            // Возвращаем результат, например, перенаправление на главную страницу
            return RedirectToAction("Index");
        }
    }
}
