using System.Collections.Generic;
using System.IO;
using AutoMapper;
using Business.Core.Services;
using $BuisnessNamespace$;
using $SearchFiltersNamespace$;
using $DataTransferObjectsNamespace$;
using CrossCutting.SearchFilters.Extensions;
using CrossCutting.Security.Identity;
using Microsoft.AspNetCore.Http;
using $EntityModelNamespace$;

namespace $ServiceNamespace$
{
    public class $basename$Service : BaseService<I$basename$Blo>, I$basename$Service
    {
        public $basename$Service(I$basename$Blo businessLogic, IHttpContextAccessor httpContextAccessor, IMapper mapper, IAuthorization authorization) : base(businessLogic, httpContextAccessor, mapper, authorization)
        {
        }

        /// <summary>
        /// Gets a list of $basename$s
        /// </summary>
        /// <param name="searchFilter">Filtering and ordering restrictions</param>
        /// <returns>A list of $basename$s</returns>
        public IEnumerable<$basename$Dto> Get($basename$SearchFilter searchFilter)
        {
            IEnumerable<$basename$Dto> dto = Mapper.MapPaged<$basename$Dto, $basename$>(BusinessLogic.Get(searchFilter));

            return dto;
        }

        /// <summary>
        /// Updates a $basename$ with the specified information
        /// </summary>
        /// <param name="dto">Patch object containing the new $basename$ value</param>
        /// <returns>The modified $basename$ object</returns>
        public void Update($basename$Dto dto)
        {
            $basename$ entity = Mapper.Map<$basename$>(dto);
           
            BusinessLogic.Update(entity);
        }

        /// <summary>
        /// Creates a new $basename$ 
        /// </summary>
        /// <param name="dto">The new entity description object</param>
        /// <returns>The newly created $basename$</returns>  
        public $basename$Dto Create($basename$Dto dto)
        {
            $basename$ entity = BusinessLogic.Create(Mapper.Map<$basename$>(dto));

            return GetById(entity.Id.Value);
        }

        /// <summary>
        /// Gets an $basename$  by it's unique identifier
        /// </summary>
        /// <param name="id">The $basename$  unique identifier</param>
        /// <returns>$basename$  with the specified unique identifier</returns>
        public $basename$Dto GetById(int id)
        {
            $basename$Dto dto = Mapper.Map<$basename$Dto>(BusinessLogic.GetById(id));

            return dto;
        }

        /// <summary>
        /// Export $basename$ 
        /// </summary>
        /// <param name="searchFilter"></param>
        /// <param name="mediaTypeName"></param>
        /// <returns>The csv file with a list of <see cref="$basename$ "/> instances</returns>    
        public Stream Export($basename$SearchFilter searchFilter, string mediaTypeName)
        {
            return BusinessLogic.Export(searchFilter, mediaTypeName);
        }
    }
}
