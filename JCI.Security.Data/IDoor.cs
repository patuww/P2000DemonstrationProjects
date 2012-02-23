using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    interface IDoor
    {
        bool DoorDeleteScheduled(string sUserName, string sSessionGuid, int iScheduledID);
        /// <summary>
        /// Doors the get alarm inputs.
        /// 
        /// Notes:
        ///    1.If the alarm input is turned off in the P2000 configuration, all of the input parameters, except AlarmName and InputNumber will be empty for that input.
        ///    2.This function is not supported for CK722 controller.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sDoorGuid">The s door GUID.</param>
        /// <returns></returns>
        DoorResponse DoorGetAlarmInputs(string sUserName, string sSessionGuid, string sDoorGuid);
        /// <summary>
        /// Doors the name of the get alarm inputs by.
        /// Notes:
        /// 1.If the alarm input is turned off in the P2000 configuration, all of the input parameters, except AlarmName and InputNumber will be empty for that input.
        /// 2.This function is not supported for CK722 controller.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sDoorName">Name of the s door.</param>
        /// <param name="sPartitionName">Name of the s partition.</param>
        /// <returns></returns>
        DoorResponse DoorGetAlarmInputsByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);

        /// <summary>
        /// Get the Door List
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sPartitionGuid">The s partition GUID.</param>
        /// <returns></returns>
        DoorResponse DoorGetList(string sUserName, string sSessionGuid, string sPartitionGuid);

        /// <summary>
        /// Doors the name of the get list by.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sPartitionName">Name of the s partition.</param>
        /// <returns></returns>
        DoorResponse DoorGetListByName(string sUserName, string sSessionGuid, string sPartitionName);

        /// <summary>
        /// Doors the get scheduled.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sDoorGuid">The s door GUID.</param>
        /// <returns></returns>
        DoorScheduledResponse DoorGetScheduled(string sUserName, string sSessionGuid, string sDoorGuid);

        /// <summary>
        /// Doors the name of the get scheduled by.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <param name="sDoorName">Name of the s door.</param>
        /// <param name="sPartitionName">Name of the s partition.</param>
        /// <returns></returns>
        DoorScheduledResponse DoorGetScheduledByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);

        DoorScheduledResponse DoorGetAllScheduled(string sUserName, string sSessionGuid, string sPartitionGuid);
        DoorScheduledResponse DoorGetAllScheduledByName(string sUserName, string sSessionGuid, string sPartitionName);
        string DoorGetSecurityLevel(string sUserName, string sSessionGuid, string sDoorGuid);
        string DoorPointGetSecurityLevelByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        DoorResponse DoorGetStatus(string sUserName, string sSessionGuid, string sDoorGuid);
        DoorResponse DoorGetStatusByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        bool DoorLock(string sUserName, string sSessionGuid, string sDoorGuid);
        bool DoorLockScheduled(string sUserName, string sSessionGuid, string sDoorGuid, DateTime tScheduledTime);
        bool DoorLockByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        bool DoorLockByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, DateTime tScheduledTime);
        bool DoorSetOverrideTimezone(string sUserName, string sSessionGuid, string sDoorGuid, string sTimezoneGuid);
        bool DoorSetOverrideTimezoneByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, string sTimezoneName);
        bool DoorSetOverrideTimezoneEnable(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iEnable);
        bool DoorSetOverrideTimezoneEnableByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iEnable);
        bool DoorSetOverrideTimezoneScheduled(string sUserName, string sSessionGuid, string sDoorGuid, string sTimezoneGuid, DateTime tScheduledTime);
        bool DoorSetOverrideTimezoneByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, string sTimezoneGuid, DateTime tScheduledTime);
        bool DoorSetOverrideTimezoneEnableScheduled(string sUserName, string sSessionGuid, string sDoorGuid, int iEnable, DateTime tScheduledTime);
        bool DoorSetOverrideTimezoneEnableByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iEnable, DateTime tScheduledTime);
        bool DoorSetSecurityLevel(string sUserName, string sSessionGuid, string sDoorGuid, int iSecurityLevel);
        bool DoorSetSecurityLevelByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iSecurityLevel);
        bool DoorSetSecurityLevelColor(string sUserName, string sSessionGuid, string sDoorGuid, int iSecurityLevelColor);
        bool DoorSetSecurityLevelColorByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, string sSecurityLevelColor);
        bool DoorTimedUnlock(string sUserName, string sSessionGuid, string sDoorGuid, int iTime);
        bool DoorTimedUnlockScheduled(string sUserName, string sSessionGuid, string sDoorGuid, int iTime, DateTime tScheduledTime);
        bool DoorTimedUnlockByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iTime);
        bool DoorTimedUnlockByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iTime, DateTime tScheduledTime);
        bool DoorUnlock(string sUserName, string sSessionGuid, string sDoorGuid);
        bool DoorUnlockScheduled(string sUserName, string sSessionGuid, string sDoorGuid, DateTime tScheduledTime);
        bool DoorUnlockByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        bool DoorUnlockByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, DateTime tScheduledTime);
        bool DoorUnlockAll(string sUserName, string sSessionGuid, int iUnlock, string sPartitionGuid);
        bool DoorUnlockAllByName(string sUserName, string sSessionGuid, int iUnlock, string sPartitionName);
        bool DoorUnlockAllScheduled(string sUserName, string sSessionGuid, int iUnlock, string sPartitionGuid, DateTime tScheduledTime);
        bool DoorUnlockAllScheduledByName(string sUserName, string sSessionGuid, int iUnlock, string sPartitionName, DateTime tScheduledTime);


    }

    enum ThresholdStatus
    {
        Up_Locked = 0,
        Down = 1,
        Unknown = 2,
        Unlocked = 3,
        Disabled = 4,
        Override = 7,
        Unlocked_Open = 8,
        Unlocked_Closed = 9,
        Locked_Open = 10,
        Locked_Closed = 11
    }
}
