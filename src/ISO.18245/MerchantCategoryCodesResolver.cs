using ISO._18245.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ISO._18245
{
    /// <summary>
    /// Source is here https://github.com/greggles/mcc-codes/blob/master/mcc_codes.json
    /// </summary>
    public static class MerchantCategoryCodesResolver
    {
        public static long Spent { get; }

        private static List<MerchantCategoryCode> Codes { get; set; }
        
        static MerchantCategoryCodesResolver()
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
                Codes = JsonConvert.DeserializeObject<List<MerchantCategoryCode>>(json);
            }
        }

        #region Get data by code
        public static MerchantCategoryCode GetByCode(string code)
        {
            return Codes.FirstOrDefault(x => x.Mcc == code);
        }
        #endregion
    }
}
