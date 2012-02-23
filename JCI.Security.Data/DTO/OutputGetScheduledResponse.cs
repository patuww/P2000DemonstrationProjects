using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class OutputGetScheduledResponse
    {
        /// <summary>
        /// Gets or sets the item GUID.
        /// </summary>
        /// <value>
        /// The item GUID.
        /// </value>
        public Guid ItemGuid { get; set; }
        /// <summary>
        /// Gets or sets the  Name of input
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        public string ItemName { get; set; }
        /// <summary>
        ///  Action to be performed
        /// </summary>
        public string ScheduledAction { get; set; }
        /// <summary>
        ///  ID of action scheduled
        /// </summary>
        public int ScheduledID { get; set; }
        /// <summary>
        ///  Override time value (only for door override action)
        /// </summary>
        public int ScheduledParam { get; set; }
        /// <summary>
        ///  Time of action
        /// </summary>
        public DateTime ScheduledTime { get; set; }
    }
}
