using Feasablty_study.Domin.Entites;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

namespace Feasablty_study.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            TempData["Error"] = null;
            if (ModelState.IsValid)
            {
                var userName = loginVM.Email;
                var user = await _userManager.FindByEmailAsync(loginVM.Email);
                if (user != null)
                {
                    userName = user.UserName;
                    var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                    if (passwordCheck)
                    {
                        if (await _userManager.IsEmailConfirmedAsync(user))
                        {
                            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, false);
                            if (result.Succeeded)
                            {
                                return RedirectToAction("index", "Home");
                            }

                        }
                        else
                        {
                            TempData["Error"] = "الرجاء تنشيط الحساب من قبل المسؤول ";
                            return View(loginVM);

                        }

                    }
                    TempData["Error"] = "خطا في كلمة السر او الايميل ";

                    return View(loginVM);
                }
                TempData["Error"] = "خطا في كلمة السر او الايميل ";


                return View(loginVM);
            }
            return View();

        }
        [HttpGet]

        public IActionResult Register()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.Email);
            if (user != null)
            {
                TempData["Error"] = "المستخدم موجود مسبقا بهذا الايميل";
                return View(registerVM);
            }

            var newUser = new User()
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                UserName = registerVM.UserName,
                PhoneNumber = registerVM.PhoneNumber,
                EmailConfirmed = false,
                Status = false,


            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);
                TempData["Error"] = null;
            }
            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> AccountManage()
        {

            var account = await _signInManager.UserManager.GetUserAsync(User);
            if (account == null)
                return NotFound();
            else
                return View(account);
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel changePassword)
        {


            var user = await _signInManager.UserManager.GetUserAsync(User);
            if(ModelState.IsValid)
            {
            if (user == null)
                return NotFound();
            else
            {
                    if (changePassword == null)
                        return BadRequest();
               
                var result=await _userManager.ChangePasswordAsync(user,changePassword.CurrentPassword,changePassword.NewPassword);
                    if (result.Succeeded)
                    {
                        TempData["SuccessChanges"] = "تم تغيير كلمة السر بنجاح";
                      return  RedirectToAction("AccountManage");
                        
                    }

                    else
                        TempData["Error"] = "كلمة المرور السابقة خاطئة";

            }

            }
            return View(changePassword);
           
                
        }
        public async Task<IActionResult> ChangePassword()
        {
            return  View();
               
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Users");
        }


    }
}
