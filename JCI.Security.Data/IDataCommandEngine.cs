using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data
{
    /// <summary>
    /// P2000 Methods
    /// </summary>
    public interface IDataCommandEngine
    {
        /// <summary>
        /// P2000s the get system info.
        /// </summary>
        /// <param name="sUserName">Name of the s user.</param>
        /// <param name="sSessionGuid">The s session GUID.</param>
        /// <returns></returns>
        P2000GetSystemInfoResponse P2000GetSystemInfo(string sUserName, string sSessionGuid);
        P2000GetVersionResponse P2000GetVersion(string sUserName, string sSessionGuid);
        bool P2000IsSessionValid(string sUserName, string sSession);
        P2000LoginResponse P2000Login(string sUserName, string sPassword);
        P2000LoginResponse P2000Login(string sUserName, string sPassword, int iPasswordMode);
        P2000LoginResponse P2000LoginHashed(string sUserName, string sPassword);
        bool P2000Logout(string sUserName, string sSession);
    }
}
