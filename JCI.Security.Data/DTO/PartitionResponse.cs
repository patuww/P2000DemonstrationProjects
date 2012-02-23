using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class PartitionResponse
    {
        /// <summary>
        /// Gets or sets the partition GUID.
        /// </summary>
        /// <value>
        /// The partition GUID.
        /// </value>
        public Guid PartitionGuid { get; set; }
        /// <summary>
        /// Gets or sets the name of the partition.
        /// </summary>
        /// <value>
        /// The name of the partition.
        /// </value>
        public string PartitionName { get; set; }

    }
}
