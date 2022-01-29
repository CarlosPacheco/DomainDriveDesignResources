using System.Collections.Generic;
using $EntityModelNamespace$;

namespace $DataInterfacesNamespace$
{
    public partial interface I$basename$Dao
    {
        /// <summary>
        /// Get the listings $basename$s
        /// </summary>
        /// <returns>The list of $basename$s </returns>
        IEnumerable<$basename$> Get$basename$Listing();
    }
}
