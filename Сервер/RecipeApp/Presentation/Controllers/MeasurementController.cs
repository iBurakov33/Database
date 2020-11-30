using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Business_Logic.Services;
using RecipeApp.Business_Logic.Interfaces;
using RecipeApp.Business_Logic.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurmentService _service;
        public MeasurementController(IMeasurmentService service)
        {
            _service = service;
        }
        [HttpGet("One measurement")]
        public MeasurementDTO GetOneMeasurement(Guid id)
        {
            return _service.Get(id);
        }
        [HttpGet("All measurements")]
        public IEnumerable<MeasurementDTO> GetAllMeasurements()
        {
            return _service.GetAll();
        }
    }
}
