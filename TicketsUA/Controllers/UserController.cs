using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TicketsUA.Data;
using TicketsUA.Models;
using TicketsUA.ViewModel;

namespace TicketsUA.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDBContext _dBContext;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDBContext dBContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dBContext = dBContext;
        }


        public IActionResult Login()
        {
            var response = new LoginVM();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.Email);

            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);

                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "AirTickets");
                    }
                }
                TempData["Error"] = "Incorrect Email or password, please try again!";
                return View(loginVM);
            }

            TempData["Error"] = "Incorrect Email or password, please try again!";
            return View(loginVM);
        }


        public IActionResult Register()
        {
            var response = new RegisterVM();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);


            var userFindEmail = await _userManager.FindByEmailAsync(registerVM.EmailAdress);

            if (userFindEmail != null)
                TempData["Error"] = "This email is already use";

            var user = new AppUser()
            {
                Email = registerVM.EmailAdress,
                UserName = registerVM.EmailAdress
            };

            var register = await _userManager.CreateAsync(user, registerVM.Password);
            if (register.Succeeded) 
                await _userManager.AddToRoleAsync(user,UserRoles.User);


            return RedirectToAction("Index", "AirTickets");

        }
       

        [HttpPost]
        public  async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "AirTickets");
        }

    }
}
