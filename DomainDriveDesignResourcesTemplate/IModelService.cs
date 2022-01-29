using System.Collections.Generic;
using System.IO;
using Business.Core.Services;
using $BuisnessNamespace$;
using $SearchFiltersNamespace$;
using $DataTransferObjectsNamespace$;
using Microsoft.AspNetCore.Http;

namespace $ServiceNamespace$
{
    public interface I$basename$Service : IBaseService<I$basename$Blo>
    {
        /// <summary>
        /// Gets a list of $basename$s
        /// </summary>
        /// <param name="searchFilter">Filtering and ordering restrictions</param>
        /// <returns>A list of $basename$s</returns>
        IEnumerable<$basename$Dto> Get($basename$SearchFilter searchFilter);

        /// <summary>
        /// Updates a $basename$ with the specified information
        /// </summary>
        /// <param name="dto">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        void Update($basename$Dto dto, IFormFile file);

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="dto">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>  
        $basename$Dto Create($basename$Dto dto, IFormFile file);

        /// <summary>
        /// Gets an $basename$ by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$ unique identifier</param>
        /// <returns>$basename$ with the specified unique identifier</returns>
        $basename$Dto GetById(int id);

        /// <summary>
        /// Export $basename$
        /// </summary>
        /// <param name="searchFilter"></param>
        /// <param name="mediaTypeName"></param>
        /// <returns>The csv file with a list of <see cref="Product"/> instances</returns>    
        Stream Export($basename$SearchFilter searchFilter, string mediaTypeName);
    }
}
