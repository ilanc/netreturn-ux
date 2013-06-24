using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;

namespace NetReturn.Lib
{
    public static class Environment
    {
        static string[] ProductionServers = new string[] { "ilancopelyn" };
        static bool _IsLive = false;

        static Environment()
        {
            string isLive = GetConfigSetting("IsLive");
            if (!String.IsNullOrEmpty(isLive))
            {
                _IsLive = Boolean.Parse(isLive);
            }
        }

        private static string GetConfigSetting(string name)
        {
            string path = WebConfigurationManager.AppSettings[name];
            /*
            if (string.IsNullOrEmpty(path))
            {
                throw new WebException("Missing " + name + " setting in web.config.");
            }
             */
            return path;
        }

        private static bool HasConfigSetting(string name)
        {
            string path = WebConfigurationManager.AppSettings[name];
            return (!string.IsNullOrEmpty(path));
        }

        public static bool IsLive()
        {
            //string host = Dns.GetHostName().ToLower();
            //return ProductionServers.Contains(host);
            return _IsLive;
        }
    }
}