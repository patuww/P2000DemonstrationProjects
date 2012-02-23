using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCI.Security.Data.DTO;

namespace JCI.Security.Data.Implementations
{
    public class DataCommandEngineService : IDataCommandEngine
    {
        public P2000GetSystemInfoResponse P2000GetSystemInfo(string sUserName, string sSessionGuid)
        {
            throw new NotImplementedException();
        }

        public P2000GetVersionResponse P2000GetVersion(string sUserName, string sSessionGuid)
        {
            throw new NotImplementedException();
        }

        public bool P2000IsSessionValid(string sUserName, string sSession)
        {
            throw new NotImplementedException();
        }

        public P2000LoginResponse P2000Login(string sUserName, string sPassword)
        {
            throw new NotImplementedException();
        }

        public P2000LoginResponse P2000Login(string sUserName, string sPassword, int iPasswordMode)
        {
            throw new NotImplementedException();
        }

        public P2000LoginResponse P2000LoginHashed(string sUserName, string sPassword)
        {
            throw new NotImplementedException();
        }

        public bool P2000Logout(string sUserName, string sSession)
        {
            throw new NotImplementedException();
        }
    }
}
