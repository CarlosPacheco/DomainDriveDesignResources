using System.Collections.Generic;
using $SearchFiltersNamespace$;
using $EntityModelNamespace$;

namespace $BuisnessNamespace$
{
    public partial class $basename$Blo
    {
        /// <summary>
        /// Get the listings $basename$s 
        /// </summary>
        /// <returns>The list of $basename$s </returns>
        public IEnumerable<$basename$> Get$basename$Listing()
        {
            return DataAccess.Get$basename$Listing();
        }

    }
}
