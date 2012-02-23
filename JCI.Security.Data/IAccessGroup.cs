using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    /// <summary>
    /// Access Group Methods
    /// The methods listed in this section are based on the P2000 V3.x methodology. The functions are named based on the P2000 item type they are associated with and the corresponding operation.
    /// </summary>
    interface IAccessGroup
    {
        // Access Group Methods
        bool AccessGroupAdd(string sUserName, string sSessionGuid, string sAccessGroupName, string sAccessGroupGuid, string sPartitionGuid, int iPublic, string[] sTerminalGuids, string[] sTerminalGroupGuids);
        bool AccessGroupAddByName(string sUserName, string sSessionGuid, string sAccessGroupName, string sAccessGroupGuid, string sPartitionName, int iPublic, string[] sTerminals, string[] sTerminalGroups);
        AccessGroupResponse AccessGroupGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        AccessGroupResponse AccessGroupGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        bool AccessGroupModify(string sUserName, string sSessionGuid, string sAccessGroupGuid, string[] sTerminalGuids, string[] sTerminalGroupGuids);
        bool AccessGroupModifyByName(string sUserName, string sSessionGuid, string sAccessGroupName, string sPartitionName, string[] sTerminalNames, string[] sTerminalGroupNames);
        bool AccessGroupDelete(string sUserName, string sSessionGuid, string sAccessGroupGuid);
        bool AccessGroupDeleteByName(string sUserName, string sSessionGuid, string sAccessGroupName, string sPartitionName);
        bool AccessPointEnable(string sUserName, string sSessionGuid, string sAccessPointGuid, int iEnable);
        AccessGroupResponse AccessPointGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        AccessGroupResponse AccessPointGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        AccessGroupResponse AccessPointGetSecurityLevel(string sUserName, string sSessionGuid, string sAccessPointGuid);
        AccessGroupResponse AccessPointGetSecurityLevelByName(string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName);
        AccessGroupResponse AccessPointGetStatus(string sUserName, string sSessionGuid, string sAccessPointGuid);
        AccessGroupResponse AccessPointGetStatusByName (string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName);
        bool AccessPointSetSecurityLevel(string sUserName, string sSessionGuid, string sAccessPointGuid, int iSecurityLevel);
        bool AccessPointSetSecurityLevelByName (string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName, int iSecurityLevel);
        bool AccessPointSetSecurityLevelColor(string sUserName, string sSessionGuid, string sAccessPointGuid, int iSecurityColor);
        bool AccessPointSetSecurityLevelColorByName (string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName, string sSecurityLevelColor);

    }
}
