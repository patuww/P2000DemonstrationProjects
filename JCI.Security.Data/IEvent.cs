using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IEvent
    {
        bool EventDeleteScheduled(string sUserName, string sSessionGuid, int iScheduledID);
        bool EventTrigger(string sUserName, string sSessionGuid, string sEventGuid);
        bool EventTriggerScheduled(string sUserName, string sSessionGuid, string sEventGuid, DateTime tScheduledTime);
        bool EventTriggerByName(string sUserName, string sSessionGuid, string sEventName, string sPartitionName);
        bool EventTriggerByNameScheduled(string sUserName, string sSessionGuid, string sEventName, string sPartitionName, DateTime tScheduledTime);
        EventResponse EventGetAllScheduled(string sUserName, string sSessionGuid, string sPartitionGuid);
        EventResponse EventGetAllScheduledByName(string sUserName, string sSessionGuid, string sPartitionName);
    }
}
