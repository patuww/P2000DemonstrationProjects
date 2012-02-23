using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class EntityGetUDFResponse
    {
        /// <summary>
        /// Gets or sets the item GUID.
        /// </summary>
        /// <value>
        /// The item GUID.
        /// </value>
        public Guid ItemGuid { get; set; }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the item value.
        /// </summary>
        /// <value>
        /// The item value.
        /// </value>
        public string ItemValue { get; set; }
    }
}
