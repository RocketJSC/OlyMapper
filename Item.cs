using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Itemz
    {
        public int _ItemId { get; set; }
        public string _ItemId_Conv { get; set; }
        public string _Name { get; set; }
        public string _First_Line { get; set; }
        public string _Plural { get; set; }
        public int _Weight { get; set; }
        public int _Land_Capacity { get; set; }
        public int _Ride_Capacity { get; set; }
        public int _Fly_Capacity { get; set; }
        public string _IT_Prominent { get; set; }
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
            if (j1.SelectToken("firstline") != null && j1.SelectToken("firstline").HasValues)
            {
                myfl = (JArray)j1.SelectToken("firstline");
            }
            else
            {
                myfl = null;
            }

            Program._items.Add(new Itemz
            {
                _ItemId = Convert.ToInt32(InputKey),
                _ItemId_Conv = Utilities.to_oid(InputKey),
                _First_Line = myfl[0].ToString(),
                _Name = myna[0].ToString()
            });
            //foreach (var Location in Program._locations)
            var Itemz = (Program._items.Find(x => x._ItemId == Convert.ToInt32(InputKey)));
            if (Itemz != null)
            {
                if (j1.SelectToken("IT.pl") != null && j1.SelectToken("IT.pl").HasValues)
                {
                    JArray mypl;
                    mypl = (JArray)j1.SelectToken("IT.pl");
                    Itemz._Plural = mypl[0].ToString();
                }
                Itemz._Weight = 0;
                if (j1.SelectToken("IT.wt") != null && j1.SelectToken("IT.wt").HasValues)
                {
                    JArray mywt;
                    mywt = (JArray)j1.SelectToken("IT.wt");
                    Itemz._Weight = Convert.ToInt32(mywt[0]);
                }
                Itemz._Land_Capacity = 0;
                if (j1.SelectToken("IT.lc") != null && j1.SelectToken("IT.lc").HasValues)
                {
                    JArray mylc;
                    mylc = (JArray)j1.SelectToken("IT.lc");
                    Itemz._Land_Capacity = Convert.ToInt32(mylc[0]);
                }
                Itemz._Ride_Capacity = 0;
                if (j1.SelectToken("IT.rc") != null && j1.SelectToken("IT.rc").HasValues)
                {
                    JArray myrc;
                    myrc = (JArray)j1.SelectToken("IT.rc");
                    Itemz._Ride_Capacity = Convert.ToInt32(myrc[0]);
                }
                Itemz._Fly_Capacity = 0;
                if (j1.SelectToken("IT.fc") != null && j1.SelectToken("IT.fc").HasValues)
                {
                    JArray myfc;
                    myfc = (JArray)j1.SelectToken("IT.fc");
                    Itemz._Fly_Capacity = Convert.ToInt32(myfc[0]);
                }
                Itemz._IT_Prominent = "0";
                if (j1.SelectToken("IT.pr") != null && j1.SelectToken("IT.pr").HasValues)
                {
                    JArray mypr;
                    mypr = (JArray)j1.SelectToken("IT.pr");
                    Itemz._IT_Prominent = mypr[0].ToString();
                }
            }
        }
    }
}
