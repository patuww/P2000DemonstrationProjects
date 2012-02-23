using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data
{
    public class AccessGroupAccessPointResponse
    {

//PanelGuid GUID of the panel which contains this access point
//PanelName Name of the panel which contains this access point
//PartitionGuid GUID of the partition which owns this access point
//PartitionName Name of the partition which owns this access point
//Public 0 = non-public, 1 = public

            // Access Group GUID
        public Guid ItemGuid { get; set; }

        // Access Group Name
        public string ItemName { get; set; }

        // Guid of the partition which owns this access group
        public Guid PartitionGuid { get; set; }

        //Name of the partition which owns this access group
        public string PartitionName { get; set; }

        // 0 = non-public, 1 = public
        public bool Public { get; set; }
    }
}
