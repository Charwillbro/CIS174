using System;
using CIS174.Filters;
using CIS174.Models;
using CIS174.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS174.Api
{
    [Route("api/person")]
    [FeatureEnabled(IsEnabled = true)]
    [ValidateModel]
    [HandleException]
    [ApiController]
    public class PersonApiController : ControllerBase
    {

        public readonly PersonService _personService;

        public PersonApiController(PersonService personService)
        {
            _personService = personService;
        }

        [EnsureRecipeExists]
        [AddLastModifiedHeader]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var detail = _personService.GetPersonDetail(id);

            return Ok(detail);
        }

        [EnsureRecipeExists]
        [HttpPost("{id}")]
        public IActionResult Edit(int id, [FromBody] UpdatePersonCommand command)
        {
            _personService.UpdatePerson(id, command);
            return Ok();

        }
    }
}
