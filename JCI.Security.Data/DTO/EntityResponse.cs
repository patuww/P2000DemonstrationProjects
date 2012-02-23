using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    /// <summary>
    /// From 4.1 spec - Fields with ‘*’ are optional; these fields are returned if they contain data.
    /// </summary>
    public class EntityResponse
    {
        /// <summary>
        /// Company
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Department
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// Division
        /// </summary>
        public string DivisionName { get; set; }
        /// <summary>
        /// Entity's email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Entity address line 1
        /// </summary>
        public string EntityAddress1 { get; set; }
        /// <summary>
        /// Entity address line 2
        /// </summary>
        public string EntityAddress2 { get; set; }
        /// <summary>
        /// Entity address line 3
        /// </summary>
        public string EntityAddress3 { get; set; }
        /// <summary>
        /// Entity address line 4
        /// </summary>
        public string EntityAddress4 { get; set; }
        /// <summary>
        /// Entity address line 5
        /// </summary>
        public string EntityAddress5 { get; set; }
        /// <summary>
        /// Entity address line 6
        /// </summary>
        public string EntityAddress6 { get; set; }
        /// <summary>
        /// Name of Entity Category
        /// </summary>
        public string EntityCategory { get; set; }
        /// <summary>
        /// Entity First name (not supported for Assets)
        /// </summary>
        public string EntityFirstName { get; set; }
        /// <summary>
        /// Entity Middle Name (not supported for Assets)
        /// </summary>
        public string EntityMiddleName { get; set; }
        /// <summary>
        /// Entity phone
        /// </summary>
        public string EntityPhone { get; set; }
        /// <summary>
        /// Name of Entity Type
        /// </summary>
        public string EntityType { get; set; }
        /// <summary>
        /// Team Name
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Employee ID
        /// </summary>
        public string EmployeeID { get; set; }
        /// <summary>
        /// Entity Description (Assets Only)
        /// </summary>
        public string EntityDescription { get; set; }
        /// <summary>
        /// Guid of Entity
        /// </summary>
        public Guid EntityGuid { get; set; }
        /// <summary>
        /// Entity Name
        /// </summary>
        public string EntityLastName { get; set; }
        /// <summary>
        /// Entity Type
        /// </summary>
        public Guid EntityTypeGuid { get; set; }
        /// <summary>
        /// Expiration date/time of entity (UTC date/time; Jan-01-1900 00:00 = not specified)
        /// </summary>
        public DateTime ExpireTimeStamp { get; set; }
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
        /// Start date/time of entity (UTC date/time; Jan-01-1900 00:00 = not specified)
        /// </summary>
        public DateTime StartTimeStamp { get; set; }

    }
}
