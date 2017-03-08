﻿using Newtonsoft.Json;
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
        public List<int> _LI_Here_List { get; set; }
        public List<int> _LO_Province_Destination { get; set; }
        public int _LO_Hidden { get; set; }
        public int _LO_Shrouded { get; set; }
        public int _LO_Barrier { get; set; }
        public int _LO_Civ_Level { get; set; }
        public int _SL_Safe { get; set; }
        public int _SL_Shaft_Depth { get; set; }
        public int _SL_Damage { get; set; }
        public int _SL_Defense { get; set; }
        public int _SL_Castle_Level { get; set; }
        public int _SL_Capacity { get; set; }
        public int _SL_Moving { get; set; }
        public List<int> _SL_Teaches { get; set; }
        public int _SL_Effort_Required { get; set; }
        public int _SL_Effort_Given { get; set; }
        public List<int> _SL_Near_Cities { get; set; }
        public int _SL_Building_Materials { get; set; }
        public string _Name { get; set; }
        public string _Loc_Type { get; set; }
        public List<int> _Item_List { get; set; }
        public string _First_Line { get; set; }
        public List<int> _Trade_List { get; set; }
        public string _castle_id { get; set; }
        public int _Region_id { get; set; }
        public int _nbr_men { get; set; }
        public bool _ships_found { get; set; }
        public bool _enemy_found { get; set; }
        public string Calc_CurrentLoc { get; set; }
        public int Calc_CurrentRegion { get; set; }
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
            string myloctype;
            if (j1.SelectToken("firstline") != null && j1.SelectToken("firstline").HasValues)
            {
                myfl = (JArray)j1.SelectToken("firstline");
                string[] type_array = myfl[0].ToString().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                myloctype = type_array[2];
                if (type_array.Count() > 3)
                {
                    for (int i = 0; i < (type_array.Count() - 3); i++)
                    {
                        myloctype += " " + type_array[3 + i];
                    }
                }
            }
            else
            {
                myfl = null;
                myloctype = null;
            }
            Program._locations.Add(new Location
            {
                _LocId = Convert.ToInt32(InputKey),
                _LocId_Conv = Utilities.to_oid(InputKey),
                _First_Line = myfl[0].ToString(),
                _Loc_Type = myloctype,
                _Name = myna[0].ToString(),
                _Item_List = JSON.list_Token(j1,"il"),
                _Trade_List = JSON.list_Token(j1, "tl"),
                _nbr_men = 0,
                _LI_Here_List = JSON.list_Token(j1, "LI.hl"),
                _LI_Where = JSON.int_Token(j1, "LI.wh"),
                _LO_Barrier = JSON.int_Token(j1, "LO.ba"),
                _LO_Hidden = JSON.int_Token(j1, "LO.hi"),
                _LO_Civ_Level = JSON.int_Token(j1, "LO.lc"),
                _LO_Province_Destination = JSON.list_Token(j1, "LO.pd"),
                _LO_Shrouded = JSON.int_Token(j1, "LO.sh"), 
                _SL_Building_Materials = JSON.int_Token(j1, "SL.bm"),
                _SL_Capacity = JSON.int_Token(j1, "SL.ca"),
                _SL_Castle_Level = JSON.int_Token(j1, "SL.cl"),
                _SL_Damage = JSON.int_Token(j1, "SL.da"),
                _SL_Defense = JSON.int_Token(j1, "SL.de"),
                _SL_Effort_Given = JSON.int_Token(j1, "SL.eg"),
                _SL_Effort_Required = JSON.int_Token(j1, "SL.er"),
                _SL_Moving = JSON.int_Token(j1, "SL.mo"),
                _SL_Near_Cities = JSON.list_Token(j1, "SL.nc"),
                _SL_Safe = JSON.int_Token(j1, "SL.sh"),
                _SL_Shaft_Depth = JSON.int_Token(j1, "SL.sd"),
                _SL_Teaches = JSON.list_Token(j1, "SL.te")
            });
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
            foreach(Character mychar in Program._characters)
            {
                CurrentLocation mycurrloc = new CurrentLocation();
                mycurrloc._current_loctype = 0;
                CurrentLocation myfinalcurrloc = CurrentLocation.Where_Am_I(mychar._CharId, mycurrloc);
                mychar.Calc_CurrentLoc = myfinalcurrloc._current_loc;
                mychar.Calc_CurrentRegion = myfinalcurrloc._current_region;
            }
            foreach (Ship myship in Program._ships)
            {
                CurrentLocation mycurrloc = new CurrentLocation();
                CurrentLocation myfinalcurrloc = CurrentLocation.Where_Am_I(myship._ShipId, mycurrloc);
                myship.Calc_CurrentLoc = myfinalcurrloc._current_loc;
                myship.Calc_CurrentRegion = myfinalcurrloc._current_region;
            }
            foreach (Location myloc in Program._locations.Where(c=>c._LocId != 0 && !c._Loc_Type.Equals("region")))
            {
                CurrentLocation mycurrloc = new CurrentLocation();
                CurrentLocation myfinalcurrloc = CurrentLocation.Where_Am_I(myloc._LocId, mycurrloc);
                myloc.Calc_CurrentLoc = myfinalcurrloc._current_loc;
                myloc.Calc_CurrentRegion = myfinalcurrloc._current_region;
                //if (myloc._LI_Where != 0)
                //{
                //    Console.WriteLine(myloc._LocId_Conv + " = " + Program._locations.Find(k => k._LocId == myloc._LI_Where)._Name);
                //}
            }
            // not sure what to do about this
            foreach (Location _myloc in Program._locations)
            {
                var return_tuple = new Tuple<int, bool, bool>(_myloc._nbr_men, _myloc._ships_found, _myloc._enemy_found);
                return_tuple = Count_Process_Loc(_myloc._nbr_men, _myloc, _myloc._ships_found, _myloc._enemy_found);
                _myloc._nbr_men = return_tuple.Item1;
                _myloc._ships_found = return_tuple.Item2;
                _myloc._enemy_found = return_tuple.Item3;
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
                foreach (int _hereid in province._LI_Here_List)
                {
                    Character garr = Program._characters.Find(z => z._CharId == _hereid);
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
        private static Tuple <int, bool, bool> Count_Process_Loc(int nbr_men, Location _myloc, bool shipsfound, bool enemyfound)
        {
            var return_tuple = new Tuple<int, bool, bool>(nbr_men, shipsfound, enemyfound);
            if (_myloc._LI_Here_List != null)
            {
                foreach (int _mylochere in _myloc._LI_Here_List)
                {
                    if (Program._characters.Find(x => x._CharId == _mylochere) != null)
                    {
                        return_tuple = Count_Process_Char(nbr_men, _mylochere, shipsfound, enemyfound);
                        nbr_men = return_tuple.Item1;
                        shipsfound = return_tuple.Item2;
                        enemyfound = return_tuple.Item3;
                    }
                    else
                    {
                        Ship _myship = Program._ships.Find(x => x._ShipId == Convert.ToInt32(_mylochere));
                        if (_myship != null)
                        {
                            shipsfound = true;
                            var temp_tuple = new Tuple<int, bool, bool>(nbr_men, shipsfound, enemyfound);
                            return_tuple = temp_tuple;
                            nbr_men = return_tuple.Item1;
                            shipsfound = return_tuple.Item2;
                            enemyfound = return_tuple.Item3;
                            if (_myship._LI_Here_List != null)
                            {
                                foreach (int _myshiphere in _myship._LI_Here_List)
                                {
                                    return_tuple = Count_Process_Char(nbr_men, _myshiphere, shipsfound, enemyfound);
                                    nbr_men = return_tuple.Item1;
                                    shipsfound = return_tuple.Item2;
                                    enemyfound = return_tuple.Item3;
                                }
                            }
                        }
                        else
                        {
                            if (Program._locations.Find(x => x._LocId == Convert.ToInt32(_mylochere)) != null)
                            {
                                Location _mylochere2 = Program._locations.Find(x => x._LocId == Convert.ToInt32(_mylochere));
                                return_tuple = Count_Process_Loc(nbr_men, _mylochere2, shipsfound, enemyfound);
                                nbr_men = return_tuple.Item1;
                                shipsfound = return_tuple.Item2;
                                enemyfound = return_tuple.Item3;
                            }
                        }
                    }
                }
            }
            return return_tuple;
        }
        private static Tuple<int, bool, bool> Count_Process_Char(int nbr_men, int _mylochere, bool shipsfound, bool enemyfound)
        {
            var return_tuple = new Tuple<int, bool, bool>(nbr_men, shipsfound, enemyfound);
            Character _mychar = Program._characters.Find(x => x._CharId == _mylochere);
            if (_mychar._Item_List != null)
            {

                // ignore city garrison, but not stuff under them
                if (_mychar._Char_Type.Equals("garrison") && _mychar._LI_Where >= 56760 && _mychar._LI_Where <= 58759)
                { }
                else
                {
                    int iterations = _mychar._Item_List.Count / 2;
                    for (int i = 0; i < iterations; i++)
                    {
                        if (Program._items.Find(x => x._ItemId == _mychar._Item_List[(i * 2) + 0])._IT_Prominent == 1)
                        {
                            nbr_men += _mychar._Item_List[(i * 2) + 1];
                        }
                    }
                    if (Program._players.Find(x=>x._FactionId == _mychar._PlayerId)._FactionId_Conv.Equals("100"))
                    {
                        enemyfound = true;
                    }
                }
                var temp_tuple = new Tuple<int, bool, bool>(nbr_men, shipsfound, enemyfound);
                return_tuple = temp_tuple;
                nbr_men = return_tuple.Item1;
                shipsfound = return_tuple.Item2;
                enemyfound = return_tuple.Item3;
            }
            // see if other characters stacked under
            if (_mychar._LI_Here_List != null)
            {
                foreach (int _mycharhere in _mychar._LI_Here_List)
                {
                    return_tuple = Count_Process_Char(nbr_men, _mycharhere, shipsfound, enemyfound);
                    nbr_men = return_tuple.Item1;
                    shipsfound = return_tuple.Item2;
                    enemyfound = return_tuple.Item3;
                }
            }
            return return_tuple;
        }
    } 
}
