using $SearchFiltersNamespace$;
using $EntityModelNamespace$;
using Dapper;

namespace $DataNamespace$
{
    public partial class $basename$Dao
    {
        private const string GetQuery = @"/* $basename$ GetQuery */
            SELECT *
            FROM $basename$ CD
            INNER JOIN $basename$Group CDG ON CDG.Id = CD.Id$basename$Group
            INNER JOIN 
            ( 
              SELECT Id, FilePath Name
              FROM $basename$
            ) M ON M.Id = CD.Id
            /**where**/
            ";

        /// <summary>
        /// Sql query template for GetByIdentifier method.
        /// Dapper SqlBuilder placeholders included in.
        /// </summary>
        private const string QueryGetByIdentifier = @"/* $basename$ SqlGetByIdentifierQuery */
            SELECT CD.*, L.*, CDG.*, M.*
            FROM $basename$ CD 
            INNER JOIN $basename$Group CDG ON CDG.Id = CD.Id$basename$Group
            INNER JOIN 
            ( 
              SELECT Id, FilePath Name
              FROM Product
            ) M ON M.Id = CD.Id
            WHERE CD.Id = @Id ";
      

        private string GetGetQuery($basename$SearchFilter filter, out object parameters)
        {
            SqlBuilder sqlBuilder = new SqlBuilder();
            SqlBuilder.Template sqlTemplate = sqlBuilder.AddTemplate(GetQuery);           

            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                sqlBuilder.Where("CDG.Name LIKE @Name", new { Name = $"%{filter.Name}%" });
            }

            if (filter.UpdatedOnStart.HasValue)
            {
                sqlBuilder.Where("CD.UpdatedOn >= @UpdatedOnStart", new { filter.UpdatedOnStart });
            }

            if (filter.UpdatedOnEnd.HasValue)
            {
                sqlBuilder.Where("CD.UpdatedOn <= @UpdatedOnEnd", new { filter.UpdatedOnEnd });
            }

            // Return all parameters to be reused (passed to Dapper exec/query method)
            parameters = sqlTemplate.Parameters;

            return sqlTemplate.RawSql;
        }
    }
}
