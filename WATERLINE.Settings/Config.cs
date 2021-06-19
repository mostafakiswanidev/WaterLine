using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace WATERLINE.Settings
{
    public static class Config
    {
        public static IConfiguration Configuration { get; set; }
        public static string LocalConnectionString { get { return Configuration.GetSection("LocalConnectionString").Value; } }
        public static string RegionKey { get { return Configuration.GetSection("RegionKey").Value; } }
        public static string ApplicationNameAsKey { get { return Configuration.GetSection("ApplicationName").Key; } }
        public static string ApplicationNameAsValue { get { return Configuration.GetSection("ApplicationName").Value; } }
        public static string ApplicationSloganAsKey { get { return Configuration.GetSection("ApplicationSlogan").Key; } }
        public static string ApplicationSloganAsValue { get { return Configuration.GetSection("ApplicationSlogan").Value; } }
        

        public static void Init(IConfiguration config)
        {
            Configuration = config;
        }
    }
}
