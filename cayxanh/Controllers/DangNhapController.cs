using Microsoft.AspNetCore.Mvc;

namespace cayxanh.Controllers;

public class DangNhapController : Controller
{
    private readonly ILogger<DangNhapController> _logger;

    public DangNhapController(ILogger<DangNhapController> logger)
    {
        _logger = logger;
    }
    // GET
    public IActionResult DangNhap()
    {
        return View();
    }
}