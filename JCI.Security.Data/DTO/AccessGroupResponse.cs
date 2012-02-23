using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class AccessGroupResponse
    {
        // Access Group GUID
        public Guid ItemGuid { get; set; }

        // Access Group Name
        public string ItemName { get; set; }

        // GUID of the panel which contains this access point
        public Guid PanelGuid { get; set; }

        // Name of the panel which contains this access point
        public string PanelName { get; set; }

        // Guid of the partition which owns this access group
        public Guid PartitionGuid { get; set; }

        // Name of the partition which owns this access group
        public string PartitionName { get; set; }

        // Integer value representing the current security level for this item
        // (-1 = unknown)
        public int SecurityLevel { get; set; }

        // Depending on the security level and the configured security level
        // ranges one of the following values: “Green," "Blue," "Yellow,"
        // "Orange," "Red," "Unknown"
        public string SecurityLevelText { get; set; }

        // Integer value of status
        // Status Value         Status Name
        // 0                    Up / Locked
        // 1                    Down
        // 2                    Unknown
        // 5                    Unlocked
        // 7                    Override
        public int ItemStatus { get; set; }

        // Text value of status
        public string ItemStatusText { get; set; }

        //String representation of UTC
        public DateTime ItemStatusTimeStamp { get; set; }

        // 0 = non-public, 1 = public
        public bool Public { get; set; }
    }
}
