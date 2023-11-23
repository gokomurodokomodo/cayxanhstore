using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cayxanh.Controllers;

public class SanPhamController : Controller
{
    private readonly ILogger<SanPhamController> _logger;

    public SanPhamController(ILogger<SanPhamController> logger)
    {
        _logger = logger;
    }
    // GET
    public IActionResult ChiTietSanPham()
    {
        return View();
    }
}