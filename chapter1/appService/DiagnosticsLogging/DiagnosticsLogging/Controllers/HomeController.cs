using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiagnosticsLogging.Models;
using DiagnosticsLogging.Services;

namespace DiagnosticsLogging.Controllers;

public class HomeController : Controller
{
    private LoggingService _loggingService;

    public HomeController(LoggingService loggingService) => _loggingService = loggingService;
   
    public IActionResult Index() => View();

    [HttpPost("exception")]
    public void ThrowException(string logMessage) => _loggingService.ThrowException(logMessage);

    [HttpPost("logError")]
    public void LogError(string logMessage) => _loggingService.Log(LogLevel.Error, logMessage);

    [HttpPost("logWarning")]
    public void LogWarning(string logMessage) => _loggingService.Log(LogLevel.Error, logMessage);

    [HttpPost("logInfo")]
    public void LogInfo(string logMessage) => _loggingService.Log(LogLevel.Error, logMessage);

    [HttpPost("pingpost")]
    public IActionResult PingPost(string logMessage) => new JsonResult(new { msg = logMessage });

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
