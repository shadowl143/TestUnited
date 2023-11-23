using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Axity.DataAccessEntity.Api.Controllers
{
    /// <summary>
    /// Controller.
    /// </summary>
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICatalogService<UserDto> modelFacade;

        /// <summary>
        /// controller.
        /// </summary>
        /// <param name="modelFacade">facade.</param>
        public UserController(ICatalogService<UserDto> modelFacade)
        {
            this.modelFacade = modelFacade;
        }


        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get()
        {
            return await this.modelFacade.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await this.modelFacade.FindById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task Post([FromBody] UserDto model)
        {
            await this.modelFacade.Create(model);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task Put([FromBody] UserDto model)
        {
            await this.modelFacade.Update(model);

        }

        // DELETE api/<UserController>/5
        [HttpDelete]
        public async Task Delete([FromBody] UserDto model)
        {
            await this.modelFacade.Delete(model);

        }
    }
}
