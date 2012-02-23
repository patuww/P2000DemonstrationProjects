using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IIdentifier
    {
        /// <summary>
        /// Identifiers the get info.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sIdentifierNumber">The s identifier number.</param>
        /// <param name="iFacilityCode">The i facility code.</param>
        /// <returns><see cref="IdentifierGetInfoResponse"/></returns>
        IdentifierGetInfoResponse IdentifierGetInfo(string sUserName, string sSessionGuid, string sIdentifierNumber, int iFacilityCode);
        /// <summary>
        /// Identifiers the get purpose.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sIdentifierNumber">The s identifier number.</param>
        /// <param name="iFacilityCode">The i facility code.</param>
        /// <returns>Configured identifier purpose</returns>
        string IdentifierGetPurpose(string sUserName, string sSessionGuid, string sIdentifierNumber, int iFacilityCode);
    }
}
