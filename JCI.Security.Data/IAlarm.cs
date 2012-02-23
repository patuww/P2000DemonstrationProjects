using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookComputing.XmlRpc;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    [XmlRpcUrl("http://10.10.93.87:41023")]
    public interface IAlarm
    {
        AlarmResponse AlarmGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        AlarmResponse AlarmGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        AlarmState AlarmGetState(string sUserName, string sSessionGuid, string sAlarmGuid);
        bool AlarmUpdate(string sUserName, string sSessionGuid, string sAlarmGuid, int iAlarmState, string sResponse);
        bool AlarmAction(string sUserName, string sSessionGuid, string sAlarmConditionSequenceGuid, int iNewAlarmState, string sResponse);
    }
}
