using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IDivision
    {
        DivisionResponse DivisionGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        DivisionResponse DivisionGetListByName(string sUserName, string sSessionGuid, string sPartitionName);

    }
}
