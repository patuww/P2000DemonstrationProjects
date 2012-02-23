using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    public interface IPartition
    {
        List<PartitionResponse> PartitionGetList(string sUserName, string sSessionGuid);
        List<PartitionResponse> RequestQueueAdd(string sUserName, string sSessionGuid, string sRequestXml);
        
        
    }
}
