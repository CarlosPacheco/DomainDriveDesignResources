using $SearchFiltersNamespace$;
using $DataTransferObjectsNamespace$;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace $ControllerNamespace$
{
    public interface I$basename$Controller
    {
        /// <summary>
        /// Gets a list of $basename$s
        /// </summary>
        /// <param name="searchFilter">Filtering and ordering restrictions</param>
        /// <returns>A list of $basename$s</returns>
        IActionResult Get([FromQuery] $basename$SearchFilter searchFilter);

        /// <summary>
        /// Updates a $basename$ with the specified information
        /// </summary>
        /// <param name="id">$basename$ unique identifier</param>
        /// <param name="dto">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        IActionResult Update(int id, $basename$Dto dto, IFormFile file);

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="caseDto">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>  
        IActionResult Create($basename$Dto dto, IFormFile file);

        /// <summary>
        /// Gets an $basename$ by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$ unique identifier</param>
        /// <returns>$basename$ with the specified unique identifier</returns>
        IActionResult GetById(int id);

        /// <summary>
        /// Export $basename$ Details 
        /// </summary>
        /// <param name="searchFilter"></param>
        /// <param name="mediaTypeName"></param>
        /// <returns>The csv file with a list of <see cref="$basename$"/> instances</returns>  
        IActionResult Export([FromQuery] $basename$SearchFilter searchFilter, [FromHeader(Name = "Content-Type")] string mediaTypeName);
    }
}
