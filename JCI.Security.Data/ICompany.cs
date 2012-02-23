using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data
{
    interface ICompany
    {
        bool CompanyGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        bool CompanyGetListByName(string sUserName, string sSessionGuid, string sPartitionName);

    }
}
