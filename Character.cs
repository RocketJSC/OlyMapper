using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Character
    {
        public int _CharId { get; set; }
        public string _Name { get; set; }
        public string _Char_Type { get; set; }
        public string _First_Line { get; set; }
        public int _PlayerId { get; set; }
        public int _CH_Attack { get; set; }
        public string _CH_Behind { get; set; }
        public int _CH_Break_Point { get; set; }
        public List<int> _CH_Contact { get; set; }
        public int _CH_Defense { get; set; }
        public string _CH_Guard { get; set; }
        public int _CH_Health { get; set; }
        public int _CH_Lord { get; set; }
        public int _CH_LOY_Kind { get; set; }
        public int _CH_LOY_Rate { get; set; }
        public int _CH_Missile { get; set; }
        public string _CH_Prisoner { get; set; }
        public string _CH_Rank { get; set; }
        public List<string> _CH_Skills_List { get; set; }
        public string _CM_Magician { get; set; }
        public int _CM_Pledged_To { get; set; }
        public string _CM_Max_Aura { get; set; }
        public string _CM_Cur_Aura { get; set; }
        public string _CM_Vision_Protect { get; set; }
        public string _CM_Hide_Self { get; set; }
        public int _LI_Where { get; set; }
        public List<string> _LI_Here_List { get; set; }
        public int _MI_Garrison_Castle { get; set; }
        public string _MI_Cmd_Allow { get; set; }
        public List<int> _Item_List { get; set; }
        public List<string> _Trade_List { get; set; }
        public List<string> _Defend_List { get; set; }
        public List<string> _Neutral_List { get; set; }
        public List<string> _Hostile_List { get; set; }
        public int Accumulated_Weight { get; set; }
        public static void Add(string InputKey, string InputString)
        {
            JObject j1 = JObject.Parse(InputString);
            JArray myfl;
            string mychartypea;
            string mychartype;
            if (j1.SelectToken("firstline") != null && j1.SelectToken("firstline").HasValues)
            {
                myfl = (JArray)j1.SelectToken("firstline");
                mychartypea = myfl.ToString().Substring(myfl.ToString().IndexOf("char ") + 5);
                mychartype = mychartypea.ToString().Substring(0, mychartypea.IndexOf("\""));
            }
            else
            {
                myfl = null;
                mychartypea = null;
                mychartype = null;
            }
            Program._characters.Add(new Character
            {
                _CharId = Convert.ToInt32(InputKey),
                _First_Line = myfl[0].ToString(),
                _Char_Type = mychartype
            });
            var Character = (Program._characters.Find(x => x._CharId == Convert.ToInt32(InputKey)));
            if (Character != null)
            {
                if (Character._CharId.Equals(Convert.ToInt32(InputKey)))
                {
                    if (j1.SelectToken("na") != null && j1.SelectToken("na").HasValues)
                    {
                        JArray myna;
                        myna = (JArray)j1.SelectToken("na");
                        Character._Name = myna[0].ToString();
                    }
                    else
                    {
                        if (Character._Char_Type.Equals("garrison"))
                        {
                            Character._Name = Character._Char_Type.First().ToString().ToUpper() + Character._Char_Type.Substring(1);
                        }
                    }
                }
                if (j1.SelectToken("CH.at") != null && j1.SelectToken("CH.at").HasValues)
                {
                    JArray myat;
                    myat = (JArray)j1.SelectToken("CH.at");
                    Character._CH_Attack = Convert.ToInt32(myat[0]);
                }
                if (j1.SelectToken("CH.bh") != null && j1.SelectToken("CH.bh").HasValues)
                {
                    JArray mybh;
                    mybh = (JArray)j1.SelectToken("CH.bh");
                    Character._CH_Behind = mybh[0].ToString();
                }
                if (j1.SelectToken("CH.bp") != null && j1.SelectToken("CH.bp").HasValues)
                {
                    JArray mybp;
                    mybp = (JArray)j1.SelectToken("CH.bp");
                    Character._CH_Break_Point = Convert.ToInt32(mybp[0]);
                }
                if (j1.SelectToken("CH.ct") != null && j1.SelectToken("CH.ct").HasValues)
                {
                    JArray myct;
                    List<int> mycta;
                    myct = (JArray)j1.SelectToken("CH.ct");
                    mycta = myct.ToObject<List<int>>();
                    Character._CH_Contact = mycta.ToList();
                }
                if (j1.SelectToken("CH.df") != null && j1.SelectToken("CH.df").HasValues)
                {
                    JArray mydf;
                    mydf = (JArray)j1.SelectToken("CH.df");
                    Character._CH_Defense = Convert.ToInt32(mydf[0]);
                }
                if (j1.SelectToken("CH.gu") != null && j1.SelectToken("CH.gu").HasValues)
                {
                    JArray mygu;
                    mygu = (JArray)j1.SelectToken("CH.gu");
                    Character._CH_Guard = mygu[0].ToString();
                }
                if (j1.SelectToken("CH.he") != null && j1.SelectToken("CH.he").HasValues)
                {
                    JArray myhe;
                    myhe = (JArray)j1.SelectToken("CH.he");
                    Character._CH_Health = Convert.ToInt32(myhe[0]);
                }
                Character._CH_LOY_Kind = -2;
                if (j1.SelectToken("CH.lk") != null && j1.SelectToken("CH.lk").HasValues)
                {
                    JArray mylk;
                    mylk = (JArray)j1.SelectToken("CH.lk");
                    Character._CH_LOY_Kind = Convert.ToInt32(mylk[0]);
                }
                if (j1.SelectToken("CH.lo") != null && j1.SelectToken("CH.lo").HasValues)
                {
                    JArray mylo;
                    mylo = (JArray)j1.SelectToken("CH.lo");
                    Character._CH_Lord = Convert.ToInt32(mylo[0]);
                }
                Character._CH_LOY_Rate = 0;
                if (j1.SelectToken("CH.lr") != null && j1.SelectToken("CH.lr").HasValues)
                {
                    JArray mylr;
                    mylr = (JArray)j1.SelectToken("CH.lr");
                    Character._CH_LOY_Rate = Convert.ToInt32(mylr[0]);
                }
                if (j1.SelectToken("CH.mi") != null && j1.SelectToken("CH.mi").HasValues)
                {
                    JArray mymi;
                    mymi = (JArray)j1.SelectToken("CH.mi");
                    Character._CH_Missile = Convert.ToInt32(mymi[0]);
                }
                if (j1.SelectToken("CH.pr") != null && j1.SelectToken("CH.pr").HasValues)
                {
                    JArray mypr;
                    mypr = (JArray)j1.SelectToken("CH.pr");
                    Character._CH_Prisoner = mypr[0].ToString();
                }
                if (j1.SelectToken("CH.ra") != null && j1.SelectToken("CH.ra").HasValues)
                {
                    JArray myra;
                    myra = (JArray)j1.SelectToken("CH.ra");
                    Character._CH_Rank = myra[0].ToString();
                }
                if (j1.SelectToken("CH.sl") != null && j1.SelectToken("CH.sl").HasValues)
                {
                    JArray mysl;
                    mysl = (JArray)j1.SelectToken("CH.sl");
                    List<string> mysla;
                    mysla = mysl.ToObject<List<string>>();
                    Character._CH_Skills_List = mysla.ToList();
                }
                Character._CM_Pledged_To = 0;
                if (j1.SelectToken("CM.pl") != null && j1.SelectToken("CM.pl").HasValues)
                {
                    JArray mypl;
                    mypl = (JArray)j1.SelectToken("CM.pl");
                    Character._CM_Pledged_To = Convert.ToInt32(mypl[0].ToString());
                }
                if (j1.SelectToken("CM.vp") != null && j1.SelectToken("CM.vp").HasValues)
                {
                    JArray myvp;
                    myvp = (JArray)j1.SelectToken("CM.vp");
                    Character._CM_Vision_Protect = myvp[0].ToString();
                }
                if (j1.SelectToken("CM.im") != null && j1.SelectToken("CM.im").HasValues)
                {
                    JArray myim;
                    myim = (JArray)j1.SelectToken("CM.im");
                    Character._CM_Magician = myim[0].ToString();
                }
                if (j1.SelectToken("CM.ma") != null && j1.SelectToken("CM.ma").HasValues)
                {
                    JArray myma;
                    myma = (JArray)j1.SelectToken("CM.ma");
                    Character._CM_Max_Aura = myma[0].ToString();
                }
                if (j1.SelectToken("CM.ca") != null && j1.SelectToken("CM.ca").HasValues)
                {
                    JArray myca;
                    myca = (JArray)j1.SelectToken("CM.ca");
                    Character._CM_Cur_Aura = myca[0].ToString();
                }
                if (j1.SelectToken("CM.hs") != null && j1.SelectToken("CM.hs").HasValues)
                {
                    JArray myhs;
                    myhs = (JArray)j1.SelectToken("CM.hs");
                    Character._CM_Hide_Self = myhs[0].ToString();
                }
                if (j1.SelectToken("LI.wh") != null && j1.SelectToken("LI.wh").HasValues)
                {
                    JArray mywh;
                    mywh = (JArray)j1.SelectToken("LI.wh");
                    Character._LI_Where = Convert.ToInt32(mywh[0].ToString());
                }
                if (j1.SelectToken("LI.hl") != null && j1.SelectToken("LI.hl").HasValues)
                {
                    JArray myhl;
                    myhl = (JArray)j1.SelectToken("LI.hl");
                    List<string> myhla;
                    myhla = myhl.ToObject<List<string>>();
                    Character._LI_Here_List = myhla.ToList();
                }
                if (j1.SelectToken("MI.ca") != null && j1.SelectToken("MI.ca").HasValues)
                {
                    JArray myca;
                    myca = (JArray)j1.SelectToken("MI.ca");
                    Character._MI_Cmd_Allow = myca[0].ToString();
                }
                Character._MI_Garrison_Castle = 0;
                if (j1.SelectToken("MI.gc") != null && j1.SelectToken("MI.gc").HasValues)
                {
                    JArray mygc;
                    mygc = (JArray)j1.SelectToken("MI.gc");
                    Character._MI_Garrison_Castle = Convert.ToInt32(mygc[0].ToString());
                }
                if (j1.SelectToken("il") != null && j1.SelectToken("il").HasValues)
                {
                    JArray myil;
                    List<int> myila;
                    myil = (JArray)j1.SelectToken("il");
                    myila = myil.ToObject<List<int>>();
                    Character._Item_List = myila.ToList();
                }
                if (j1.SelectToken("tl") != null && j1.SelectToken("tl").HasValues)
                {
                    JArray mytl;
                    List<string> mytla;
                    mytl = (JArray)j1.SelectToken("tl");
                    mytla = mytl.ToObject<List<string>>();
                    Character._Trade_List = mytla.ToList();
                }
                if (j1.SelectToken("ad") != null && j1.SelectToken("ad").HasValues)
                {
                    JArray myad;
                    List<string> myada;
                    myad = (JArray)j1.SelectToken("ad");
                    myada = myad.ToObject<List<string>>();
                    Character._Defend_List = myada.ToList();
                }
                if (j1.SelectToken("ah") != null && j1.SelectToken("ah").HasValues)
                {
                    JArray myah;
                    List<string> myaha;
                    myah = (JArray)j1.SelectToken("ah");
                    myaha = myah.ToObject<List<string>>();
                    Character._Hostile_List = myaha.ToList();
                }
                if (j1.SelectToken("an") != null && j1.SelectToken("an").HasValues)
                {
                    JArray myan;
                    List<string> myana;
                    myan = (JArray)j1.SelectToken("an");
                    myana = myan.ToObject<List<string>>();
                    Character._Neutral_List = myana.ToList();
                }
            }
        }
        public static void Post_PlayerId()
        {
            foreach(Player _myplayer in Program._players)
            {
                if (_myplayer._Unit_List != null)
                {
                    foreach (int _unit in _myplayer._Unit_List)
                    {
                        Character _mychar = Program._characters.Find(x => x._CharId == _unit);
                        if (_mychar != null)
                        {
                            _mychar._PlayerId = _myplayer._FactionId;
                        }
                    }
                }
            }
        }
        public static void Calculate_Weight()
        {
            foreach (Character _myChar in Program._characters)
            {
                _myChar.Accumulated_Weight = 0;
                if (_myChar._Item_List != null)
                {
                    int iterations = _myChar._Item_List.Count() / 2;
                    for (int i = 0; i < iterations; i++)
                    {
                        int _item = _myChar._Item_List[(i * 2)];
                        int _qty = _myChar._Item_List[(i * 2) + 1];
                        Itemz _myitem = Program._items.Find(x => x._ItemId == _item);
                        if (_myitem != null)
                        {
                            _myChar.Accumulated_Weight += (_myitem._Weight * _qty);
                        }
                    }
                }
            }
        }
    }
}
