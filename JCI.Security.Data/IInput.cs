using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IInput
    {
        bool InputDisable(string sUserName, string sSessionGuid, string sInputGuid, int iDisable);
        bool InputDisableByName(string sUserName, string sSessionGuid, string sInputName, string sPartitionName, int iDisable);
        InputGetListResponse InputGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        InputGetListResponse InputGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        InputGetStatusResponse InputGetStatus(string sUserName, string sSessionGuid, string sInputGuid);
        InputGetStatusResponse InputGetStatusByName(string sUserName, string sSessionGuid, string sInputName, string sPartitionName);
        bool InputSuppress(string sUserName, string sSessionGuid, string sInputGuid, int iDuration);
        bool InputSuppressByName(string sUserName, string sSessionGuid, string sInputName, string sPartition, int iDuration);
    }
}
