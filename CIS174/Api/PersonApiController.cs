using CIS174.Filters;
using CIS174.Models;
using CIS174.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CIS174.Api
{
    [Route("api/person")]
    [FeatureEnabled(IsEnabled = true)]
    [ValidateModel]
    [HandleException]
    [LogResourceFilter]
    [ApiController]
    public class PersonApiController : ControllerBase
    {
        private ILogger<PersonApiController> _log;
        public readonly PersonService _personService;

        public PersonApiController(PersonService personService, ILogger<PersonApiController> log)
        {
            _personService = personService;
            _log = log;
        }

        [ExceptionLoggingAttribute]
        [EnsurePersonExists]
        [AddLastModifiedHeader]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            _log.LogWarning("Logger is running");
            var detail = _personService.GetPersonDetail(id);

            return Ok(detail);
        }

        [EnsurePersonExists]
        [HttpPost("{id}")]
        public IActionResult Edit(int id, [FromBody] UpdatePersonCommand command)
        {
            _personService.UpdatePerson(id, command);
            return Ok();

        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create( [FromBody] CreatePersonCommand command)
        {
            _personService.CreatePerson( command);
            return Ok();
        }

        [EnsurePersonExists]
        [Route("delete")]
        [HttpPost]
        public IActionResult Delete( int id)
        {
            _personService.DeletePerson(id);

            return Ok();

        }
    }
}
