using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    public interface ITerminal
    {

        List<TerminalResponse> TerminalGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        List<TerminalResponse> TerminalGetListByName(string sUserName, string sSessionGuid, string sPartitionName);

    }
}
