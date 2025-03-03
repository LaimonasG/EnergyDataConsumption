using Microsoft.AspNetCore.Mvc;
using EnergyDataConsumption.Data.Repositories;

namespace EnergyDataConsumption.Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnergyDataController : ControllerBase
    {
         private readonly IEnergyDataRepository _repository;

public EnergyDataController(IEnergyDataRepository repository)
{
    _repository = repository;
}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Energy data retrieved successfully.");
        }

        [HttpPost]
        public IActionResult Post([FromBody] object energyData)
        {
            // Add logic to handle the posted energy data
            return Ok("Energy data posted successfully.");
        }
    }
}