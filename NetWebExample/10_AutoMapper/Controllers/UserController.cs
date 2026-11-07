using _10_AutoMapper.Dto;
using _10_AutoMapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _10_AutoMapper.Controllers
{
    public class UserController(IMapper mapper) : Controller
    {
        public IActionResult Index()
        {
            var user = new User()
            {
                Id=1,
                FirstName="Erkan",
                LastName="Türk",
                Email="Erkanturk@gmail.com"
            };
            //Dto dışarıya ekrana gelecek sadeleştirilmiş nesne
            //Entity her alanı gösterilmez bazı alanlar birleştirilir Firstname+Lastname = fullname gibi
            var userDto = mapper.Map<UserDto>(user);
            return View(userDto);
        }
        public IActionResult Index2()
        {
            var user = new User()
            {
                Id=1,
                FirstName="Erkan",
                LastName="Türk",
                Email="Erkanturk@gmail.com"
            };
           
           
            return View(user);
        }
    }
}
