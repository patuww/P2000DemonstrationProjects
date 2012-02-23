using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    /// <summary>
    /// 
    /// Output Point Actions
    /// Action          Name
    /// 0               Reset
    /// 1               Set
    /// 2               Slow Flash
    /// 3               Fast Flash
    /// 4               Preset
    /// 5               Pulse
    /// </summary>
    public interface IOutput
    {
        List<OutputResponse> OutputGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        List<OutputResponse> OutputGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        bool OutputSet(string sUserName, string sSessionGuid, string sOutputGuid, int iAction);
        bool OutputSetByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction);
        bool OutputSetByNameScheduled(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction, DateTime tScheduledTime);
        bool OutputSetForDuration(string sUserName, string sSessionGuid, string sOutputGuid, int iAction, int iDuration);
        bool OutputSetForDurationByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction, int iDuration);
        bool OutputSetForDurationScheduled(string sUserName, string sSessionGuid, string sOutputGuid, int iAction, int iDuration, DateTime tScheduledTime);
        bool OutputSetForDurationByNameScheduled(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction, int iDuration, DateTime tScheduledTime);
        bool OutputSetScheduled(string sUserName, string sSessionGuid, string sOutputGuid, int iAction, DateTime tScheduledTime);
        OutputGetScheduledResponse OutputGetScheduled(string sUserName, string sSessionGuid, string sOutputGuid);
        OutputGetScheduledResponse OutputGetScheduledByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName);
        bool OutputDeleteScheduled(string sUserName, string sSessionGuid, int iScheduledID);
        bool OutputGetStatus(string sUserName, string sSessionGuid, string sOutputGuid);
        bool OutputGetStatusByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName);
    }
}
