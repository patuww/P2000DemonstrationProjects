using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class CompanyResponse
    {
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
