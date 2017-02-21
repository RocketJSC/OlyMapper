using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OlyMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Location
    {
        public int _LocId { get; set; }
        public string _LocId_Conv { get; set; }
        public int _LI_Where { get; set; }
        //public List<string> _LI_Inner_Locations { get; set; }
        public List<string> _LI_Here_List { get; set; }
        public List<int> _LO_Province_Destination { get; set; }
        public string _LO_Hidden { get; set; }
        public string _LO_Shrouded { get; set; }
        public string _LO_Barrier { get; set; }
        public int _LO_Civ_Level { get; set; }
        public string _SL_Safe { get; set; }
        public string _SL_Shaft_Depth { get; set; }
        public int _SL_Damage { get; set; }
        public int _SL_Defense { get; set; }
        public string _SL_Castle_Level { get; set; }
        public int _SL_Capacity { get; set; }
        public string _SL_Moving { get; set; }
        public List<string> _SL_Teaches { get; set; }
        public int _SL_Effort_Required { get; set; }
        public int _SL_Effort_Given { get; set; }
        public List<string> _SL_Near_Cities { get; set; }
        public string _SL_Building_Materials { get; set; }
        public string _Name { get; set; }
        public string _Loc_Type { get; set; }
        public List<string> _Item_List { get; set; }
        public string _First_Line { get; set; }
        public List<string> _Trade_List { get; set; }
        public string _castle_id { get; set; }
        public int _Region_id { get; set; }
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
            string myloctypea;
            string myloctype;
            if (j1.SelectToken("firstline") != null && j1.SelectToken("firstline").HasValues)
            {
                myfl = (JArray)j1.SelectToken("firstline");
                myloctypea = myfl.ToString().Substring(myfl.ToString().IndexOf("loc ") + 4);
                myloctype = myloctypea.ToString().Substring(0, myloctypea.IndexOf("\""));
            }
            else
            {
                myfl = null;
                myloctypea = null;
                myloctype = null;
            }


            Program._locations.Add(new Location
            {
                _LocId = Convert.ToInt32(InputKey),
                _LocId_Conv = Utilities.to_oid(InputKey),
                _First_Line = myfl[0].ToString(),
                //_LI_Where = Convert.ToInt32(mywh[0].ToString()),
                //_LO_Province_Destination = mypda.ToList(),
                //_Item_List = myila.ToList(),
                _Loc_Type = myloctype,
                _Name = myna[0].ToString()
            });
            //foreach (var Location in Program._locations)
            var Location = (Program._locations.Find(x => x._LocId == Convert.ToInt32(InputKey)));
            if (Location != null)
            {
                if (Location._LocId.Equals(Convert.ToInt32(InputKey)))
                {
                    if (j1.SelectToken("LO.pd") != null && j1.SelectToken("LO.pd").HasValues)
                    {
                        JArray mypd;
                        mypd = (JArray)j1.SelectToken("LO.pd");
                        List<int> mypda;
                        mypda = mypd.ToObject<List<int>>();
                        Location._LO_Province_Destination = mypda.ToList();
                    }
                    if (j1.SelectToken("LO.hi") != null && j1.SelectToken("LO.hi").HasValues)
                    {
                        JArray myhi;
                        myhi = (JArray)j1.SelectToken("LO.hi");
                        Location._LO_Hidden = myhi[0].ToString();
                    }
                    if (j1.SelectToken("LO.sh") != null && j1.SelectToken("LO.sh").HasValues)
                    {
                        JArray mysh;
                        mysh = (JArray)j1.SelectToken("LO.sh");
                        Location._LO_Shrouded = mysh[0].ToString();
                    }
                    Location._LO_Civ_Level = 0;
                    if (j1.SelectToken("LO.lc") != null && j1.SelectToken("LO.lc").HasValues)
                    {
                        JArray mylc;
                        mylc = (JArray)j1.SelectToken("LO.lc");
                        Location._LO_Civ_Level = Convert.ToInt32(mylc[0]);
                    }
                    if (j1.SelectToken("LO.ba") != null && j1.SelectToken("LO.ba").HasValues)
                    {
                        JArray myba;
                        myba = (JArray)j1.SelectToken("LO.ba");
                        Location._LO_Barrier = myba[0].ToString();
                    }
                    if (j1.SelectToken("SL.sh") != null && j1.SelectToken("SL.sh").HasValues)
                    {
                        JArray mysh;
                        mysh = (JArray)j1.SelectToken("SL.sh");
                        Location._SL_Safe = mysh[0].ToString();
                    }
                    Location._SL_Damage = 0;
                    if (j1.SelectToken("SL.da") != null && j1.SelectToken("SL.da").HasValues)
                    {
                        JArray myda;
                        myda = (JArray)j1.SelectToken("SL.da");
                        Location._SL_Damage = Convert.ToInt32(myda[0]);
                    }
                    Location._SL_Defense = 0;
                    if (j1.SelectToken("SL.de") != null && j1.SelectToken("SL.de").HasValues)
                    {
                        JArray myde;
                        myde = (JArray)j1.SelectToken("SL.de");
                        Location._SL_Defense = Convert.ToInt32(myde[0]);
                    }
                    if (j1.SelectToken("SL.sd") != null && j1.SelectToken("SL.sd").HasValues)
                    {
                        JArray mysd;
                        mysd = (JArray)j1.SelectToken("SL.sd");
                        Location._SL_Shaft_Depth = mysd[0].ToString();
                    }
                    if (j1.SelectToken("SL.cl") != null && j1.SelectToken("SL.cl").HasValues)
                    {
                        JArray mycl;
                        mycl = (JArray)j1.SelectToken("SL.cl");
                        Location._SL_Castle_Level = mycl[0].ToString();
                    }
                    Location._SL_Capacity = 0;
                    if (j1.SelectToken("SL.ca") != null && j1.SelectToken("SL.ca").HasValues)
                    {
                        JArray myca;
                        myca = (JArray)j1.SelectToken("SL.ca");
                        Location._SL_Capacity = Convert.ToInt32(myca[0]);
                    }
                    if (j1.SelectToken("SL.mo") != null && j1.SelectToken("SL.mo").HasValues)
                    {
                        JArray mymo;
                        mymo = (JArray)j1.SelectToken("SL.mo");
                        Location._SL_Moving = mymo[0].ToString();
                    }
                    if (j1.SelectToken("SL.te") != null && j1.SelectToken("SL.te").HasValues)
                    {
                        JArray myte;
                        myte = (JArray)j1.SelectToken("SL.te");
                        List<string> mytea;
                        mytea = myte.ToObject<List<string>>();
                        Location._SL_Teaches = mytea.ToList();
                    }
                    Location._SL_Effort_Required = 0;
                    if (j1.SelectToken("SL.er") != null && j1.SelectToken("SL.er").HasValues)
                    {
                        JArray myer;
                        myer = (JArray)j1.SelectToken("SL.er");
                        Location._SL_Effort_Required = Convert.ToInt32(myer[0]);
                    }
                    Location._SL_Effort_Given = 0;
                    if (j1.SelectToken("SL.eg") != null && j1.SelectToken("SL.eg").HasValues)
                    {
                        JArray myeg;
                        myeg = (JArray)j1.SelectToken("SL.eg");
                        Location._SL_Effort_Given = Convert.ToInt32(myeg[0]);
                    }
                    else
                    if (j1.SelectToken("SL.bm") != null && j1.SelectToken("SL.bm").HasValues)
                    {
                        JArray mybm;
                        mybm = (JArray)j1.SelectToken("SL.bm");
                        Location._SL_Building_Materials = mybm[0].ToString();
                    }
                    if (j1.SelectToken("SL.nc") != null && j1.SelectToken("SL.nc").HasValues)
                    {
                        JArray mync;
                        mync = (JArray)j1.SelectToken("SL.nc");
                        List<string> mynca;
                        mynca = mync.ToObject<List<string>>();
                        Location._SL_Near_Cities = mynca.ToList();
                    }
                    Location._LI_Where = 0;
                    if (j1.SelectToken("LI.wh") != null && j1.SelectToken("LI.wh").HasValues)
                    {
                        JArray mywh;
                        mywh = (JArray)j1.SelectToken("LI.wh");
                        Location._LI_Where = Convert.ToInt32(mywh[0].ToString());
                    }
                    if (j1.SelectToken("LI.hl") != null && j1.SelectToken("LI.hl").HasValues)
                    {
                        JArray myhl;
                        List<string> myhla;
                        myhl = (JArray)j1.SelectToken("LI.hl");
                        myhla = myhl.ToObject<List<string>>();
                        Location._LI_Here_List = myhla.ToList();
                    }
                    if (j1.SelectToken("il") != null && j1.SelectToken("il").HasValues)
                    {
                        JArray myil;
                        List<string> myila;
                        myil = (JArray)j1.SelectToken("il");
                        myila = myil.ToObject<List<string>>();
                        Location._Item_List = myila.ToList();
                    }
                    if (j1.SelectToken("tl") != null && j1.SelectToken("tl").HasValues)
                    {
                        JArray mytl;
                        mytl = (JArray)j1.SelectToken("tl");
                        List<string> mytla;
                        mytla = mytl.ToObject<List<string>>();
                        Location._Trade_List = mytla.ToList();
                    }
                }
            }
        }
        public static void Identify_Port_Cities()
        {
            foreach (Location _location in Program._locations.FindAll(x => x._Loc_Type.Contains("city")))
            {
                if (!Program._locations.Find(x => x._LocId == _location._LI_Where)._Loc_Type.Contains("mountain"))
                {
                    Location _location2 = Program._locations.Find(x => x._LocId == _location._LI_Where);
                    if (Program._locations.Find(x => x._LocId == _location2._LO_Province_Destination[0])._Loc_Type.Contains("ocean") ||
                        Program._locations.Find(x => x._LocId == _location2._LO_Province_Destination[1])._Loc_Type.Contains("ocean") ||
                        Program._locations.Find(x => x._LocId == _location2._LO_Province_Destination[2])._Loc_Type.Contains("ocean") ||
                        Program._locations.Find(x => x._LocId == _location2._LO_Province_Destination[3])._Loc_Type.Contains("ocean"))
                    {
                        _location._Loc_Type = "port city";
                    }
                }
            }
        }
        public static void Set_Region()
        {
            foreach (Location _myloc in Program._locations)
            {
                if (_myloc._LI_Where != 0)
                {
                    Location _myloc2 = Program._locations.Find(x => x._LocId == _myloc._LI_Where);
                    if (_myloc2._Loc_Type.Equals("region"))
                    {
                        _myloc._Region_id = _myloc2._LocId;
                    }
                    else
                    {
                        Location _myloc3 = Program._locations.Find(x => x._LocId == _myloc2._LI_Where);
                        if (_myloc3._Loc_Type.Equals("region"))
                        {
                            _myloc._Region_id = _myloc3._LocId;
                        }
                        else
                        {
                            Location _myloc4 = Program._locations.Find(x => x._LocId == _myloc3._LI_Where);
                            if (_myloc4._Loc_Type.Equals("region"))
                            {
                                _myloc._Region_id = _myloc4._LocId;
                            }
                            else
                            {
                                Location _myloc5 = Program._locations.Find(x => x._LocId == _myloc4._LI_Where);
                                if (_myloc4._Loc_Type.Equals("region"))
                                {
                                    _myloc._Region_id = _myloc4._LocId;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void Castle_Indicator()
        {
            string[] indicators = new string[] { "!", "@", "#", "%", "^","*","-","+","~","=","a","b","c","d","e","f","g","h","j"};
            List<Location> mycastles = Program._locations.FindAll(x => x._Loc_Type.Equals("castle"));
            //Program._players.Sort((x, y) => x._FactionId.CompareTo(y._FactionId));
            mycastles.Sort((x,y) => x._Region_id.CompareTo(y._Region_id));
            int counter = 0;
            int saveregion = 0;
            foreach (Location castle in mycastles)
            {
                if (saveregion != castle._Region_id)
                {
                    counter = 0;
                    saveregion = castle._Region_id;
                    castle._castle_id = indicators[counter];
                    counter++;
                }
                else
                {
                    castle._castle_id = indicators[counter];
                    counter++;
                }
            }
        }
        public static string Return_CI(Location province)
        {
            if (province._LI_Here_List != null)
            {
                foreach (string _hereid in province._LI_Here_List)
                {
                    Character garr = Program._characters.Find(z => z._CharId == Convert.ToInt32(_hereid));
                    if (garr != null)
                    {
                        if (garr._Char_Type.Equals("garrison"))                    
                        {
                            return Program._locations.Find(y => y._LocId == garr._MI_Garrison_Castle)._castle_id;
                        }
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public static bool FiftyMen(Location _myloc)
        {
            int nbr_men = 0;
            if (_myloc._LI_Here_List != null)
            {
                foreach(string _mylochere in _myloc._LI_Here_List)
                {
                    
                    if (Program._characters.Find(x => x._CharId == Convert.ToInt32(_mylochere)) != null)
                    {
                        Character _mychar = Program._characters.Find(x => x._CharId == Convert.ToInt32(_mylochere));
                        int iterations = _mychar._Item_List.Count / 2;
                        for (int i = 0; i < iterations; i++)
                        {
                            if (Program._items.Find(x=>x._ItemId == _mychar._Item_List[(i * 2) + 0])._IT_Prominent == "1")
                            {
                                nbr_men += _mychar._Item_List[(i * 2) + 1];
                            }
                        }
                        // see if other characters stacked under
                        if (_mychar._LI_Here_List != null)
                        {
                            foreach (string _mycharhere in _mychar._LI_Here_List)
                            {
                                // call recursively
                            }
                        }
                    }
                    else
                    {
                        Ship _myship = Program._ships.Find(x=>x._ShipId == Convert.ToInt32(_myhere));
                        if (_myship != null)
                        {
                            if (_myship._LI_Here_List != null)
                            {

                            }
                        }
                    }
                }
            }
            if (nbr_men >= 50)
            {
                return true;
            }
            return false;
        }
    } 
}
