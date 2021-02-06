using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendGridTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           return View();
        }

        public void SendGridEmail()
        {
            var emailList = new List<EmailAddress>() {
            new EmailAddress("demousertest1@yopmail.com","test1"),
            new EmailAddress("demousertest2@yopmail.com","test2"),
             new EmailAddress("demousertest3@yopmail.com","test3"),
            new EmailAddress("demousertest4@yopmail.com","tet2"),
            new EmailAddress("demousertest5@yopmail.com","test2"),
            new EmailAddress("demousertest6@yopmail.com","test2"),
            new EmailAddress("demousertest7@yopmail.com","test2"),
            new EmailAddress("demousertest8@yopmail.com","test2"),
            new EmailAddress("demousertest9@yopmail.com","test2"),
            new EmailAddress("demousertest10@yopmail.com","test2"),
            new EmailAddress("demousertest11@yopmail.com","test12"),
            new EmailAddress("demousertest12@yopmail.com","test13"),
            new EmailAddress("demousertest13@yopmail.com","test14"),
            new EmailAddress("demousertest14@yopmail.com","test15"),
            new EmailAddress("demousertest15@yopmail.com","test16"),
            new EmailAddress("demousertest16@yopmail.com","test17"),
            new EmailAddress("demousertest17@yopmail.com","test18"),
            new EmailAddress("demousertest18@yopmail.com","test19"),
            new EmailAddress("demousertest19@yopmail.com","test20"),
            new EmailAddress("demousertest20@yopmail.com","test21"),
            new EmailAddress("demousertest21@yopmail.com","test22"),
            new EmailAddress("demousertest22@yopmail.com","test23"),
            new EmailAddress("demousertest23@yopmail.com","test24"),
            new EmailAddress("demousertest24@yopmail.com","test25"),
            new EmailAddress("demousertest25@yopmail.com","test26"),
            new EmailAddress("demousertest26@yopmail.com","test27"),
            new EmailAddress("demousertest27@yopmail.com","test28"),
            new EmailAddress("demousertest28@yopmail.com","test29"),
            new EmailAddress("demousertest29@yopmail.com","test30"),
            new EmailAddress("demousertest30@yopmail.com","test31"),
            new EmailAddress("demousertest31@yopmail.com","test32"),
            new EmailAddress("demousertest32@yopmail.com","test33"),
            new EmailAddress("demousertest33@yopmail.com","test34"),
            new EmailAddress("demousertest34@yopmail.com","test35"),
            new EmailAddress("demousertest35@yopmail.com","test36"),
            new EmailAddress("demousertest36@yopmail.com","test37"),
            new EmailAddress("demousertest37@yopmail.com","test38"),
            new EmailAddress("demousertest38@yopmail.com","test39"),
            new EmailAddress("demousertest39@yopmail.com","test40"),
            new EmailAddress("demousertest40@yopmail.com","test41"),
            new EmailAddress("demousertest41@yopmail.com","test42"),
            new EmailAddress("demousertest42@yopmail.com","test43"),
            new EmailAddress("demousertest43@yopmail.com","test44"),
            new EmailAddress("demousertest44@yopmail.com","test45"),
            new EmailAddress("demousertest45@yopmail.com","test46"),
            new EmailAddress("demousertest46@yopmail.com","test"),
            new EmailAddress("demousertest47@yopmail.com","test"),
            new EmailAddress("demousertest48@yopmail.com","test"),
            new EmailAddress("demousertest49@yopmail.com","test"),
            new EmailAddress("demousertest50@yopmail.com","test"),
            new EmailAddress("demousertest51@yopmail.com","test"),
            new EmailAddress("demousertest52@yopmail.com","test"),
            new EmailAddress("demousertest53@yopmail.com","test"),
            new EmailAddress("demousertest54@yopmail.com","test"),
            new EmailAddress("demousertest55@yopmail.com","test"),
            new EmailAddress("demousertest56@yopmail.com","test"),
            new EmailAddress("demousertest57@yopmail.com","test"),
            new EmailAddress("demousertest58@yopmail.com","test"),
            new EmailAddress("demousertest59@yopmail.com","test"),
            new EmailAddress("demousertest60@yopmail.com","test"),
            new EmailAddress("demousertest61@yopmail.com","test"),
            new EmailAddress("demousertest62@yopmail.com","test"),
            new EmailAddress("demousertest63@yopmail.com","test"),
            new EmailAddress("demousertest64@yopmail.com","test"),
            new EmailAddress("demousertest65@yopmail.com","test"),
            new EmailAddress("demousertest66@yopmail.com","test"),
            new EmailAddress("demousertest67@yopmail.com","test"),
            new EmailAddress("demousertest68@yopmail.com","test"),
            new EmailAddress("demousertest69@yopmail.com","test"),
            new EmailAddress("demousertest70@yopmail.com","test"),
            new EmailAddress("demousertest71@yopmail.com","test"),
            new EmailAddress("demousertest72@yopmail.com","test"),
            new EmailAddress("demousertest73@yopmail.com","test"),
            new EmailAddress("demousertest74@yopmail.com","test"),
            new EmailAddress("demousertest75@yopmail.com","test"),
            new EmailAddress("demousertest76@yopmail.com","test"),
            new EmailAddress("demousertest77@yopmail.com","test"),
            new EmailAddress("demousertest78@yopmail.com","test"),
            new EmailAddress("demousertest79@yopmail.com","test"),
            new EmailAddress("demousertest80@yopmail.com","test"),
            new EmailAddress("demousertest81@yopmail.com","test"),
            new EmailAddress("demousertest82@yopmail.com","test"),
            new EmailAddress("demousertest83@yopmail.com","test"),
            new EmailAddress("demousertest84@yopmail.com","test"),
            new EmailAddress("demousertest85@yopmail.com","test"),
            new EmailAddress("demousertest86@yopmail.com","test"),
            new EmailAddress("demousertest87@yopmail.com","test"),
            new EmailAddress("demousertest88@yopmail.com","test"),
            new EmailAddress("demousertest89@yopmail.com","test"),
            new EmailAddress("demousertest90@yopmail.com","test"),
            new EmailAddress("demousertest91@yopmail.com","test"),
            new EmailAddress("demousertest92@yopmail.com","test"),
            new EmailAddress("demousertest93@yopmail.com","test"),
            new EmailAddress("demousertest94@yopmail.com","test"),
            new EmailAddress("demousertest95@yopmail.com","test"),
            new EmailAddress("demousertest96@yopmail.com","test"),
            new EmailAddress("demousertest67@yopmail.com","test"),
            new EmailAddress("demousertest98@yopmail.com","test"),
            new EmailAddress("demousertest99@yopmail.com","test"),
            new EmailAddress("demousertest100@yopmail.com","test"),
            };
            var sendGridClient = new SendGridClient("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");
            var sendGridMessage = new SendGridMessage();
            sendGridMessage.SetFrom("mss.nimishmishra@gmail.com", "Nimish Mishra");
            sendGridMessage.AddTos(emailList);
            sendGridMessage.SetTemplateId("d-cd5de78f163b43efaa1746b249086256");
            sendGridMessage.SetTemplateData(new HelloEmail
            {
                Name = "Nimish",
                Url = "https://www.google.com/"
            });
            var response = sendGridClient.SendEmailAsync(sendGridMessage).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                Console.WriteLine("Email sent");
            }
        } 
        private class HelloEmail
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }
        public IActionResult Privacy()
        {
            SendGridEmail();
            return View();
        }

        
    }
}
