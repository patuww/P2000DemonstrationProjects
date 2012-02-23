using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    public interface IMultiCommand
    {
        MultiCommandResponse MultiCommandGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        MultiCommandResponse MultiCommandGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        MultiCommandGetStatusResponse MultiCommandGetStatus(string sUserName, string sSessionGuid, string sMultiCommandGuid);
        MultiCommandGetStatusResponse MultiCommandGetStatusByName(string sUserName, string sSessionGuid, string sMultiCommandName, string sPartitionName);
        bool MultiCommandSetStatus(string sUserName, string sSessionGuid, string sMultiCommandGuid, int iState);
        bool MultiCommandSetStatusByName(string sUserName, string sSessionGuid, string sMultiCommandName, string sPartitionName, int iState);
    }
}
