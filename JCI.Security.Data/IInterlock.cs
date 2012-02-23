using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    public interface IInterlock
    {
        InterlockGetListResponse InterlockGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        InterlockGetListResponse InterlockGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        InterlockGetStatusResponse InterlockGetStatus(string sUserName, string sSessionGuid, string sInterlockGuid);
        InterlockGetStatusResponse InterlockAccessPointGetStatusByName(string sUserName, string sSessionGuid, string sInterlockName, string sPartitionName);

    }
}
