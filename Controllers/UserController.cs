using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using apirest.Services;
using apirest.Models;

namespace Controllers
{
    [ApiController]
    [Route("/users")]
    public class UserController : ControllerBase
    {
        private static UserService userService = new UserService();

        [HttpGet]
        public List<User> GetUsers()
        {
            return userService.GetUsers();
        }
        [HttpGet]
        [Route("/user/{id}")]
        public User GetUser([FromRoute]int id)
        {
            return userService.GetUser(id);
        }

        [HttpPost]
        public User PostUser ([FromBody]User user)
        {
            return userService.PostUser(user);
        }
        [HttpPut]
        [Route("/user/{id}")]
        public User UpdateUser ([FromBody]User user, [FromRoute]int id)
        {
            return userService.UpdateUser(user, id);
        }
        [HttpDelete]
        [Route("/apagar/{id}")]
        public string DeleteUser ([FromRoute]int id)
        {
            return userService.DeleteUser(id);
        }
    }
}