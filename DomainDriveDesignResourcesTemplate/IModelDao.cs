using System.Collections.Generic;
using Business.Core.Data.Interfaces;
using $SearchFiltersNamespace$;
using $EntityModelNamespace$;

namespace $DataInterfacesNamespace$
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
        /// <param name="entity">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        void Update($basename$ entity);

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="entity">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>  
        int Create($basename$ entity);

        /// <summary>
        /// Gets an $basename$ by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$ unique identifier</param>
        /// <returns>$basename$ with the specified unique identifier</returns>
        $basename$ GetById(int id);
    }
}
