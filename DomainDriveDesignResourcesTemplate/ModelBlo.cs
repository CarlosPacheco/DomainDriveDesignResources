using System.Collections.Generic;
using System.IO;
using System.Linq;
using Business.Core;
using Business.LogicObjects.MultimediaFiles;
using $SearchFiltersNamespace$;
using $EntityModelNamespace$;
using CrossCutting.Helpers.Helpers;
using CrossCutting.Security.Identity;
using Dapper;
using $DataInterfacesNamespace$;
using Serilog;

namespace $BuisnessNamespace$
{
    public partial class $basename$Blo : BaseBlo<I$basename$Dao>, I$basename$Blo
    {
        public IMultimediaBlo MultimediaBLO { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="$basename$Blo"/> (Business Controller)
        /// </summary>
        /// <param name="authorization">Security information access object to be used by this instance</param>
        /// <param name="dataAccess">Application Request's data access object to be used by this instance</param>
        public $basename$Blo($basename$Dao dataAccess, IAuthorization authorization, ILogger logger, IMultimediaBlo multimediaBLO) : base(dataAccess, authorization, logger)
        {
            MultimediaBLO = multimediaBLO;
        }

        /// <summary>
        /// Gets a list of $basename$s
        /// </summary>
        /// <param name="searchFilter">Filtering and ordering restrictions</param>
        /// <returns>A list of $basename$s</returns>
        public IEnumerable<$basename$> Get($basename$SearchFilter searchFilter)
        {
            return DataAccess.Get(searchFilter);
        }

        /// <summary>
        /// Updates a $basename$ with the specified information
        /// </summary>
        /// <param name="dto">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        public void Update($basename$ dto)
        {
            DataAccess.Update(dto);
        }

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="dto">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>  
        public $basename$ Create($basename$ dto)
        {
            return GetById(DataAccess.Create(dto));
        }

        /// <summary>
        /// Gets an $basename$ by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$ unique identifier</param>
        /// <returns>$basename$ with the specified unique identifier</returns>
        public $basename$ GetById(int id)
        {
            return DataAccess.GetById(id);
        }

        /// <summary>
        /// Export $basename$s 
        /// </summary>
        /// <param name="searchFilter"></param>
        /// <param name="mediaTypeName"></param>
        /// <returns>The csv file with a list of <see cref="$basename$"/> instances</returns>    
        public Stream Export($basename$SearchFilter searchFilter, string mediaTypeName)
        {
            IList<dynamic> fileData = DataAccess.Get(searchFilter)
              .Select((Product) => new
              {
                  Product.Id,
                  Product.Name,
                  LastUpdatedOn = Product.UpdatedOn?.ToString("dd/MM/yyyy hh:mm")
              }).AsList<dynamic>();

            //if (mediaTypeName == MediaType.Application.Csv)
            //{
            //    return FileCreateHelper.Csv(fileData);
            //}

            //if (mediaTypeName != MediaType.Application.Excel)
            //{
            //    throw new BadRequestException();
            //}

            return FileCreateHelper.Excel(fileData);
        }
    }
}
