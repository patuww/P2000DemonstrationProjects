using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class IdentifierGetInfoResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IdentifierGetInfoResponse"/> is disabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if disabled; otherwise, <c>false</c>.
        /// </value>
        public bool Disabled {get;set;}
        /// <summary>
        /// Entity First name (not supported for Assets)
        /// </summary>
        public string EntityFirstName { get; set; }
        /// <summary>
        /// Entity Middle Name (not supported for Assets)
        /// </summary>
        public string EntityMiddleName { get; set; }
        /// <summary>
        /// Guid of Entity
        /// </summary>
        public Guid EntityGuid { get; set; }
        /// <summary>
        /// Entity Name
        /// </summary>
        public string EntityLastName { get; set; }
        /// <summary>
        /// Gets or sets the event privlege.
        /// </summary>
        /// <value>
        /// The event privlege.
        /// </value>
        public string EventPrivlege { get; set; }
        /// <summary>
        /// Expiration date/time of entity (UTC date/time; Jan-01-1900 00:00 = not specified)
        /// </summary>
        public DateTime ExpireTimeStamp { get; set; }
        /// <summary>
        /// Gets or sets the issue level.
        /// </summary>
        /// <value>
        /// The issue level.
        /// </value>
        public string IssueLevel { get; set; }
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
        /// Gets or sets the purpose.
        /// </summary>
        /// <value>
        /// The purpose.
        /// </value>
        public string Purpose { get; set; }
        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public string Reason{get;set;}
        /// <summary>
        /// Gets or sets the start timestamp.
        /// </summary>
        /// <value>
        /// The start timestamp.
        /// </value>
        public DateTime StartTimestamp { get; set; }
        /// <summary>
        /// Trace Flag
        /// </summary>
        public bool Trace { get; set; }
    }
}
