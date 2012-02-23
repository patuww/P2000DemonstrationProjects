using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class P2000GetSystemInfoResponse
    {
        
        /// <summary>
        /// Enterprise Site GUID of this P2000 Site
        /// </summary>
        public Guid EnterpriseSiteGuid {get;set;}
        /// <summary>
        /// Name of this P2000 Site
        /// </summary>
        public string EnterpriseSiteName { get; set; }
    }
}
