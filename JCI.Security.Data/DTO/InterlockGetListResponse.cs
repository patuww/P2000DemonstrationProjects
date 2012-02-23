using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class InterlockGetListResponse
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

    }
}
