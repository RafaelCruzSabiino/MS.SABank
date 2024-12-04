using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;

[Route("health-check")]
[Controller]

public class HealthCheckController : Controller
{
    private readonly HealthCheckService _service;

    public HealthCheckController(HealthCheckService service)
        => _service = service;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var report = await _service.CheckHealthAsync();
        string json = JsonConvert.SerializeObject(report);

        if (report.Status == HealthStatus.Healthy)
            return Ok(json);

        return NotFound(json);
    }
}