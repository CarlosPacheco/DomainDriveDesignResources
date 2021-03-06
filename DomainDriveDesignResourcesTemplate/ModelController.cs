using System;
using CrossCutting.SearchFilters.DataAccess;
using System.IO;
using System.Net.Mime;
using $ServiceNamespace$;
using $SearchFiltersNamespace$;
using $DataTransferObjectsNamespace$;
using CrossCutting.Web.Controllers;
using CrossCutting.Web.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace $ControllerNamespace$
{
    [Route("api/[controller]")]
    public class $basename$Controller : BaseApiController, I$basename$Controller
    {
        /// <summary>
        /// Service object layer
        /// </summary>
        private readonly I$basename$Service _service;

        public $basename$Controller(ILogger<$basename$Controller> logger, I$basename$Service service) : base(logger)
        {
            _service = service;
        }

        /// <summary>
        /// Gets a list of $basename$s
        /// </summary>
        /// <param name="searchFilter">Filtering and ordering restrictions</param>
        /// <returns>A list of $basename$s</returns>
        [HttpGet, ProducesResponseType(typeof(IPaginatedList<$basename$Dto>), StatusCodes.Status200OK), ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get([FromQuery] $basename$SearchFilter searchFilter)
        {
            return PagedData(_service.Get(searchFilter));
        }

        /// <summary>
        /// Updates a $basename$ with the specified information
        /// </summary>
        /// <param name="dto">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        [Route("")]
        [HttpPut, ProducesResponseType(typeof(void), StatusCodes.Status200OK), ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update($basename$Dto dto)
        {
            if (dto == null || dto.Id == null || dto.Id <= 0)
            {
                return BadRequest();
            }

            _service.Update(dto);

            return Ok();
        }

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="dto">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>       
        [Route("", Name = "$basename$_Create")]
        [HttpPost, ProducesResponseType(typeof($basename$Dto), StatusCodes.Status200OK)]
        public IActionResult Create($basename$Dto dto)
{
            $basename$Dto newDto = _service.Create(dto);

            return CreatedAtRoute("$basename$_GetById", new { id = newDto.Id }, newDto);
        }

        /// <summary>
        /// Gets an $basename$ by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$ unique identifier</param>
        /// <returns>$basename$ with the specified unique identifier</returns>
        [Route("{id}", Name = "$basename$_GetById")]
        [HttpGet, ProducesResponseType(typeof($basename$Dto), StatusCodes.Status200OK), ProducesResponseType(StatusCodes.Status204NoContent), ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
{
            $basename$Dto dto = _service.GetById(id);

            return dto == null ? NotFound() : Ok(dto);
        }

        /// <summary>
        /// Export $basename$ Details 
        /// </summary>
        /// <param name="searchFilter"></param>
        /// <param name="mediaTypeName"></param>
        /// <returns>The csv file with a list of <see cref="$basename$"/> instances</returns>  
        [Route("export", Name = "$basename$_Export")]
        [HttpGet, ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public IActionResult Export([FromQuery] $basename$SearchFilter searchFilter, [FromHeader(Name = "Content-Type")] string mediaTypeName)
        {
            Stream stream = _service.Export(searchFilter, mediaTypeName);

            return File(stream, MediaTypeNames.Application.Octet, $"$basename$List{DateTime.UtcNow:o}{(mediaTypeName == MediaType.Application.Excel ? ".xlsx" : ".csv")}");
        }
    }
}