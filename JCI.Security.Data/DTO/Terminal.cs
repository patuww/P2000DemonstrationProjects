using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class Terminal
    {
        /// <summary>
        /// Gets or sets a value indicating whether 0 = not an input terminal, 1 = input terminal
        /// </summary>
        /// <value>
        ///   <c>true</c> if [input terminal]; otherwise, <c>false</c>.
        /// </value>
        public bool InputTerminal { get; set; }
        /// <summary>
        /// Gets or sets the  Guid of the terminal
        /// </summary>
        /// <value>
        /// The item GUID.
        /// </value>
        public Guid ItemGuid { get; set; }
        /// <summary>
        /// Gets or sets the  Name of the terminal
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        public string ItemName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether  0 = not an output terminal, 1 = output terminal.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [output terminal]; otherwise, <c>false</c>.
        /// </value>
        public bool OutputTerminal { get; set; }
        /// <summary>
        /// Gets or sets the Guid of panel
        /// </summary>
        /// <value>
        /// The panel GUID.
        /// </value>
        public Guid PanelGuid { get; set; }
        /// <summary>
        /// Gets or sets the Name of the panel
        /// </summary>
        /// <value>
        /// The name of the panel.
        /// </value>
        public string PanelName { get; set; }
        /// <summary>
        /// Gets or sets the  Guid of the partition
        /// </summary>
        /// <value>
        /// The partition GUID.
        /// </value>
        public Guid PartitionGuid { get; set; }
        /// <summary>
        /// Gets or sets the Name of the partition
        /// </summary>
        /// <value>
        /// The name of the partition.
        /// </value>
        public string PartitionName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Terminal"/> is public.   0 = non-public, 1 = public
        /// </summary>
        /// <value>
        ///   <c>true</c> if public; otherwise, <c>false</c>.
        /// </value>
        public bool Public { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [reader terminal].   0 = not a reader terminal, 1 = reader terminal
        /// </summary>
        /// <value>
        ///   <c>true</c> if [reader terminal]; otherwise, <c>false</c>.
        /// </value>
        public bool ReaderTerminal { get; set; }

    }
}
