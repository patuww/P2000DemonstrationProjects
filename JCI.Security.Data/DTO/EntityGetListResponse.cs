using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class EntityGetListResponse
    {
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

    }
}
