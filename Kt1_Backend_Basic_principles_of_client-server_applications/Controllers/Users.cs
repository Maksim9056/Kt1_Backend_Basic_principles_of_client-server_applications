using Kt1_Backend_Basic_principles_of_client_server_applications.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Kt1_Backend_Basic_principles_of_client_server_applications.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>();

        //public UsersController()
        //{
        //}

        // Инициализация списка пользователей

        // Метод для обработки GET-запроса
        [HttpGet("getusers")]
        public List<User> GetUsers()
        {
            return users;
        }

        // Метод для обработки POST-запроса
        [HttpPost]
        public IActionResult PostUser([FromBody] User data)
        {
            users.Add(data);
            return Ok($"POST-запрос успешно обработан! Данные: {data.Name}, {data.Password}");
        }
    }
}
