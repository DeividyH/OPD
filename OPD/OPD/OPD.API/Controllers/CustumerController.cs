using Microsoft.AspNetCore.Mvc;
using OPD.Application.Dtos.Custumers;
using OPD.Application.Interfaces.Custumers;
using System;
using System.Collections.Generic;

namespace OPD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustumerController : ControllerBase
    {
        private readonly IApplicationServiceCustumer _applicationServiceCustumer;

        public CustumerController(IApplicationServiceCustumer applicationServiceCustumer)
        {
            _applicationServiceCustumer = applicationServiceCustumer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCustumer.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCustumer.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CustumerDto custumerDto)
        {
            try
            {
                if (custumerDto == null)
                    return NotFound();

                _applicationServiceCustumer.Create(custumerDto);

                return Ok("Success!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CustumerDto custumerDto)
        {
            try
            {
                if (custumerDto == null)
                    return NotFound();

                _applicationServiceCustumer.Update(custumerDto);

                return Ok("Success!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] CustumerDto custumerDto)
        {
            try
            {
                if (custumerDto == null)
                    return NotFound();

                _applicationServiceCustumer.Delete(custumerDto);

                return Ok("Success!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
