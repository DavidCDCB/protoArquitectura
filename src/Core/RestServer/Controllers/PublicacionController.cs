using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Dominio;
using Interfaces;

namespace RestServer
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacionController : ControllerBase
    {
        private readonly IPublicacionRepository _postRepository;
        public PublicacionController(IPublicacionRepository postRepository)
        {
            this._postRepository = postRepository;
        }

        [HttpGet]
        public  IActionResult GetPublicacionesAsync()
        {
            var publicaciones = this._postRepository.GetPublicaciones();
            return Ok(publicaciones);
        }

        [HttpGet("{id}")]
        public IActionResult GetPublicacion(int id)
        {
            var publicacion =  this._postRepository.GetPublicacion(id);
            if (publicacion == null)
            {
                return NotFound();
            }

            return Ok(publicacion);
        }

        [HttpPost]
        public async Task<IActionResult> SetPublicacionAsync(List<Publicacion> publicaciones)
        {
            try
            {
                var creado = await this._postRepository.SetPublicacionAsync(publicaciones);
                return Ok(creado);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public async Task<IActionResult> UpdatePublicacion(Publicacion publicacion)
        {
            var actualizado = await this._postRepository.UpdatePublicacion(publicacion);

            if (actualizado == null)
            {
                return NotFound();
            }

            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemovePublicacion(int id)
        {
            var eliminado = await this._postRepository.RemovePublicacion(id);

            if (eliminado == null)
            {
                return NotFound();
            }

            return Ok(eliminado);
        }
    }
}