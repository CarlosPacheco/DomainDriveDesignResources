using System.Collections.Generic;
using Dapper;
using $EntityModelNamespace$;

namespace $DataNamespace$
{
    public partial class $basename$Dao
    {
        /// <summary>
        /// Get the listings $basename$s 
        /// </summary>
        /// <returns>The list of $basename$s </returns>
        public IEnumerable<$basename$> GetProductListing()
        {
            string query = $@"SELECT DISTINCT L.Id, CD.Id
            FROM $basename$ C
            INNER JOIN X L  ON CD.IdX = L.Id";

            return DbConnection.Query<$basename$> (query).AsList();
        }
    }
}
