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
        public string _Item_Type { get; set; }
        public string _Name { get; set; }
        public string _First_Line { get; set; }
        public string _Plural { get; set; }
        public int _Weight { get; set; }
        public int _Land_Capacity { get; set; }
        public int _Ride_Capacity { get; set; }
        public int _Fly_Capacity { get; set; }
        public string _IT_Prominent { get; set; }
        public string _IT_Man_Item { get; set; }
        public string _IT_Animal { get; set; }
        public int _IT_Who_Has { get; set; }
        public int _IM_Aura_Bonus { get; set; }
        public int _IM_May_Study { get; set; }
        public int _IM_Use_Key { get; set; }
        public int _IM_Attack_Bonus { get; set; }
        public int _IM_Defense_Bonus { get; set; }
        public int _IM_Missile_Bonus { get; set; }
        public int _IM_Aura { get; set; }
        public int _IM_Project_Cast { get; set; }
        public int _IM_Lore { get; set; }
        public int _PL_Unit { get; set; }
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
            string myitemtypea;
            string myitemtype;
            if (j1.SelectToken("firstline") != null && j1.SelectToken("firstline").HasValues)
            {
                myfl = (JArray)j1.SelectToken("firstline");
                myitemtypea = myfl.ToString().Substring(myfl.ToString().IndexOf("item ") + 5);
                myitemtype = myitemtypea.ToString().Substring(0, myitemtypea.IndexOf("\""));
            }
            else
            {
                myfl = null;
                myitemtypea = null;
                myitemtype = null;
            }

            Program._items.Add(new Itemz
            {
                _ItemId = Convert.ToInt32(InputKey),
                _ItemId_Conv = Utilities.to_oid(InputKey),
                _First_Line = myfl[0].ToString(),
                _Name = myna[0].ToString(),
                _Item_Type = myitemtype
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
                Itemz._IT_Man_Item = "0";
                if (j1.SelectToken("IT.mu") != null && j1.SelectToken("IT.mu").HasValues)
                {
                    JArray mymu;
                    mymu = (JArray)j1.SelectToken("IT.mu");
                    Itemz._IT_Man_Item = mymu[0].ToString();
                }
                Itemz._IT_Animal = "0";
                if (j1.SelectToken("IT.an") != null && j1.SelectToken("IT.an").HasValues)
                {
                    JArray myan;
                    myan = (JArray)j1.SelectToken("IT.an");
                    Itemz._IT_Animal = myan[0].ToString();
                }
                Itemz._IT_Who_Has = 0;
                if (j1.SelectToken("IT.un") != null && j1.SelectToken("IT.un").HasValues)
                {
                    JArray myun;
                    myun = (JArray)j1.SelectToken("IT.un");
                    Itemz._IT_Who_Has = Convert.ToInt32(myun[0]);
                }
                Itemz._IM_Aura = 0;
                if (j1.SelectToken("IM.au") != null && j1.SelectToken("IM.au").HasValues)
                {
                    JArray myau;
                    myau = (JArray)j1.SelectToken("IM.au");
                    Itemz._IM_Aura = Convert.ToInt32(myau[0]);
                }
                Itemz._IM_Aura_Bonus = 0;
                if (j1.SelectToken("IM.ba") != null && j1.SelectToken("IM.ba").HasValues)
                {
                    JArray myba;
                    myba = (JArray)j1.SelectToken("IM.ba");
                    Itemz._IM_Aura_Bonus = Convert.ToInt32(myba[0]);
                }
                Itemz._IM_Attack_Bonus = 0;
                if (j1.SelectToken("IM.ab") != null && j1.SelectToken("IM.ab").HasValues)
                {
                    JArray myab;
                    myab = (JArray)j1.SelectToken("IM.ab");
                    Itemz._IM_Attack_Bonus = Convert.ToInt32(myab[0]);
                }
                Itemz._IM_Defense_Bonus = 0;
                if (j1.SelectToken("IM.db") != null && j1.SelectToken("IM.db").HasValues)
                {
                    JArray mydb;
                    mydb = (JArray)j1.SelectToken("IM.db");
                    Itemz._IM_Defense_Bonus = Convert.ToInt32(mydb[0]);
                }
                Itemz._IM_Missile_Bonus = 0;
                if (j1.SelectToken("IM.mb") != null && j1.SelectToken("IM.mb").HasValues)
                {
                    JArray mymb;
                    mymb = (JArray)j1.SelectToken("IM.mb");
                    Itemz._IM_Missile_Bonus = Convert.ToInt32(mymb[0]);
                }
                Itemz._IM_May_Study = 0;
                if (j1.SelectToken("IM.ms") != null && j1.SelectToken("IM.ms").HasValues)
                {
                    JArray myms;
                    myms = (JArray)j1.SelectToken("IM.ms");
                    Itemz._IM_May_Study = Convert.ToInt32(myms[0]);
                }
                Itemz._IM_Use_Key = 0;
                if (j1.SelectToken("IM.uk") != null && j1.SelectToken("IM.uk").HasValues)
                {
                    JArray myuk;
                    myuk = (JArray)j1.SelectToken("IM.uk");
                    Itemz._IM_Use_Key = Convert.ToInt32(myuk[0]);
                }
                Itemz._IM_Project_Cast = 0;
                if (j1.SelectToken("IM.pc") != null && j1.SelectToken("IM.pc").HasValues)
                {
                    JArray mypc;
                    mypc = (JArray)j1.SelectToken("IM.pc");
                    Itemz._IM_Project_Cast = Convert.ToInt32(mypc[0]);
                }
                Itemz._IM_Lore = 0;
                if (j1.SelectToken("IM.lo") != null && j1.SelectToken("IM.lo").HasValues)
                {
                    JArray mylo;
                    mylo = (JArray)j1.SelectToken("IM.lo");
                    Itemz._IM_Lore = Convert.ToInt32(mylo[0]);
                }
                Itemz._PL_Unit = 0;
                if (j1.SelectToken("PL.un") != null && j1.SelectToken("PL.un").HasValues)
                {
                    JArray myun;
                    myun = (JArray)j1.SelectToken("PL.un");
                    Itemz._PL_Unit = Convert.ToInt32(myun[0]);
                }
            }
        }
        public static string Determine_Use (Itemz _myitem)
        {
            //if (_myitem._Item_Type.Equals("0"))
            //{
            //    return "";
            //}
            if (_myitem._Item_Type.Equals("0"))
            {
                if (_myitem._IM_Use_Key != 0)
                {
                    if (_myitem._IM_Use_Key.Equals(1))
                    {
                        return "death potion";
                    }
                    if (_myitem._IM_Use_Key.Equals(2))
                    {
                        return "healing potion";
                    }
                    if (_myitem._IM_Use_Key.Equals(3))
                    {
                        return "slave potion";
                    }
                    if (_myitem._IM_Use_Key.Equals(4))
                    {
                        return "palantir";
                    }
                    if (_myitem._IM_Use_Key.Equals(5))
                    {
                        StringBuilder outline = new StringBuilder();
                        outline.Append("projected cast potion");
                        if (_myitem._IM_Project_Cast != 0)
                        {
                            Location _myloc = Program._locations.Find(x=>x._LocId == _myitem._IM_Project_Cast);
                            if (_myloc != null)
                            {
                                outline.Append(", " + _myloc._Name + " " + Utilities.format_anchor( _myloc._LocId_Conv) );
                            }
                            else
                            {
                                Ship _myship = Program._ships.Find(x => x._ShipId == _myitem._IM_Project_Cast);
                                if (_myship != null)
                                {
                                    outline.Append(", " + _myship._Name + " " + Utilities.format_anchor(_myship._ShipId.ToString()));
                                }
                                else
                                {
                                    outline.Append(", target [" + _myitem._IM_Project_Cast + "] no longer exists");
                                }
                            }
                        }
                        return outline.ToString();
                    }
                    if (_myitem._IM_Use_Key.Equals(6))
                    {
                        return "quick cast potion";
                    }
                    if (_myitem._IM_Use_Key.Equals(7))
                    {
                        // drum, nothing for now
                        return "";
                    }
                    if (_myitem._IM_Use_Key.Equals(8))
                    {
                        return "elf stone";
                    }
                    if (_myitem._IM_Use_Key.Equals(9))
                    {
                        return "orb";
                    }
                    return "undefined use: " + _myitem._IM_Use_Key;
                }
                else
                {
                    return "";
                }
            }
            if (_myitem._Item_Type.Equals("artifact"))
            {
                StringBuilder outline = new StringBuilder();
                if (_myitem._IM_Attack_Bonus != 0)
                {
                    if (outline.Length > 0)
                    {
                        outline.Append(", ");
                    }
                    outline.Append("attack +" + _myitem._IM_Attack_Bonus);
                }
                if (_myitem._IM_Defense_Bonus != 0)
                {
                    if (outline.Length > 0)
                    {
                        outline.Append(", ");
                    }
                    outline.Append("defense +" + _myitem._IM_Defense_Bonus);
                }
                if (_myitem._IM_Missile_Bonus != 0)
                {
                    if (outline.Length > 0)
                    {
                        outline.Append(", ");
                    }
                    outline.Append("missile +" + _myitem._IM_Missile_Bonus);
                }
                if (_myitem._IM_Aura_Bonus != 0)
                {
                    if (outline.Length > 0)
                    {
                        outline.Append(", ");
                    }
                    outline.Append("aura +" + _myitem._IM_Aura_Bonus);
                }
                return outline.ToString();
            }
            if (_myitem._Item_Type.Equals("dead body"))
            {
                Character _mychar = Program._characters.Find(x => x._CharId == _myitem._PL_Unit);
                if (_mychar != null)
                {
                    return ("Formerly known as: " + _mychar._Name + " [" + Utilities.format_anchor(_mychar._CharId.ToString()) + "]");
                }
                else
                {
                    return "dead, deader, deadest";
                }
            }
            if (_myitem._Item_Type.Equals("npc_token"))
            {
                if (_myitem._PL_Unit != 0)
                {
                    Character _mychar = Program._characters.Find(x => x._CharId == _myitem._PL_Unit);
                    if (_mychar != null)
                    {
                        return ("Controls: " + _mychar._Name + " " + Utilities.format_anchor(_mychar._CharId.ToString()));
                    }
                    else
                    {
                        return "undefined";
                    }
                }
                else
                {
                    return "undefined";
                }
            }
            if (_myitem._Item_Type.Equals("auraculum"))
            {
                return "aura: " + _myitem._IM_Aura;
            }
            if (_myitem._Item_Type.Equals("scroll"))
            {
                Skill _myskill = Program._skills.Find(x => x._SkillId == _myitem._IM_May_Study);
                if (_myskill != null)
                {
                    return "study: " + _myskill._Name + " [" + _myitem._IM_May_Study + "]";
                }
                else
                {
                    return "";
                }
            }
            if (_myitem._Item_Type.Equals("tradegood"))
            {
                StringBuilder outline = new StringBuilder();
                List<Location> _myloc = Program._locations.FindAll(x => x._Trade_List != null);
                if (_myloc != null)
                {
                    foreach (Location _myloctrade in _myloc)
                    {
                        int iterations = _myloctrade._Trade_List.Count / 8;
                        for (int i = 0; i < iterations; i++)
                        {
                            if ((_myloctrade._Trade_List[(i * 8) + 1]) == _myitem._ItemId.ToString())
                            {
                                if (_myloctrade._Trade_List[(i * 8) + 0] == "1" || _myloctrade._Trade_List[(i * 8) + 0] == "2")
                                {
                                    if (_myloctrade._Trade_List[(i * 8) + 0] == "1")
                                    {
                                        if (outline.Length > 0)
                                        {
                                            outline.Append(", ");
                                        }
                                        outline.Append("buy: " + _myloctrade._Name + " " + Utilities.format_anchor(_myloctrade._LocId_Conv));
                                    }
                                    if (_myloctrade._Trade_List[(i * 8) + 0] == "2")
                                    {
                                        if (outline.Length > 0)
                                        {
                                            outline.Append(", ");
                                        }
                                        outline.Append("sell: " + _myloctrade._Name + " " + Utilities.format_anchor(_myloctrade._LocId_Conv));
                                    }
                                }
                            }
                        }
                    }
                    if (outline.Length > 0)
                    {
                        return outline.ToString();
                    }
                    else
                    {
                        return "inactive";
                    }
                }
                else
                {
                    return "";
                }
            }
            return "";
        }
    }
}
