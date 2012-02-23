using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data
{
    /// <summary>
    /// 
    /// </summary>
    interface IP2000
    {
        // Access Group Methods
        //bool AccessGroupAdd(string sUserName, string sSessionGuid, string sAccessGroupName, string sAccessGroupGuid, string sPartitionGuid, int iPublic, string[] sTerminalGuids, string[] sTerminalGroupGuids);
        //bool AccessGroupAddByName(string sUserName, string sSessionGuid, string sAccessGroupName, string sAccessGroupGuid, string sPartitionName, int iPublic, string[] sTerminals, string[] sTerminalGroups);
        //bool AccessGroupGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool AccessGroupGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool AccessGroupModify(string sUserName, string sSessionGuid, string sAccessGroupGuid, string[] sTerminalGuids, string[] sTerminalGroupGuids);
        //bool AccessGroupModifyByName(string sUserName, string sSessionGuid, string sAccessGroupName, string sPartitionName, string[] sTerminalNames, string[] sTerminalGroupNames);
        //bool AccessGroupDelete(string sUserName, string sSessionGuid, string sAccessGroupGuid);
        //bool AccessGroupDeleteByName(string sUserName, string sSessionGuid, string sAccessGroupName, string sPartitionName);
        //bool AccessPointEnable(string sUserName, string sSessionGuid, string sAccessPointGuid, int iEnable);
        //bool AccessPointGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool AccessPointGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool AccessPointGetSecurityLevel(string sUserName, string sSessionGuid, string sAccessPointGuid);
        //bool AccessPointGetSecurityLevelByName (string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName);
        //bool AccessPointGetStatus (string sUserName, string sSessionGuid, string sAccessPointGuid);
        //bool AccessPointGetStatusByName (string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName);
        //bool AccessPointSetSecurityLevel(string sUserName, string sSessionGuid, string sAccessPointGuid, int iSecurityLevel);
        //bool AccessPointSetSecurityLevelByName (string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName, int iSecurityLevel);
        //bool AccessPointSetSecurityLevelColor(string sUserName, string sSessionGuid, string sAccessPointGuid, int iSecurityColor);
        //bool AccessPointSetSecurityLevelColorByName (string sUserName, string sSessionGuid, string sAccessPointName, string sPartitionName, string sSecurityLevelColor);
        //bool AlarmGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool AlarmGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool AlarmGetState(string sUserName, string sSessionGuid, string sAlarmGuid);
        //bool AlarmUpdate(string sUserName, string sSessionGuid, string sAlarmGuid, int iAlarmState, string sResponse);
        //bool AlarmAction (string sUserName, string sSessionGuid, string sAlarmConditionSequenceGuid, int iNewAlarmState, string sResponse);
        //bool CompanyGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool CompanyGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool CounterGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool CounterGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool CounterGetValue(string sUserName, string sSessionGuid, string sCounterGuid);
        //bool CounterGetValueByName(string sUserName, string sSessionGuid, string sCounterName, string sPartitionName);
        //bool CounterSetValue(string sUserName, string sSessionGuid, string sCounterGuid, int iValue);
        //bool CounterSetValueByName(string sUserName, string sSessionGuid, string sCounterName, string sPartitionName, int iValue);
        //bool CounterChangeValueByName(string sUserName, string sSessionGuid, string sCounterName, string sPartitionName, int iValueBy);
        //bool DepartmentGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool DepartmentGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool DivisionGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool DivisionGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool DoorDeleteScheduled(string sUserName, string sSessionGuid, int iScheduledID);
        //bool DoorGetAlarmInputs(string sUserName, string sSessionGuid, string sDoorGuid);
        //bool DoorGetAlarmInputsByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        //bool DoorGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool DoorGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool DoorGetScheduled(string sUserName, string sSessionGuid, string sDoorGuid);
        //bool DoorGetScheduledByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        //bool DoorGetAllScheduled(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool DoorGetAllScheduledByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool DoorGetSecurityLevel(string sUserName, string sSessionGuid, string sDoorGuid);
        //bool DoorPointGetSecurityLevelByName (string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        //bool DoorGetStatus(string sUserName, string sSessionGuid, string sDoorGuid);
        //bool DoorGetStatusByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        //bool DoorLock(string sUserName, string sSessionGuid, string sDoorGuid);
        //bool DoorLockScheduled(string sUserName, string sSessionGuid, string sDoorGuid, DateTime tScheduledTime);
        //bool DoorLockByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        //bool DoorLockByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, DateTime tScheduledTime);
        //bool DoorSetOverrideTimezone(string sUserName, string sSessionGuid, string sDoorGuid, string sTimezoneGuid);
        //bool DoorSetOverrideTimezoneByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, string sTimezoneName);
        //bool DoorSetOverrideTimezoneEnable(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iEnable);
        //bool DoorSetOverrideTimezoneEnableByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iEnable);
        //bool DoorSetOverrideTimezoneScheduled(string sUserName, string sSessionGuid, string sDoorGuid, string sTimezoneGuid, DateTime tScheduledTime);
        //bool DoorSetOverrideTimezoneByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, string sTimezoneGuid, DateTime tScheduledTime);
        //bool DoorSetOverrideTimezoneEnableScheduled(string sUserName, string sSessionGuid, string sDoorGuid, int iEnable, DateTime tScheduledTime);
        //bool DoorSetOverrideTimezoneEnableByNameScheduled (string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iEnable, DateTime tScheduledTime);
        //bool DoorSetSecurityLevel(string sUserName, string sSessionGuid, string sDoorGuid, int iSecurityLevel);
        //bool DoorSetSecurityLevelByName (string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iSecurityLevel);
        //bool DoorSetSecurityLevelColor(string sUserName, string sSessionGuid, string sDoorGuid, int iSecurityLevelColor);
        //bool DoorSetSecurityLevelColorByName (string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, string sSecurityLevelColor);
        //bool DoorTimedUnlock(string sUserName, string sSessionGuid, string sDoorGuid, int iTime);
        //bool DoorTimedUnlockScheduled(string sUserName, string sSessionGuid, string sDoorGuid, int iTime, DateTime tScheduledTime);
        //bool DoorTimedUnlockByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iTime);
        //bool DoorTimedUnlockByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, int iTime, DateTime tScheduledTime);
        //bool DoorUnlock(string sUserName, string sSessionGuid, string sDoorGuid);
        //bool DoorUnlockScheduled(string sUserName, string sSessionGuid, string sDoorGuid, DateTime tScheduledTime);
        //bool DoorUnlockByName(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName);
        //bool DoorUnlockByNameScheduled(string sUserName, string sSessionGuid, string sDoorName, string sPartitionName, DateTime tScheduledTime);
        //bool DoorUnlockAll(string sUserName, string sSessionGuid, int iUnlock, string sPartitionGuid);
        //bool DoorUnlockAllByName(string sUserName, string sSessionGuid, int iUnlock, string sPartitionName);
        //bool DoorUnlockAllScheduled(string sUserName, string sSessionGuid, int iUnlock, string sPartitionGuid, DateTime tScheduledTime);
        //bool DoorUnlockAllScheduledByName(string sUserName, string sSessionGuid, int iUnlock, string sPartitionName, DateTime tScheduledTime);
        //bool EntityGetInfo(string sUserName, string sSessionGuid, string sEntityGuid);
        //bool EntityGetInfoByID(string sUserName, string sSessionGuid, string sEmployeeID);
        //bool EntityGetIdentifierList(string sUserName, string sSessionGuid, string sEntityGuid, string sPartitionGuid);
        //bool EntityGetList(string sUserName, string sSessionGuid, string sPartitionGuid, string sFirstNameFilter, string sLastNameFilter, int iMaxCount);
        //bool EntityGetListByName(string sUserName, string sSessionGuid, string sPartitionName, string sFirstNameFilter, string sLastNameFilter, int iMaxCount);
        //bool EntityGetListCount(string sUserName, string sSessionGuid, string sPartitionGuid, string sFirstNameFilter, string sLastNameFilter);
        //bool EntityGetListCountByName(string sUserName, string sSessionGuid, string sPartitionName, string sFirstNameFilter, string sLastNameFilter);
        //bool EntityGetAllUdf(string sUserName, string sSessionGuid, string sEntityGuid);
        //bool EntityGetUdf(string sUserName, string sSessionGuid, string sEntityGuid, string sUdfGuid);
        //bool EntitySetUdf(string sUserName, string sSessionGuid, string sEntityGuid, string sUdfGuid, string Value);
        //bool EventDeleteScheduled(string sUserName, string sSessionGuid, int iScheduledID);
        //bool EventTrigger(string sUserName, string sSessionGuid, string sEventGuid);
        //bool EventTriggerScheduled(string sUserName, string sSessionGuid, string sEventGuid, DateTime tScheduledTime);
        //bool EventTriggerByName(string sUserName, string sSessionGuid, string sEventName, string sPartitionName);
        //bool EventTriggerByNameScheduled(string sUserName, string sSessionGuid, string sEventName, string sPartitionName, DateTime tScheduledTime);
        //bool EventGetAllScheduled(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool EventGetAllScheduledByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool IdentifierGetInfo(string sUserName, string sSessionGuid, string sIdentifierNumber, int iFacilityCode);
        //bool IdentifierGetPurpose(string sUserName, string sSessionGuid, string sIdentifierNumber, int iFacilityCode);
        //bool InputDisable(string sUserName, string sSessionGuid, string sInputGuid, int iDisable);
        //bool InputDisableByName(string sUserName, string sSessionGuid, string sInputName, string sPartitionName, int iDisable);
        //bool InputGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool InputGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool InputGetStatus(string sUserName, string sSessionGuid, string sInputGuid);
        //bool InputGetStatusByName(string sUserName, string sSessionGuid, string sInputName, string sPartitionName);
        //bool InputSuppress(string sUserName, string sSessionGuid, string sInputGuid, int iDuration);
        //bool InputSuppressByName(string sUserName, string sSessionGuid, string sInputName, string sPartition, int iDuration);
        //bool InterlockGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool InterlockGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool InterlockGetStatus (string sUserName, string sSessionGuid, string sInterlockGuid);
        //bool InterlockAccessPointGetStatusByName (string sUserName, string sSessionGuid, string sInterlockName, string sPartitionName);
        // MultiCommand Methods
        //bool MultiCommandGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool MultiCommandGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool MultiCommandGetStatus (string sUserName, string sSessionGuid, string sMultiCommandGuid);
        //bool MultiCommandGetStatusByName (string sUserName, string sSessionGuid, string sMultiCommandName, string sPartitionName);
        //bool MultiCommandSetStatus (string sUserName, string sSessionGuid, string sMultiCommandGuid, int iState);
        //bool MultiCommandSetStatusByName(string sUserName, string sSessionGuid, string sMultiCommandName, string sPartitionName, int iState);
        //Output Methods
        //bool OutputGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool OutputGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool OutputSet(string sUserName, string sSessionGuid, string sOutputGuid, int iAction);
        //bool OutputSetByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction);
        //bool OutputSetByNameScheduled(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction, DateTime tScheduledTime);
        //bool OutputSetForDuration(string sUserName, string sSessionGuid, string sOutputGuid, int iAction, int iDuration);
        //bool OutputSetForDurationByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction, int iDuration);
        //bool OutputSetForDurationScheduled(string sUserName, string sSessionGuid, string sOutputGuid, int iAction, int iDuration, DateTime tScheduledTime);
        //bool OutputSetForDurationByNameScheduled(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName, int iAction, int iDuration, DateTime tScheduledTime);
        //bool OutputSetScheduled(string sUserName, string sSessionGuid, string sOutputGuid, int iAction, DateTime tScheduledTime);
        //bool OutputGetScheduled(string sUserName, string sSessionGuid, string sOutputGuid);
        //bool OutputGetScheduledByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName);
        //bool OutputDeleteScheduled(string sUserName, string sSessionGuid, int iScheduledID);
        //bool OutputGetStatus(string sUserName, string sSessionGuid, string sOutputGuid);
        //bool OutputGetStatusByName(string sUserName, string sSessionGuid, string sOutputName, string sPartitionName);
        //P2000 Methods
        //bool P2000GetSystemInfo(string sUserName, string sSessionGuid);
        //bool P2000GetVersion(string sUserName, string sSessionGuid);
        //bool P2000IsSessionValid(string sUserName, string sSession);
        //bool P2000Login(string sUserName, string sPassword);
        //bool P2000Login(string sUserName, string sPassword , int iPasswordMode);
        //bool P2000LoginHashed(string sUserName, string sPassword);
        //bool P2000Logout(string sUserName, string sSession);
        // Panel Methods
        //bool PanelGetComponents(string sUserName, string sSessionGuid, string sPanelGuid, string sPartitionGuid);
        //bool PanelGetComponentsByName(string sUserName, string sSessionGuid, string sPanelName, string sPartitionName);
        //bool PanelGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool PanelGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool PanelGetTimezones(string sUserName, string sSessionGuid, string sPanelGuid);
        //bool PanelGetTimezonesByName(string sUserName, string sSessionGuid, string sPanelName, string sPartitionName);
        //bool PanelModifyTimezone(string sUserName, string sSessionGuid, string sPanelGuid, int iTimezonePos, string sTimezoneGuid, string sOutputGroupGuid);
        //bool PanelModifyTimezoneByName(string sUserName, string sSessionGuid, string sPanelName, string sPartitionName, int iTimezonePos, string sTimezoneName, string sOutputGroupName);
        // Partition Methods
        //bool PartitionGetList(string sUserName, string sSessionGuid);
        //bool RequestQueueAdd(string sUserName, string sSessionGuid, string sRequestXml);
        //bool TeamGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool TeamGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool TerminalGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool TerminalGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        // Timezone Methods
        //bool TimezoneAdd(string sUserName, string sSessionGuid, string sTimezoneName, string sTimezoneGuid, string sPartitionGuid, int iPublic, int iAddToAllPanels, int iInitialStates, DateTime[] tTimes);
        //bool TimezoneAddByName(string sUserName, string sSessionGuid, string sTimezoneName, string sTimezoneGuid, string sPartitionName, int iPublic, int iAddToAllPanels, int iInitialStates, DateTime[] tTimes);
        //bool TimezoneIsActive(string sUserName, string sSessionGuid, string sTimezoneGuid);
        //bool TimezoneIsActiveByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName);
        //bool TimezoneGetInfo(string sUserName, string sSessionGuid, string sTimezoneGuid);
        //bool TimezoneGetInfoByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName);
        //bool TimezoneGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        //bool TimezoneGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        //bool TimezoneModify(string sUserName, string sSessionGuid, string sTimezoneGuid, int iInitialState, DateTime[] tTimes);
        //bool TimezoneModifyByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName, int iInitialState, DateTime[] tTimes);
        //bool TimezoneDelete(string sUserName, string sSessionGuid, string sTimezoneGuid);
        //bool TimezoneDeleteByName(string sUserName, string sSessionGuid, string sTimezoneName, string sPartitionName);
        // UDF Methods
        bool UdfGetList(string sUserName, string sSessionGuid, string sPartitionGuid);
        bool UdfGetListByName(string sUserName, string sSessionGuid, string sPartitionName);
        bool XActionSave(string sUserName, string sSessionGuid, int iHistMainType, int iHistSubType, string sPanelName, string sTerminalName, string sPointName, string sIdentifierNumber, string sFirstName, string sLastName, int iTimedOverride, int iIssueLevel, int iFacilityCode, string sEventName, DateTime tTime, string sPartition, int iPublic, string sDescription, string sCompany, string sDivision, string sDepartment, string sTeam);
        // P2000 ECCC Method List
        // The P2000 Enterprise Command and Control Center functionality utilizes a set of XML RPC functions. These XML RPC functions are listed in this section.
        // The main difference between these functions and those listed as “Traditional Method” is that the P2000 ECCC functions leverage the data driven components of the P2000 Version 4.1 application.

        //User Authentication
        bool P2000ImpersonateUser(string sUserName, string sSessionGuid, string sNewUserName);
        // Meta Data Interface
        bool GetItemTypeList(string UserName, string SessionGuid);
        bool GetItemSubTypeList(string UserName, string SessionGuid, string xmlDoc);
        bool GetItemSubTypeInfo(string UserName, string SessionGuid, string xmlDoc);
        // Configuration Interface
        bool GetItemList(string UserName, string SessionGuid, string xmlDoc);
        bool CreateItem(string UserName, string SessionGuid, string xmlDoc);
        bool ReadItem(string UserName, string SessionGuid, string xmlDoc);
        bool EditItem(string UserName, string SessionGuid, string xmlDoc);
        bool DeleteItem(string UserName, string SessionGuid, string xmlDoc);

        //History Transaction Interface
        //The history transaction interface supports two (2) different methods. The method outlined within
        //the XAction Methods (page 87), allows the third party application to raise P2000 transaction
        //messages and record entries within the P2000 transaction table.
        //However, third party applications are encouraged to use the function listed below, as this function
        //does not only raise the P2000 transaction message and record the entry in the P2000 transaction
        //table, but also generates the associated alarm messages and adjusts the status of the P2000 item,
        //in accordance with the “History Processing Rules” defined for this P2000 item.
        bool ProcessHistoryTransaction(string UserName, string SessionGuid, string xmlDoc);

        // Status Transaction Interface
        //The transaction interface allows the third party application to retrieve status information.
        //As a P2000 item can only change its status based on a transaction, this interface does not
        //support setting the status of a P2000 item directly.
        bool GetItemStatusList(string UserName, string SessionGuid, string xmlDoc);

        //        Alarm Processing Interface
        //The P2000 Alarm Processing interface consists of the alarm functions in “Alarm Methods”
        //on page 16 (especially the function “AlarmAction”) and the following “GetAlarmList”
        //method. The purpose of the Alarm Processing Interface is to allow a third party application
        //to implement a P2000 Alarm Monitor.
        bool GetAlarmList(string UserName, string SessionGuid);

        // Command Interface
        bool IssueCommand(string UserName, string SessionGuid, string xmlDoc);

        // Heartbeat Interface
        //        The heart beat interface allows the P2000 system to recognize that the third party system is
        //still alive. The heart beat call initiate a P2000 Heartbeat Message which can be forwarded
        //to a remote system.
        //The latter allows the third party application to detect that the P2000 system is fully
        //operational. If P2000 does not receive a heart beat message within three (3) times the
        //configured heart beat interval, P2000 raises an “Integration Server” alarm. This alarm can
        //only be completed if the third party component comes back online.
        bool HeartBeat(string UserName, string SessionGuid, string xmlDoc);

    }
}
