using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    public interface ITeam
    {
        List<TeamResponse> TeamGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        List<TeamResponse> TeamGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
    }
}
