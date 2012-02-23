using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IPanel
    {
        // Panel Methods
        PanelGetComponentsResponse PanelGetComponents(string sUserName, string sSessionGuid, string sPanelGuid, string sPartitionGuid);
        PanelGetComponentsResponse PanelGetComponentsByName(string sUserName, string sSessionGuid, string sPanelName, string sPartitionName);
        PanelGetListResponse PanelGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        PanelGetListResponse PanelGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        bool PanelGetTimezones(string sUserName, string sSessionGuid, string sPanelGuid);
        bool PanelGetTimezonesByName(string sUserName, string sSessionGuid, string sPanelName, string sPartitionName);
        bool PanelModifyTimezone(string sUserName, string sSessionGuid, string sPanelGuid, int iTimezonePos, string sTimezoneGuid, string sOutputGroupGuid);
        bool PanelModifyTimezoneByName(string sUserName, string sSessionGuid, string sPanelName, string sPartitionName, int iTimezonePos, string sTimezoneName, string sOutputGroupName);
    }
}
