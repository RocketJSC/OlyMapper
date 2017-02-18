using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace OlyMapper
{
    public class Program
    {
        internal static List<Location> _locations { get; private set; }
        internal static List<Player> _players { get; private set; }
        internal static List<Character> _characters { get; private set; }
        internal static List<Itemz> _items { get; private set; }
        internal static List<Skill> _skills { get; private set; }
        internal static List<Ship> _ships { get; private set; }
        internal static List<Storm> _storms { get; private set; }

        //List<Location> _locations { get; set; }
        public static void Main(string[] args)
        {
            _locations = new List<Location>();
            Program._locations.Add(new Location
            {
                _LocId = 0,
                _LocId_Conv = "0",
                _Loc_Type = "",
                _First_Line = ""
            });
            Console.WriteLine("Reading JSON file.");
            _players = new List<Player>();
            _items = new List<Itemz>();
            _characters = new List<Character>();
            _skills = new List<Skill>();
            _ships = new List<Ship>();
            _storms = new List<Storm>();
            JObject o1 = JObject.Parse(File.ReadAllText(@"d:\temp\lib-162.json"));
            Process_JSON_File(o1);
            // Display totals
            Console.WriteLine("+ Loaded " + _locations.Count + " locations");
            Console.WriteLine("+ Loaded " + _items.Count + " items");
            Console.WriteLine("+ Loaded " + _characters.Count + " characters");
            Console.WriteLine("+ Loaded " + _players.Count + " players");
            Console.WriteLine("+ Loaded " + _skills.Count + " skills");
            Console.WriteLine("+ Loaded " + _storms.Count + " storms");
            Console.WriteLine("+ Loaded " + _ships.Count + " ships");
            // sort lists
            Console.WriteLine("Sorting lists.");
            Program._players.Sort((x, y) => x._FactionId.CompareTo(y._FactionId));
            // identify port cities
            Console.WriteLine("Identifying port cities.");
            Location.Identify_Port_Cities();
            // post playerid to character
            Console.WriteLine("Posting player ids to characters.");
            Character.Post_PlayerId();
            // post playerid to character
            Console.WriteLine("Posting weight to characters.");
            Character.Calculate_Weight();
            // create directory for html files, if needed
            DirectoryInfo di = Directory.CreateDirectory(@"d:\Temp\turn162");
            Console.WriteLine("File Cleanup.");
            // delete existing files in directory
            System.IO.DirectoryInfo dd = new DirectoryInfo(@"d:\Temp\turn162");
            foreach (FileInfo file in dd.GetFiles())
            {
                if ((file.Name != "grey.gif") && (file.Name != "map.css") && (file.Name != "map.gif"))
                {
                    file.Delete();
                }
            }
            Console.WriteLine("Writing Province HTML pages.");
            Generate_Province_Pages();
            Console.WriteLine("Writing City HTML pages.");
            Generate_City_Pages();
            Console.WriteLine("Writing Sublocation HTML pages.");
            Generate_Sublocation_Pages();
            Console.WriteLine("Writing Character HTML pages.");
            Generate_Char_Pages();
            Console.WriteLine("Writing Ship HTML pages.");
            Generate_Ship_Pages();
            Console.WriteLine("Writing Glue HTML pages.");
            Generate_Glue_Pages();
            Console.WriteLine("Program Finished.  Press <ENTER> to Close.");
            Console.ReadLine();
        }

        private static void Generate_Province_Pages()
        {
            foreach (Location _myloc in _locations.FindAll(x => x._LocId >= 10000 && x._LocId <= 49999))
            {
                //
                if (_myloc._LocId != 0)
                {
                    if (_myloc._Loc_Type.Equals("sewer") || _myloc._Loc_Type.Equals("island"))
                    {
                        //not sure what to do yet
                    }
                    else
                    {
                        if (_myloc._Loc_Type.Equals("region"))
                        {
                            //Write_Region_HTML_File(_myloc);
                        }
                        else
                        {
                            if (_myloc._SL_Capacity.CompareTo(0) > 0 || _myloc._SL_Defense.CompareTo(0) > 0 || _myloc._SL_Effort_Required.CompareTo(0) > 0)
                            {
                                //Write_Subloc_HTML_File(_myloc);
                            }
                            else
                            {
                                if (!_myloc._Loc_Type.Equals("region"))
                                {
                                    HTML.Write_Loc_HTML_File(_myloc);
                                }
                                else
                                {
                                    Console.WriteLine(_myloc._LocId + " | " + _myloc._LocId_Conv + "|" + _myloc._Name + "|" + _myloc._Loc_Type + "|" + _myloc._First_Line);
                                }
                            }
                        }
                    }
                }
            }
        }
        private static void Generate_City_Pages()
        {
            foreach (Location _myloc in _locations.FindAll(x => x._LocId >= 56760 && x._LocId <= 58759))
            {
                //
                if (_myloc._LocId != 0)
                {
                    if (_myloc._Loc_Type.Equals("sewer") || _myloc._Loc_Type.Equals("island"))
                    {
                        //not sure what to do yet
                    }
                    else
                    {
                        if (_myloc._Loc_Type.Equals("region"))
                        {
                            //Write_Region_HTML_File(_myloc);
                        }
                        else
                        {
                            if (_myloc._SL_Capacity.CompareTo(0) > 0 || _myloc._SL_Defense.CompareTo(0) > 0 || _myloc._SL_Effort_Required.CompareTo(0) > 0)
                            {
                                //Write_Subloc_HTML_File(_myloc);
                            }
                            else
                            {
                                if (!_myloc._Loc_Type.Equals("region"))
                                {
                                    HTML.Write_Loc_HTML_File(_myloc);
                                }
                                else
                                {
                                    Console.WriteLine(_myloc._LocId + " | " + _myloc._LocId_Conv + "|" + _myloc._Name + "|" + _myloc._Loc_Type + "|" + _myloc._First_Line);
                                }
                            }
                        }
                    }
                }
            }
        }
        private static void Generate_Sublocation_Pages()
        {
            foreach (Location _myloc in _locations.FindAll(x => x._LocId >= 59000 && x._LocId <= 78999))
            {
                //
                if (_myloc._LocId != 0)
                {
                    if (_myloc._Loc_Type.Equals("sewer") || _myloc._Loc_Type.Equals("island"))
                    {
                        //not sure what to do yet
                    }
                    else
                    {
                        if (_myloc._Loc_Type.Equals("region"))
                        {
                            //Write_Region_HTML_File(_myloc);
                        }
                        else
                        {
                            if (_myloc._SL_Capacity.CompareTo(0) > 0 || _myloc._SL_Defense.CompareTo(0) > 0 || _myloc._SL_Effort_Required.CompareTo(0) > 0)
                            {
                                //Write_Subloc_HTML_File(_myloc);
                            }
                            else
                            {
                                if (!_myloc._Loc_Type.Equals("region"))
                                {
                                    HTML.Write_Loc_HTML_File(_myloc);
                                }
                                else
                                {
                                    Console.WriteLine(_myloc._LocId + " | " + _myloc._LocId_Conv + "|" + _myloc._Name + "|" + _myloc._Loc_Type + "|" + _myloc._First_Line);
                                }
                            }
                        }
                    }
                }
            }
        }
        private static void Generate_Char_Pages()
        {
            foreach (Character _mychar in _characters)
            {
                if (_mychar._CharId != 0)
                {
                    if (!_mychar._Char_Type.Contains("garr"))
                    {
                        HTML.Write_Char_HTML_File(_mychar);
                    }
                    else
                    {
                        // we'll get garrisons later
                    }
                }
            }
        }
        private static void Generate_Ship_Pages()
        {
            foreach (Ship _myship in _ships)
            {
                if (_myship._ShipId != 0)
                {
                    HTML.Write_Ship_HTML_File(_myship);
                }
            }
        }
        private static void Process_JSON_File(JObject o1)
        {
            foreach (JToken child in o1.Children())
            {
                String var1 = child.First.SelectToken("firstline").ToString();
                if (var1.Trim() != "")
                {
                    if (var1.ToString().ToLower().Trim().Contains("player") == true)
                    {
                        String var2 = child.First.ToString();
                        Player.Add(child.Path, var2);
                    }
                    else
                    {
                        if (var1.ToString().ToLower().Trim().Contains("loc") == true)
                        {
                            //Console.WriteLine("loc" + " " + child1.Value);
                            String var2 = child.First.ToString();
                            Location.Add(child.Path, var2);
                        }
                        else
                        {
                            if (var1.ToString().ToLower().Trim().Contains("char") == true)
                            {
                                //Console.WriteLine("char" + " " + child1.Value);
                                String var2 = child.First.ToString();
                                Character.Add(child.Path, var2);
                            }
                            else
                            {
                                if (var1.ToString().ToLower().Trim().Contains("item") == true)
                                {
                                    String var2 = child.First.ToString();
                                    Itemz.Add(child.Path, var2);
                                }
                                else
                                {
                                    if (var1.ToString().ToLower().Trim().Contains("ship") == true)
                                    {
                                        String var2 = child.First.ToString();
                                        Ship.Add(child.Path, var2);
                                    }
                                    else
                                    {
                                        if (var1.ToString().ToLower().Trim().Contains("unform") == true)
                                        {
                                            //String var2 = child.First.ToString();
                                            //Console.WriteLine(child.Path + "|" + var2);
                                        }
                                        else
                                        {
                                            if (var1.ToString().ToLower().Trim().Contains("storm") == true)
                                            {
                                                String var2 = child.First.ToString();
                                                Storm.Add(child.Path, var2);
                                            }
                                            else
                                            {
                                                if (var1.ToString().ToLower().Trim().Contains("skill") == true)
                                                {
                                                    String var2 = child.First.ToString();
                                                    Skill.Add(child.Path, var2);
                                                }
                                                else
                                                {
                                                    if (var1.ToString().ToLower().Trim().Contains("lore") == true)
                                                    {
                                                        //String var2 = child.First.ToString();
                                                        //Console.WriteLine(child.Path + "|" + var2);
                                                    }
                                                    else
                                                    {
                                                        String var2 = child.First.ToString();
                                                        Console.WriteLine("Unknown: " + child.Path + "|" + var2);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //Console.WriteLine(child1.Name + " " + child1.Value);
                }
            }
        }
        private static void Generate_Glue_Pages()
        {
            HTML.Write_Home_HTML_File();
            HTML.Write_Main_Map_HTML_File();
            Console.WriteLine(".Writing Main Map Leaves HTML pages.");
            HTML.Write_Main_Map_Leaves_HTML_File();
            Console.WriteLine(".Writing Faery Map Leaves HTML pages.");
            HTML.Write_Faery_Map_Leaves_HTML_File();
            Console.WriteLine(".Writing Hades Map Leaves HTML pages.");
            HTML.Write_Hades_Map_Leaves_HTML_File();
        }
    }
}
