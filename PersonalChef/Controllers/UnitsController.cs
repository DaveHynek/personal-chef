using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PersonalChef.Common;
using PersonalChef.Data.Contexts;
using PersonalChef.Data.Models.Recipes;
using PersonalChef.Data.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalChef.Controllers
{
    [Route("api/[controller]")]
    public class UnitsController : Controller
    {
        private readonly IRepositoryFactory<RecipeContext, MeasurementUnit> _factory;

        public UnitsController(IRepositoryFactory<RecipeContext,MeasurementUnit> factory)
        {
            _factory = factory;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<UnitDTO> Get()
        {
            var repo = _factory.CreateRepository();
            return repo.GetAllAsync().Result.Select(x => new UnitDTO(x));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class UnitDTO
    {
        public UnitDTO(MeasurementUnit unit)
        {
            ID = (int)unit.Unit;
            Name = GetDescription(unit.Unit);
        }

        public int ID { get; set; }
        public string Name { get; set; }

        private string GetDescription(Units unit)
        {
            var memInfo = typeof(Units).GetMember(System.Enum.GetName(typeof(Units), unit));
            var descriptionAttribute = memInfo[0]
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() as DescriptionAttribute;
            return descriptionAttribute?.Description;
        }
    }

}
