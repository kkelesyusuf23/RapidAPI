using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidAPI.Models;

namespace RapidAPI.Controllers
{
    public class LinkedinController : Controller
    {
        public async Task<IActionResult> Index(string Username)
        {
            if (!string.IsNullOrEmpty(Username))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://linkedin-api8.p.rapidapi.com/?username={Username}"),
                    Headers =
    {
        { "X-RapidAPI-Key", "4de8241237msh5faa3d451873343p132993jsnec7cab1c5af4" },
        { "X-RapidAPI-Host", "linkedin-api8.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<LinkedinViewModel>(body);
                    return View(values);
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://linkedin-api8.p.rapidapi.com/?username=yusuf-kele%C5%9F-3bb788202"),
                    Headers =
    {
        { "X-RapidAPI-Key", "4de8241237msh5faa3d451873343p132993jsnec7cab1c5af4" },
        { "X-RapidAPI-Host", "linkedin-api8.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<LinkedinViewModel>(body);
                    return View(values);
                }
            }
        }
    }
}
