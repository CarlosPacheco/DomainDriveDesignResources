using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Business.Core.Data;
using $DataInterfacesNamespace$;
using $SearchFiltersNamespace$;
using $EntityModelNamespace$;
using CrossCutting.Exceptions;
using CrossCutting.SearchFilters.DataAccess;
using Dapper;
using Serilog;

namespace $DataNamespace$
{
    public partial class $basename$Dao : BaseDao, I$basename$Dao
    {
        public $basename$Dao(ILogger logger, IDbConnection dbConnection, IPagedQueryBuilder pagedQueryBuilder) : base(logger, dbConnection, pagedQueryBuilder)
        {
        }

        /// <summary>
        /// Gets a list of $basename$s
        /// </summary>
        /// <param name="searchFilter">Filtering and ordering restrictions</param>
        /// <returns>A list of $basename$s</returns>
        public IEnumerable<$basename$> Get($basename$SearchFilter searchFilter)
        {
            return ExecutePagedQuery<$basename$> (GetGetQuery(searchFilter, out object parameters), searchFilter, parameters);
        }

        /// <summary>
        /// Updates a $basename$ with the specified information
        /// </summary>
        /// <param name="entity">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        public void Update($basename$ entity)
        {
            try
            {
                BeginTransaction();

                int rows = DbConnection.Execute
                (
                    @"UPDATE $basename$
                SET Name = ISNULL(@Name, Name), 
                    UpdatedOn = GETUTCDATE(),
                    UpdatedBy = ISNULL(@UserName, UpdatedBy)
                WHERE ID = @Id",
                    new
                    {
                        entity.Name,
                        UserName = entity.UpdatedBy
                    },
                    CurrentTransaction
                );

                if (rows == 0)
                {
                    throw new EntityNotFoundException();
                }

                CommitTransaction();
            }
            catch (Exception)
            {
                RollbackTransaction();
                throw;
            }
        }

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="entity">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>  
        public int Create($basename$ entity)
        {
            try
            {
                BeginTransaction();

                string insertSql = @"/* $basename$DAO - Create */
                
                INSERT INTO $basename$ (
                   Name, CreatedBy, UpdatedBy
                ) 
                values 
                (
                    @Name, @UserName, @UserName
                ) 

                RETURNING Id";

                int newId = DbConnection.ExecuteScalar<int>
                (
                    insertSql,
                    new
                    {
                        entity.Name,
                        UserName = entity.CreatedBy
                    },
                    CurrentTransaction
                );

                CommitTransaction();
                return newId;
            }
            catch (Exception)
            {
                RollbackTransaction();
                throw;
            }
        }

        /// <summary>
        /// Gets an $basename$ by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$ unique identifier</param>
        /// <returns>$basename$ with the specified unique identifier</returns>
        public $basename$ GetById(int id)
        {
            $basename$ entity = DbConnection.Query<$basename$> (QueryGetByIdentifier, new { Id = id }, CurrentTransaction).FirstOrDefault();

            if (entity == null)
            {
                return null;
            }

            return entity;
        }

    }
}
