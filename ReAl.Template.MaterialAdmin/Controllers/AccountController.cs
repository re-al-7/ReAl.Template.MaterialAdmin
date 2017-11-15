using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.CoreMvc.Dal.Entidades;

namespace Test.CoreMvc.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost, ActionName("Login")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(EntSegUsuario user, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                const string badUserNameOrPasswordMessage = "Usuario o contraseña incorrectos.";
                if (user == null)
                {
                    ModelState.AddModelError("", badUserNameOrPasswordMessage);
                    return View();
                }
                if (user.login != "alo" || user.password != "vera")
                {
                    ModelState.AddModelError("", badUserNameOrPasswordMessage);
                    return View();
                }
                var lookupUser = new EntSegUsuario();
                lookupUser.login = user.login;
                lookupUser.nombre = "Alonzo";
                lookupUser.paterno = "Vera";

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, lookupUser.login));
                identity.AddClaim(new Claim(ClaimTypes.GivenName, lookupUser.nombre + " " + lookupUser.paterno));

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                if (returnUrl == null)
                {
                    returnUrl = TempData["returnUrl"]?.ToString();
                }
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction(nameof(DashboardController.Index), "Dashboard");
                }
            }

            // If we got this far, something failed, redisplay form
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }
    }
}
