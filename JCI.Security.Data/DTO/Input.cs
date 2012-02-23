using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class Input
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
        /// Gets or sets the Guid of panel which contains this input
        /// </summary>
        /// <value>
        /// The panel GUID.
        /// </value>
        public Guid PanelGuid { get; set; }
        /// <summary>
        /// Gets or sets the Name of panel which contains this input
        /// </summary>
        /// <value>
        /// The name of the panel.
        /// </value>
        public string PanelName { get; set; }
        /// <summary>
        /// Gets or sets the Guid of partition which owns this input
        /// </summary>
        /// <value>
        /// The partition GUID.
        /// </value>
        public Guid PartitionGuid { get; set; }
        /// <summary>
        /// Gets or sets the Name of partition which owns this input
        /// </summary>
        /// <value>
        /// The name of the partition.
        /// </value>
        public string PartitionName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="InputGetListResponse"/> is public.  0 = non-public, 1 = public
        /// </summary>
        /// <value>
        ///   <c>true</c> if public; otherwise, <c>false</c>.
        /// </value>
        public bool Public { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [supports suppression].  1 = suppression supported, 0 = suppression not supported
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports suppression]; otherwise, <c>false</c>.
        /// </value>
        public bool SupportsSuppression { get; set; }

        /// <summary>
        /// Gets or sets the  Guid of terminal which contains this input (blank if input contained by panel)
        /// </summary>
        /// <value>
        /// The terminal GUID.
        /// </value>
        public Guid TerminalGuid { get; set; }

        /// <summary>
        /// Gets or sets the Name of terminal which contains this input (blank if input contained by panel).
        /// </summary>
        /// <value>
        /// The name of the terminal.
        /// </value>
        public string TerminalName { get; set; }

    }
}
