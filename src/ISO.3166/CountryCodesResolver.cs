using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using ISO._3166.Models;
using Newtonsoft.Json;

namespace ISO._3166
{
    public static class CountryCodesResolver
    {
        public static long Spent { get; }

        private static List<CountryCode> Codes { get; set; }

        static CountryCodesResolver()
        {
            var timer = new Stopwatch();
            timer.Start();

            LoadJson();    

            timer.Stop();
            Spent = timer.ElapsedMilliseconds;
        }

        public static void LoadJson()
        {
            using (var r = new StreamReader("codes.json"))
            {
                var json = r.ReadToEnd();
                Codes = JsonConvert.DeserializeObject<List<CountryCode>>(json);
            }
        }

        #region Get data by code
        public static CountryCode GetByCode(string code)
        {
            return Codes.FirstOrDefault(x => x.Alpha2 == code);
        }
        #endregion
    }
}
