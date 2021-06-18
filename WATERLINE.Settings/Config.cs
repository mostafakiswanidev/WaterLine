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
        public static void Init(IConfiguration config)
        {
            Configuration = config;
        }
    }
}
