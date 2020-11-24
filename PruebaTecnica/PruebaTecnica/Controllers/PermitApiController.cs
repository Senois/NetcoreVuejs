using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PermitApiController : ControllerBase
    {

        private readonly AppDBContext _dbContext;
        public PermitApiController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult Get()
        {
            var model = _dbContext.Permit;
            return Ok(model);
        }

        [Route("create/")]
        [HttpPost]
        public IActionResult Post(Permit model)
        {
            _dbContext.Permit.Add(model);
            _dbContext.SaveChanges();
            return Ok(model);
        }

        [Route("update/")]
        [HttpPut]
        public IActionResult Put(Permit model)
        {
            var permit = _dbContext.Permit.Find(model.PermitId);

            permit.EmployeeName = model.EmployeeName;
            permit.EmployeeLastname = model.EmployeeLastname;
            permit.PermitType = model.PermitType;
            permit.PermitDate = model.PermitDate;

            _dbContext.SaveChanges();
            return Ok(model);
        }

        [Route("delete/")]
        [HttpDelete]
        public IActionResult Delete(Permit model)
        {
            var bug = _dbContext.Permit.Find(model.PermitId);
            _dbContext.Permit.Remove(bug);
            _dbContext.SaveChanges();
            return Ok(model);
        }
    }
}
