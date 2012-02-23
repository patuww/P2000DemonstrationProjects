using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookComputing.XmlRpc;


namespace JCI.Security.Data.DTO
{

    //1 = completed, 2 = responding, 3 = acknowledged, 4 = pending 
    public enum AlarmState
    {
        NotFound = 0,
        Completed = 1,
        Responding = 2,
        Acknowledged = 3,
        Pending = 4
    }

    public enum AlarmType
    {
        GENERIC = 1,
        PANEL_INPUT_POINT = 2,
        AREA = 3,
        GUARDTOUR = 4,
        MUSTER_RUNNING = 5,
        MUSTER_ZONE_STATUS = 6,
        MUSTER_WHEN_DISABLED = 7,
        MUSTER_ABORTED = 8,
        LOOP_TAMPER = 9,
        EVENT = 10,
        G3_EVENT = 11,
        AV_MOTION = 12,
        AV_BEHAVIOR = 13,
        AV_VIDEOLOSS = 14,
        AV_DRYCONTACT = 15,
        AV_SYSTEM = 16,
        INTRUSION_ZONE = 17
    }


}
