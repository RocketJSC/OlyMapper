using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Skill
    {
        public int _SkillId { get; set; }
        public string _Name { get; set; }
        public string _First_Line { get; set; }
        public int _SK_Time_to_learn { get; set; }
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

            Program._skills.Add(new Skill
            {
                _SkillId = Convert.ToInt32(InputKey),
                _First_Line = myfl[0].ToString(),
                _Name = myna[0].ToString()
            });
            //foreach (var Location in Program._locations)
            var Skill = (Program._skills.Find(x => x._SkillId == Convert.ToInt32(InputKey)));
            if (Skill != null)
            {
                if (j1.SelectToken("SK.tl") != null && j1.SelectToken("SK.tl").HasValues)
                {
                    JArray mytl;
                    mytl = (JArray)j1.SelectToken("SK.tl");
                    Skill._SK_Time_to_learn = Convert.ToInt32(mytl[0]);
                }
            }
        }
    }
}
