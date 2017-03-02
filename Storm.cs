using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Storm
    {
        public int _StormId { get; set; }
        public string _First_Line { get; set; }
        public string _Storm_Type { get; set; }
        public string _Storm_Strength { get; set; }
        public int _Where { get; set; }
        public static void Add(string InputKey, string InputString)
        {
            JObject j1 = JObject.Parse(InputString);
            JArray myna;
            JArray myfl;
            if (j1.SelectToken("na") != null && j1.SelectToken("na").HasValues)
            {
                myna = (JArray)j1.SelectToken("na");
            }
            else
            {
                myna = null;
            }
            string mystormtype;
            if (j1.SelectToken("firstline") != null && j1.SelectToken("firstline").HasValues)
            {
                myfl = (JArray)j1.SelectToken("firstline");
                string[] type_array = myfl[0].ToString().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                mystormtype = type_array[2];
            }
            else
            {
                myfl = null;
                mystormtype = null;
            }

            Program._storms.Add(new Storm
            {
                _StormId = Convert.ToInt32(InputKey),
                _First_Line = myfl[0].ToString(),
                _Storm_Type = mystormtype
            });
            //foreach (var Location in Program._locations)
            var Storm = (Program._storms.Find(x => x._StormId == Convert.ToInt32(InputKey)));
            if (Storm != null)
            {
                if (j1.SelectToken("MI.ss") != null && j1.SelectToken("MI.ss").HasValues)
                {
                    JArray myss;
                    myss = (JArray)j1.SelectToken("MI.ss");
                    Storm._Storm_Strength = myss[0].ToString();
                }
                if (j1.SelectToken("LI.wh") != null && j1.SelectToken("LI.wh").HasValues)
                {
                    JArray mywh;
                    mywh = (JArray)j1.SelectToken("LI.wh");
                    Storm._Where = Convert.ToInt32(mywh[0].ToString());
                }
            }
        }
    }
}
