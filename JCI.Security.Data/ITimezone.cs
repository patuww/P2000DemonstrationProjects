using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    public interface ITimezone
    {

        bool TimezoneAdd(string sUserName, string sSessionGuid, string sTimezoneName, string sTimezoneGuid, string sPartitionGuid, int iPublic, int iAddToAllPanels, int iInitialStates, DateTime[] tTimes);
        bool TimezoneAddByName(string sUserName, string sSessionGuid, string sTimezoneName, string sTimezoneGuid, string sPartitionName, int iPublic, int iAddToAllPanels, int iInitialStates, DateTime[] tTimes);
        bool TimezoneIsActive(string sUserName, string sSessionGuid, string sTimezoneGuid);
        bool TimezoneIsActiveByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName);
        TimezoneGetInfoResponse TimezoneGetInfo(string sUserName, string sSessionGuid, string sTimezoneGuid);
        TimezoneGetInfoResponse TimezoneGetInfoByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName);
        List<TimezoneGetListResponse> TimezoneGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        List<TimezoneGetListResponse> TimezoneGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        bool TimezoneModify(string sUserName, string sSessionGuid, string sTimezoneGuid, int iInitialState, DateTime[] tTimes);
        bool TimezoneModifyByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName, int iInitialState, DateTime[] tTimes);
        bool TimezoneDelete(string sUserName, string sSessionGuid, string sTimezoneGuid);
        bool TimezoneDeleteByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName);

    }
}
