using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IEntity
    {
        /// <summary>
        /// Entities the get info.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sEntityGuid">The s entity GUID.</param>
        /// <returns></returns>
        EntityResponse EntityGetInfo(string sUserName, string sSessionGuid, string sEntityGuid);
        /// <summary>
        /// Entities the get info by ID.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sEmployeeID">The s employee ID.</param>
        /// <returns></returns>
        EntityResponse EntityGetInfoByID(string sUserName, string sSessionGuid, string sEmployeeID);
        /// <summary>
        /// Entities the get identifier list.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sEntityGuid">The s entity GUID.</param>
        /// <param name="sPartitionGuid">The s partition GUID.</param>
        /// <returns></returns>
        EntityGetIdentifierListResponse EntityGetIdentifierList(string sUserName, string sSessionGuid, string sEntityGuid, string sPartitionGuid);

        /// <summary>
        /// Entities the get list.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sPartitionGuid">The s partition GUID.</param>
        /// <param name="sFirstNameFilter">The s first name filter.</param>
        /// <param name="sLastNameFilter">The s last name filter.</param>
        /// <param name="iMaxCount">The i max count.</param>
        /// <returns></returns>
        /// Notes:
        /// 1.Search filters can contain ‘*’ or ‘%’ to match any number of characters.
        /// 2.Search filters can contain ‘?’ or ‘_’ to match a single character.
        EntityGetListResponse EntityGetList(string sUserName, string sSessionGuid, string sPartitionGuid, string sFirstNameFilter, string sLastNameFilter, int iMaxCount);
        EntityGetListResponse EntityGetListByName(string sUserName, string sSessionGuid, string sPartitionName, string sFirstNameFilter, string sLastNameFilter, int iMaxCount);
        int EntityGetListCount(string sUserName, string sSessionGuid, string sPartitionGuid, string sFirstNameFilter, string sLastNameFilter);
        int EntityGetListCountByName(string sUserName, string sSessionGuid, string sPartitionName, string sFirstNameFilter, string sLastNameFilter);
        EntityGetUDFResponse EntityGetAllUdf(string sUserName, string sSessionGuid, string sEntityGuid);
        EntityGetUDFResponse EntityGetUdf(string sUserName, string sSessionGuid, string sEntityGuid, string sUdfGuid);
        bool EntitySetUdf(string sUserName, string sSessionGuid, string sEntityGuid, string sUdfGuid, string Value);
    }
}
