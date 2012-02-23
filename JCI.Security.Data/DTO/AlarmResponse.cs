using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;


namespace JCI.Security.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class AlarmResponse
    {
        /// 1 = alarm requires acknowledge before completion
        public bool AlarmAckRequired { get; set; }

        /// Category of alarm
        public string AlarmCategory { get; set; }

        /// State of item required to complete alarm
        public string AlarmCompletionItemState { get; set; }

        /// Escalation Level of alarm
        public int AlarmEscalationLevel { get; set; }

        /// Instruction text for alarm
        public string AlarmInstruction { get; set; }

        /// State of item generating alarm
        public string AlarmItemState { get; set; }

        /// Time that item went to current state
        public DateTime AlarmItemStateTime { get; set; }

        /// Priority of alarm
        public int AlarmPriority { get; set; }

        /// 1 = alarm requires response before completion
        public bool AlarmResponseRequired { get; set; }

        /// 1 = completed, 2 = responding, 3 = acknowledged, 4 = pending 
        public AlarmState AlarmState { get; set; }

        /// Time that alarm went to current state   
        public DateTime AlarmStateTime { get; set; }

        /// Type of alarm (see below)                  
        public AlarmType AlarmType { get; set; }

        /// Type Guid of alarm               
        public Guid AlarmTypeGuid { get; set; }

        /// Type ID of alarm 
        public int AlarmTypeID { get; set; }

        /// Guid of alarm                 
        public Guid ItemGuid { get; set; }

        /// Alarm Name                          
        public string ItemName { get; set; }

        /// Guid of partition which owns this alarm
        public Guid PartitionGuid { get; set; }

        /// name of partition which owns this alarm                          
        public string PartitionName { get; set; }

        /// 0 = non-public, 1 = public                           
        public bool Public { get; set; }

    }
}
