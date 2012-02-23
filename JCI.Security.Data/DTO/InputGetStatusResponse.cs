using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class InputGetStatusResponse
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
        /// Gets or sets the  Integer value of status
        /// </summary>
        /// <value>
        /// The item status.
        /// </value>
        public int ItemStatus { get; set; }
        /// <summary>
        /// Gets or sets the text value of status.
        /// </summary>
        /// <value>
        /// The item status text.
        /// </value>
        public string ItemStatusText { get; set; }
        /// <summary>
        /// Gets or sets the String representation of UTC Time Stamp of last reported status change (W3C format)
        /// </summary>
        /// <value>
        /// The item status time stamp.
        /// </value>
        public DateTime ItemStatusTimeStamp { get; set; }
    }
}
