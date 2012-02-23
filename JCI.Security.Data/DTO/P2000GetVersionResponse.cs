using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class P2000GetVersionResponse
    {
        /// <summary>
        ///  Build Number
        /// </summary>
        public string BuildNumber { get; set; }
        /// <summary>
        ///  TimeStamp when P2000 was last updated or a new registration key was entered for this system
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        ///  Major Version Number
        /// </summary>
        public string MajorVersion { get; set; }
        /// <summary>
        ///  Minor Version Number
        /// </summary>
        public string MinorVersion { get; set; }
    }
}
