using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class EventResponse
    {
        

        /// <summary>
        /// Guid of partition which owns this entity
        /// </summary>
        public Guid PartitionGuid { get; set; }
        /// <summary>
        /// Name of the partition to which the entity belongs
        /// </summary>
        public string PartitionName { get; set; }
        /// <summary>
        /// 0 = non-public, 1 = public
        /// </summary>
        public bool Public { get; set; }

        /// <summary>
        /// Gets or sets the item GUID.
        /// </summary>
        /// <value>
        /// The item GUID.
        /// </value>
        public Guid ItemGuid { get; set; }


        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the scheduled action.
        /// </summary>
        /// <value>
        /// The scheduled action.
        /// </value>
        public string ScheduledAction { get; set; }

        /// <summary>
        /// Gets or sets the scheduled ID.
        /// </summary>
        /// <value>
        /// The scheduled ID.
        /// </value>
        public int ScheduledID { get; set; }


        /// <summary>
        /// Gets or sets the scheduled time.
        /// </summary>
        /// <value>
        /// The scheduled time.
        /// </value>
        public DateTime ScheduledTime { get; set; }

    }
}
