using System.Collections.Generic;
using Business.Core.Data.Interfaces;
using $SearchFiltersNamespace$;
using $EntityModelNamespace$;

namespace $DataInterfacesNamespace$.$basename$s
{
    public partial interface I$basename$Dao : IBaseDao
    {
        /// <summary>
        /// Gets a list of $basename$s
        /// </summary>
        /// <param name="searchFilter">Filtering and ordering restrictions</param>
        /// <returns>A list of $basename$s</returns>
        IEnumerable<$basename$> Get($basename$SearchFilter searchFilter);

        /// <summary>
        /// Updates a $basename$ with the specified information
        /// </summary>
        /// <param name="dto">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        void Update($basename$ dto);

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="dto">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>  
        int Create($basename$ dto);

        /// <summary>
        /// Gets an $basename$ by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$ unique identifier</param>
        /// <returns>$basename$ with the specified unique identifier</returns>
        $basename$ GetById(int id);
    }
}
