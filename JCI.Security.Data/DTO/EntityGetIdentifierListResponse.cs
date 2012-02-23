using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class EntityGetIdentifierListResponse
    {

        /// <summary>
        /// Facility Code
        /// </summary>
        public string FacilityCode { get; set; }
        /// <summary>
        /// Guid of Identifier
        /// </summary>
        public Guid IdentifierGuid { get; set; }
        /// <summary>
        /// Identifier Number
        /// </summary>
        public int IdentifierNumber { get; set; }
    }
}
