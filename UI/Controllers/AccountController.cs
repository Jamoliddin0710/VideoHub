using Infrastructure.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace UI.Controllers;

public class AccountController : Controller
{
    // GET
    [HttpGet]
    public async Task<IActionResult> Login(string returnUrl = null)
    {
        var login = new LoginVM()
        {
            ReturnUrl = returnUrl
        };
        
        return View(login);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginVM login)
    {
        if (!ModelState.IsValid)
        {
            return View(login);
        }
        
        return Ok();
    }
}