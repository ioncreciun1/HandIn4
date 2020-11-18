using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HandIn4.Database.Context;
using HandIn4.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandIn4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private DAOUser UserDao;

        public UserController(DAOUser userDao)
        {
            this.UserDao = userDao;
        }

        [HttpGet]
        public async Task<ActionResult<User>> getUsers()
        {
            try
            {
                IList<User> users =  await UserDao.getUsers();
                return Ok(users);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}