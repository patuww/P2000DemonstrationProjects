using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface ICounter
    {
        CounterResponse CounterGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        CounterResponse CounterGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        CounterResponse CounterGetValue(string sUserName, string sSessionGuid, string sCounterGuid);
        CounterResponse CounterGetValueByName(string sUserName, string sSessionGuid, string sCounterName, string sPartitionName);
        bool CounterSetValue(string sUserName, string sSessionGuid, string sCounterGuid, int iValue);
        bool CounterSetValueByName(string sUserName, string sSessionGuid, string sCounterName, string sPartitionName, int iValue);
        bool CounterChangeValueByName(string sUserName, string sSessionGuid, string sCounterName, string sPartitionName, int iValueBy);
    }
}
