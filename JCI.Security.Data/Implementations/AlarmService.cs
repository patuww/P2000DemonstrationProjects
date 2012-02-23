using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookComputing.XmlRpc;
using JCI.Security.Data.DTO;
using System.Security;

namespace JCI.Security.Data.Implementations
{

    public class AlarmService : IAlarm
    {
        public Guid GetSessionGuid(string sUserName, SecureString sPassword)
        {
            
            IAlarm AlarmService = (IAlarm)XmlRpcProxyGen.Create(typeof(IAlarm));
            throw new NotImplementedException();
        }

        public AlarmResponse AlarmGetList(string sUserName, string sSessionGuid, string sPartitionGuid)
        {
            AlarmResponse alarmResponse;
            IAlarm AlarmService = (IAlarm)XmlRpcProxyGen.Create(typeof(IAlarm));
            alarmResponse = AlarmService.AlarmGetList(sUserName, sSessionGuid, sSessionGuid);

            throw new NotImplementedException();
        }

        public AlarmResponse AlarmGetListByName(string sUserName, string sSessionGuid, string sPartitionName)
        {
            throw new NotImplementedException();
        }

        public AlarmState AlarmGetState(string sUserName, string sSessionGuid, string sAlarmGuid)
        {
            throw new NotImplementedException();
        }

        public bool AlarmUpdate(string sUserName, string sSessionGuid, string sAlarmGuid, int iAlarmState, string sResponse)
        {
            throw new NotImplementedException();
        }

        public bool AlarmAction(string sUserName, string sSessionGuid, string sAlarmConditionSequenceGuid, int iNewAlarmState, string sResponse)
        {
            throw new NotImplementedException();
        }
    }
}
