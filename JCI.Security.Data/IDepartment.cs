using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IDepartment
    {
        DepartmentResponse DepartmentGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        DepartmentResponse DepartmentGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
    }
}
