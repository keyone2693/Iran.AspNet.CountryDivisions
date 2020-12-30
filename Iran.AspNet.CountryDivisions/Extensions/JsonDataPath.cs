using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Iran.CountryDivisions.AspNet.Extensions
{

    public static class JsonDataPath
    {
        private static AppDomain _appDomain = System.AppDomain.CurrentDomain;
        private static string _basePath = _appDomain.RelativeSearchPath ?? _appDomain.BaseDirectory;

        public static string AbadiJsonPath
        {
            get { return Path.Combine(_basePath, "Data", "abadi.json"); }
        }
        public static string BakhshJsonPath
        {
            get { return Path.Combine(_basePath, "Data", "bakhsh.json"); }
        }
        public static string DehestanJsonPath
        {
            get { return Path.Combine(_basePath, "Data", "dehestan.json"); }
        }
        public static string OstanJsonPath
        {
            get { return Path.Combine(_basePath, "Data", "ostan.json"); }
        }
        public static string ShahrJsonPath
        {
            get { return Path.Combine(_basePath, "Data", "shahr.json"); }
        }
        public static string ShahrestanJsonPath
        {
            get { return Path.Combine(_basePath, "Data", "shahrestan.json"); }
        }

    }
}
