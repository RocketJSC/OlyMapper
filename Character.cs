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
        public int _CH_Behind { get; set; }
        public int _CH_Break_Point { get; set; }
        public List<int> _CH_Contact { get; set; }
        public int _CH_Defense { get; set; }
        public int _CH_Guard { get; set; }
        public int _CH_Health { get; set; }
        public int _CH_Lord { get; set; }
        public int _CH_LOY_Kind { get; set; }
        public int _CH_LOY_Rate { get; set; }
        public int _CH_Missile { get; set; }
        public int _CH_NPC_Unit_Type { get; set; }
        public int _CH_Prisoner { get; set; }
        public int _CH_Rank { get; set; }
        public int _CH_Sick { get; set; }
        public List<int> _CH_Skills_List { get; set; }
        public int _CM_Magician { get; set; }
        public int _CM_Pledged_To { get; set; }
        public int _CM_Max_Aura { get; set; }
        public int _CM_Cur_Aura { get; set; }
        public int _CM_Vision_Protect { get; set; }
        public int _CM_Hide_Self { get; set; }
        public List<int> _CM_Already_Visioned { get; set; }
        public int _LI_Where { get; set; }
        public List<int> _LI_Here_List { get; set; }
        public int _MI_Garrison_Castle { get; set; }
        public string _MI_Cmd_Allow { get; set; }
        public List<int> _Item_List { get; set; }
        public List<string> _Trade_List { get; set; }
        public List<int> _Defend_List { get; set; }
        public List<int> _Neutral_List { get; set; }
        public List<int> _Hostile_List { get; set; }
        public int Accumulated_Weight { get; set; }
        public int Accumulated_Land_Cap { get; set; }
        public int Accumulated_Riding_Cap { get; set; }
        public int Accumulated_Flying_Cap { get; set; }
        public int Accumulated_Men { get; set; }
        public int Ultimate_Lord { get; set; }
        public string Calc_CurrentLoc { get; set; }
        public int Calc_CurrentRegion { get; set; }
        public static void Add(string InputKey, string InputString)
        {
            JObject j1 = JObject.Parse(InputString);
            JArray myfl;
            string mychartype;
            if (j1.SelectToken("firstline") != null && j1.SelectToken("firstline").HasValues)
            {
                myfl = (JArray)j1.SelectToken("firstline");
                string[] type_array = myfl[0].ToString().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                mychartype = type_array[2];
            }
            else
            {
                myfl = null;
                mychartype = null;
            }
            Program._characters.Add(new Character
            {
                _CharId = Convert.ToInt32(InputKey),
                _First_Line = myfl[0].ToString(),
                _Char_Type = mychartype,
                _PlayerId = 0,
                _Item_List = JSON.list_Token(j1,"il"),
                _Defend_List = JSON.list_Token(j1, "ad"),
                _Hostile_List = JSON.list_Token(j1, "ah"),
                _Neutral_List = JSON.list_Token(j1, "an"),
                Accumulated_Weight = 0,
                Accumulated_Riding_Cap = 0,
                Accumulated_Men = 0,
                Accumulated_Land_Cap = 0,
                Accumulated_Flying_Cap = 0,
                Ultimate_Lord = 0,
                _CH_Attack = JSON.int_Token(j1, "CH.at"),
                _CH_Behind = JSON.int_Token(j1, "CH.bh"),
                _CH_Break_Point = JSON.int_Token(j1, "CH.bp"),
                _CH_Contact = JSON.list_Token(j1, "CH.ct"),
                _CH_Defense = JSON.int_Token(j1, "CH.df"),
                _CH_Guard = JSON.int_Token(j1, "CH.gu"),
                _CH_Health = JSON.int_Token(j1, "CH.he"),
                _CH_LOY_Kind = JSON.int_Token(j1, "CH.lk", -2),
                _CH_Lord = JSON.int_Token(j1, "CH.lo"),
                _CH_LOY_Rate = JSON.int_Token(j1, "CH.lr"),
                _CH_Missile = JSON.int_Token(j1, "CH.mi"),
                _CH_NPC_Unit_Type = JSON.int_Token(j1, "CH.ni"),
                _CH_Prisoner = JSON.int_Token(j1, "CH.pr"),
                _CH_Rank = JSON.int_Token(j1, "CH.ra"),
                _CH_Sick = JSON.int_Token(j1, "CH.si"),
                _CH_Skills_List = JSON.list_Token(j1, "CH.sl"),
                _CM_Cur_Aura = JSON.int_Token(j1, "CM.ca"),
                _CM_Hide_Self = JSON.int_Token(j1, "CM.hs"),
                _CM_Magician = JSON.int_Token(j1, "CM.im"),
                _CM_Max_Aura = JSON.int_Token(j1, "CM.ma"),
                _CM_Pledged_To = JSON.int_Token(j1, "CM.pl"),
                _CM_Already_Visioned = JSON.list_Token(j1, "CM.vi"),
                _CM_Vision_Protect = JSON.int_Token(j1, "CM.vp"),
                _LI_Here_List = JSON.list_Token(j1, "LI.hl"),
                _LI_Where = JSON.int_Token(j1, "LI.wh"),
                _MI_Cmd_Allow = JSON.string_Token(j1, "MI.ca"),
                _MI_Garrison_Castle = JSON.int_Token(j1, "MI.gc")
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
                //if (j1.SelectToken("CH.ct") != null && j1.SelectToken("CH.ct").HasValues)
                //{
                //    JArray myct;
                //    List<int> mycta;
                //    myct = (JArray)j1.SelectToken("CH.ct");
                //    mycta = myct.ToObject<List<int>>();
                //    Character._CH_Contact = mycta.ToList();
                //}
                //if (j1.SelectToken("CH.sl") != null && j1.SelectToken("CH.sl").HasValues)
                //{
                //    JArray mysl;
                //    mysl = (JArray)j1.SelectToken("CH.sl");
                //    List<string> mysla;
                //    mysla = mysl.ToObject<List<string>>();
                //    Character._CH_Skills_List = mysla.ToList();
                //}
                //if (j1.SelectToken("CM.vi") != null && j1.SelectToken("CM.vi").HasValues)
                //{
                //    JArray myvi;
                //    myvi = (JArray)j1.SelectToken("CM.vi");
                //    List<int> myvia;
                //    myvia = myvi.ToObject<List<int>>();
                //    Character._CM_Already_Visioned = new List<int>();
                //    for (int i = 0; i < myvi.Count; i++)
                //    {
                //        Character._CM_Already_Visioned.Add (Convert.ToInt32(myvia[i]));
                //    }
                //}
                //if (j1.SelectToken("LI.hl") != null && j1.SelectToken("LI.hl").HasValues)
                //{
                //    JArray myhl;
                //    myhl = (JArray)j1.SelectToken("LI.hl");
                //    List<string> myhla;
                //    myhla = myhl.ToObject<List<string>>();
                //    Character._LI_Here_List = myhla.ToList();
                //}
                //if (j1.SelectToken("il") != null && j1.SelectToken("il").HasValues)
                //{
                //    JArray myil;
                //    List<int> myila;
                //    myil = (JArray)j1.SelectToken("il");
                //    myila = myil.ToObject<List<int>>();
                //    Character._Item_List = myila.ToList();
                //}
                if (j1.SelectToken("tl") != null && j1.SelectToken("tl").HasValues)
                {
                    JArray mytl;
                    List<string> mytla;
                    mytl = (JArray)j1.SelectToken("tl");
                    mytla = mytl.ToObject<List<string>>();
                    Character._Trade_List = mytla.ToList();
                }
                //if (j1.SelectToken("ad") != null && j1.SelectToken("ad").HasValues)
                //{
                //    JArray myad;
                //    List<string> myada;
                //    myad = (JArray)j1.SelectToken("ad");
                //    myada = myad.ToObject<List<string>>();
                //    Character._Defend_List = myada.ToList();
                //}
                //if (j1.SelectToken("ah") != null && j1.SelectToken("ah").HasValues)
                //{
                //    JArray myah;
                //    List<string> myaha;
                //    myah = (JArray)j1.SelectToken("ah");
                //    myaha = myah.ToObject<List<string>>();
                //    Character._Hostile_List = myaha.ToList();
                //}
                //if (j1.SelectToken("an") != null && j1.SelectToken("an").HasValues)
                //{
                //    JArray myan;
                //    List<string> myana;
                //    myan = (JArray)j1.SelectToken("an");
                //    myana = myan.ToObject<List<string>>();
                //    Character._Neutral_List = myana.ToList();
                //}
            }
        }
        public static void Post_PlayerId()
        {
            foreach (Player _myplayer in Program._players)
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
        public static void Determine_Ultimate_Lord()
        {
            foreach (Character _myChar in Program._characters)
            {
                if (_myChar._CM_Pledged_To != 0)
                {
                    _myChar.Ultimate_Lord = Utilities.Chase_Pledge_Chain(_myChar._CharId);
                }
            }
        }
        public static bool Is_Priest(Character _mychar)
        {
            if (_mychar._CH_Skills_List != null)
            {
                int iterations = _mychar._CH_Skills_List.Count / 4;
                for (int i = 0; i < iterations; i++)
                {
                    if (_mychar._CH_Skills_List[(i * 4) + 0] == 750)
                    {
                        if (!_mychar._CH_Skills_List[(i * 4) + 1].Equals(0))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static string Mage_Type(Character _mychar)
        {
            if (_mychar._CM_Magician == 1)
            {
                if (_mychar._CM_Max_Aura <= 5)
                {
                    return "";
                }
                else
                {
                    if (_mychar._CM_Max_Aura <= 10)
                    {
                        return "conjurer";
                    }
                    else
                    {
                        if (_mychar._CM_Max_Aura <= 15)
                        {
                            return "mage";
                        }
                        else
                        {
                            if (_mychar._CM_Max_Aura <= 20)
                            {
                                return "wizard";
                            }
                            else
                            {
                                if (_mychar._CM_Max_Aura <= 30)
                                {
                                    return "sorcerer";
                                }
                                else
                                {
                                    if (_mychar._CM_Max_Aura <= 40)
                                    {
                                        return "6th black circle";
                                    }
                                    else
                                    {
                                        if (_mychar._CM_Max_Aura <= 50)
                                        {
                                            return "5th black circle";
                                        }
                                        else
                                        {
                                            if (_mychar._CM_Max_Aura <= 60)
                                            {
                                                return "4th black circle";
                                            }
                                            else
                                            {
                                                if (_mychar._CM_Max_Aura <= 70)
                                                {
                                                    return "3rd black circle";
                                                }
                                                else
                                                {

                                                    if (_mychar._CM_Max_Aura <= 80)
                                                    {
                                                        return "2nd black circle";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return "";
            }
            return "master of the black arts";
        }
        public static bool Is_Magician(Character mychar)
        {
            if (mychar._CM_Magician > 1)
            {
                return true;
            }
            return false;
        }
        public static Weight determine_unit_weights(Character _myChar)
        {
            Weight myweight = new Weight()
            {
                _animals = 0,
                _total_weight = 0,
                _land_cap = 0,
                _land_weight = 0,
                _ride_cap = 0,
                _ride_weight = 0,
                _fly_cap = 0,
                _fly_weight = 0
            };
            if (_myChar._Item_List != null)
            {
                int unit_type = (_myChar._CH_NPC_Unit_Type != 0 ? _myChar._CH_NPC_Unit_Type : 10);
                Itemz myitem = Program._items.Find(x => x._ItemId == unit_type);
                myweight = Itemz.Add_Item_Weight(myitem, 1, myweight);
                myitem = null;

                int iterations = _myChar._Item_List.Count / 2;
                for (int i = 0; i < iterations; i++)
                {
                    if (Program._items.Find(x => x._ItemId == _myChar._Item_List[i * 2]) != null)
                    {
                        myitem = Program._items.Find(x => x._ItemId == _myChar._Item_List[i * 2]);
                        myweight = Itemz.Add_Item_Weight(myitem, (_myChar._Item_List[(i * 2) + 1]), myweight);
                    }
                }
            }

            return myweight;
        }
    }
}
