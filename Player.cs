using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Player
    {
        public int _FactionId { get; set; }
        public string _FactionId_Conv { get; set; }
        public String _First_Line { get; set; }
        public string _Name { get; set; }
        public string _Full_Name { get; set; }
        public string _Email_Address { get; set; }
        public int _Fast_Study_Points { get; set; }
        public int _Noble_Points { get; set; }
        public int _First_Turn { get; set; }
        public int _Last_Turn { get; set; }
        public List<int> _Known { get; set; }
        public List<int> _Unit_List { get; set; }
        public List<int> _Unformed_Unit_List { get; set; }
        public string _Password { get; set; }

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

            Program._players.Add(new Player
            {
                _FactionId = Convert.ToInt32(InputKey),
                _FactionId_Conv = Utilities.to_oid(InputKey),
                _First_Line = myfl[0].ToString(),
                _Name = myna[0].ToString()
            });
            //foreach (var Location in Program._locations)
            var Player = (Program._players.Find(x => x._FactionId == Convert.ToInt32(InputKey)));
            if (Player != null)
            {
                if (j1.SelectToken("PL.un") != null && j1.SelectToken("PL.un").HasValues)
                {
                    JArray myun;
                    List<int> myuna;
                    myun = (JArray)j1.SelectToken("PL.un");
                    myuna = myun.ToObject<List<int>>();
                    Player._Unit_List = myuna.ToList();
                }
                if (j1.SelectToken("PL.uf") != null && j1.SelectToken("PL.uf").HasValues)
                {
                    JArray myuf;
                    List<int> myufa;
                    myuf = (JArray)j1.SelectToken("PL.uf");
                    myufa = myuf.ToObject<List<int>>();
                    Player._Unformed_Unit_List = myufa.ToList();
                }
                if (j1.SelectToken("PL.kn") != null && j1.SelectToken("PL.kn").HasValues)
                {
                    JArray mykn;
                    List<int> mykna;
                    mykn = (JArray)j1.SelectToken("PL.kn");
                    mykna = mykn.ToObject<List<int>>();
                    Player._Known = mykna.ToList();
                }
                if (j1.SelectToken("PL.fn") != null && j1.SelectToken("PL.fn").HasValues)
                {
                    JArray myfn;
                    myfn = (JArray)j1.SelectToken("PL.fn");
                    for (int i = 0; i < myfn.Count; i++)
                    {
                        Player._Full_Name = (Player._Full_Name + " " + myfn[i].ToString()).TrimStart();
                    }
                    //Player._Full_Name = myfn[0].ToString();
                }
                if (j1.SelectToken("PL.em") != null && j1.SelectToken("PL.em").HasValues)
                {
                    JArray myem;
                    myem = (JArray)j1.SelectToken("PL.em");
                    Player._Email_Address = myem[0].ToString();
                }
                if (j1.SelectToken("PL.pw") != null && j1.SelectToken("PL.pw").HasValues)
                {
                    JArray mypw;
                    mypw = (JArray)j1.SelectToken("PL.pw");
                    Player._Password = mypw[0].ToString();
                }
                if (j1.SelectToken("PL.np") != null && j1.SelectToken("PL.np").HasValues)
                {
                    JArray mynp;
                    mynp = (JArray)j1.SelectToken("PL.np");
                    Player._Noble_Points = Convert.ToInt32(mynp[0]);
                }
                if (j1.SelectToken("PL.fs") != null && j1.SelectToken("PL.fs").HasValues)
                {
                    JArray myfs;
                    myfs = (JArray)j1.SelectToken("PL.fs");
                    Player._Fast_Study_Points = Convert.ToInt32(myfs[0]);
                }
                if (j1.SelectToken("PL.ft") != null && j1.SelectToken("PL.ft").HasValues)
                {
                    JArray myft;
                    myft = (JArray)j1.SelectToken("PL.ft");
                    Player._First_Turn = Convert.ToInt32(myft[0]);
                }
                if (j1.SelectToken("PL.lt") != null && j1.SelectToken("PL.lt").HasValues)
                {
                    JArray mylt;
                    mylt = (JArray)j1.SelectToken("PL.lt");
                    Player._Last_Turn = Convert.ToInt32(mylt[0]);
                }
            }
        }
    }
}
