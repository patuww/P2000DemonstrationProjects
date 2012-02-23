using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class PanelGetComponentsResponse
    {
        public List<Terminal> TerminalList{get;set;}
        public List<Input> InputList { get; set; }
        public List<Output> OutputList { get; set; }
    }
}
