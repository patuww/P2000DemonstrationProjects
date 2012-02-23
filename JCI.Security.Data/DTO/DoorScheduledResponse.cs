using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class DoorScheduledResponse
    {

        // Name of Alarm (Duress, Forced Door, Propped Door, Pin Code
        //Retry, or Soft In-X-It)
        //public string AlarmName { get; set; }

        //Index number of the input point
        //public uint InputNumber { get; set; }

        /// Guid of alarm                 
        public Guid ItemGuid { get; set; }

        /// Alarm Name                          
        public string ItemName { get; set; }

        public string ScheduledAction { get; set; }

        public int ScheduledID { get; set; }

        public int ScheduledParam { get; set; }

        public DateTime ScheduledTime { get; set; }

        /// Guid of panel 
        //public Guid PanelGuid { get; set; }

        ///// <summary>
        ///// Name of Panel
        ///// </summary>
        ///// <value>
        ///// The name of the partition.
        ///// </value>
        //public string PanelName { get; set; }

        ///// Guid of partition which owns this alarm
        //public Guid PartitionGuid { get; set; }

        ///// <summary>
        ///// Name of partition which owns this alarm
        ///// </summary>
        ///// <value>
        ///// The name of the partition.
        ///// </value>
        //public string PartitionName { get; set; }

        ///// 0 = non-public, 1 = public                           
        //public bool Public { get; set; }
    }
}
