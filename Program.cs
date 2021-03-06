﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using OlyCommonClasses;
using System.Linq;

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
            Console.Write("Enter turn: ");
            //int number;
            string input = Console.ReadLine();
            if (!Int32.TryParse(input, out int number))
            {
                Console.WriteLine("** Invalid  Turn Number ({0}) **", number);
                Console.ReadLine();
                return;
            }
            string path = "turn" + number;
            Console.WriteLine("Attempting to read JSON file: " + @"lib-" + number + ".json");
            _players = new List<Player>();
            _items = new List<Itemz>();
            _characters = new List<Character>();
            _skills = new List<Skill>();
            _ships = new List<Ship>();
            _storms = new List<Storm>();
            JObject o1;
            try
            {
                o1 = JObject.Parse(File.ReadAllText(@"lib-" + number + ".json"));
            }
            catch (JsonReaderException jex)
            {
                Console.WriteLine("** Unable to Parse JSON File ({0}) **", (@"lib-" + number + ".json"));
                Console.WriteLine(jex.Message);
                Console.ReadLine();
                return;
            }
            catch (JsonException jex)
            {
                Console.WriteLine("** Unable to handle JSON File ({0}) **", (@"lib-" + number + ".json"));
                Console.WriteLine(jex.Message);
                Console.ReadLine();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("** Unable to read JSON File ({0}) **", (@"lib-" + number + ".json"));
                Console.WriteLine(ex.Message);
                Console.WriteLine("Attempting to read JSON file: " + @"lib-next-" + number + ".json");
                try
                {
                    o1 = JObject.Parse(File.ReadAllText(@"lib-next-" + number + ".json"));
                }
                catch (JsonReaderException jex)
                {
                    Console.WriteLine("** Unable to Parse JSON File ({0}) **", (@"lib-next-" + number + ".json"));
                    Console.WriteLine(jex.Message);
                    Console.ReadLine();
                    return;
                }
                catch (JsonException jex)
                {
                    Console.WriteLine("** Unable to handle JSON File ({0}) **", (@"lib-next-" + number + ".json"));
                    Console.WriteLine(jex.Message);
                    Console.ReadLine();
                    return;
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("** Unable to read JSON File ({0}) **", (@"lib-next-" + number + ".json"));
                    Console.WriteLine(ex2.Message);
                    Console.ReadLine();
                    return;
                }
            }
            Process_JSON_File(o1, _characters, _items, _locations, _players, _ships, _skills, _storms);
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
            _players.Sort((x, y) => x._FactionId.CompareTo(y._FactionId));
            // identify port cities
            Console.WriteLine("Identifying port cities.");
            Location.Identify_Port_Cities(_locations);
            // post playerid to character
            Console.WriteLine("Posting player ids to characters.");
            Character.Post_PlayerId(_characters, _players);
            // post playerid to character
            Console.WriteLine("Posting weight to characters.");
            Character.Determine_Ultimate_Lord(_characters);
            // posting region to locations
            Console.WriteLine("Posting region to locations.");
            Location.Set_Region(_characters, _items, _locations, _players, _ships);
            // assign castle indicator
            Console.WriteLine("Posting indicator to castle.");
            Location.Castle_Indicator(_locations);
            Console.WriteLine("Loading Trade Xref.");
            // create tradexref data sturcture
            List<TradeXref> _TradeXref_Unsorted = Load_Tradexref_DataSturucture();
            // create directory for html files, if needed
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("File Cleanup.");
            // delete existing files in directory
            Cleanup_Files(path);
            // copy css and gif files to new directory if needed
            Console.WriteLine("Copying critical support files.");
            Copy_Critical_Files(path);
            Console.WriteLine("Writing HTML pages.");
            // dump items
            Console.WriteLine("+ Writing Master Item List HTML page.");
            HTML_Item.Generate_Item_List_HTML(path, _characters, _items, _locations, _ships, _skills);
            Console.WriteLine("+ Writing Master Healing Potion List HTML page.");
            HTML_Item.Generate_Healing_Potion_List_HTML(path, _characters, _items, _locations, _ships, _skills);
            Console.WriteLine("+ Writing Master Project Cast Potion List HTML page.");
            HTML_Item.Generate_Projected_Cast_Potion_List_HTML(path, _characters, _items, _locations, _ships, _skills);
            Console.WriteLine("+ Writing Master Orb List HTML page.");
            HTML_Item.Generate_Orb_List_HTML(path, _characters, _items);
            // dump players
            Console.WriteLine("+ Writing Master Player HTML page.");
            HTML.Generate_Player_List_HTML(path, _players);
            // dump ships
            Console.WriteLine("+ Writing Master Ship HTML page.");
            HTML.Generate_Ship_List_HTML(path, _characters, _items, _locations, _ships, _storms);
            // dump skills
            Console.WriteLine("+ Writing Master Skill Xref HTML page.");
            HTML.Generate_Skill_Xref_List_HTML(path, _locations, _skills);
            // dump trades
            Console.WriteLine("+ Writing Master Trade HTML pages.");
            HTML.Generate_Trade_List_HTML(path, _characters, _items, _locations, _TradeXref_Unsorted);
            Console.WriteLine("+ Writing Province HTML pages.");
            Generate_Province_Pages(path, _characters, _items, _locations, _ships, _TradeXref_Unsorted);
            Console.WriteLine("+ Writing City HTML pages.");
            Generate_City_Pages(path, _characters, _items, _locations, _ships, _TradeXref_Unsorted);
            Console.WriteLine("+ Writing Sublocation HTML pages.");
            Generate_Sublocation_Pages(path, _characters, _items, _locations, _ships, _TradeXref_Unsorted);
            Console.WriteLine("+ Writing Structure HTML pages.");
            Generate_Structure_Pages(path, _TradeXref_Unsorted);
            Console.WriteLine("+ Writing Character HTML pages.");
            Generate_Char_Pages(path);
            Console.WriteLine("+ Writing Ship HTML pages.");
            Generate_Ship_Pages(path);
            Console.WriteLine("Writing Glue HTML pages.");
            Generate_Glue_Pages(path);
            Console.WriteLine("Writing Faction Accept/Admit Files.");
            Resources.Generate_Admit_Accept_Faction_Files(path, _characters, _locations, _players, _ships);
            Console.WriteLine("Program Finished.  Press <ENTER> to Close.");
            Console.ReadLine();
        }

        private static List<TradeXref> Load_Tradexref_DataSturucture()
        {
            List<TradeXref> _TradeXref_Unsorted = new List<TradeXref>();
            foreach (Location _location in _locations.Where(f => f._Trade_List != null))
            {
                TradeXref.Load_Sells(_location, null, _TradeXref_Unsorted);
            }
            foreach (Location _location in _locations.Where(f => f._Trade_List != null))
            {
                TradeXref.Load_Buys(_location, null, _TradeXref_Unsorted);
            }
            return _TradeXref_Unsorted;
        }

        private static void Cleanup_Files(string path)
        {
            System.IO.DirectoryInfo dd = new DirectoryInfo(path);
            foreach (FileInfo file in dd.GetFiles())
            {
                //if ((file.Name != "grey.gif") && (file.Name != "map.css") && (file.Name != "map.gif"))
                //{
                    file.Delete();
                //}
            }
        }

        private static void Generate_Province_Pages(string path, List<Character> _characters, List<Itemz> _items, List<Location> _locations, List<Ship> _ships, List<TradeXref> _TradeXref_Unsorted)
        {
            foreach (Location _myloc in _locations.FindAll(x => x._LocId >= 10000 && x._LocId <= 49999))
            {
                HTML_Loc.Write_Loc_HTML_File(_myloc, path, _characters, _items, _locations, _players, _ships, _skills, _storms, _TradeXref_Unsorted);
            }
        }
        private static void Generate_City_Pages( string path, List<Character> _characters, List<Itemz> _items, List<Location> _locations, List<Ship> _ships, List<TradeXref> _tradexrefs)
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
                                    HTML_Loc.Write_Loc_HTML_File(_myloc, path, _characters, _items, _locations, _players, _ships, _skills, _storms, _tradexrefs);
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
        private static void Generate_Sublocation_Pages(string path, List<Character> _characters, List<Itemz> _items, List<Location> _locations, List<Ship> _ships, List<TradeXref> _tradexrefs)
        {
            foreach (Location _myloc in _locations.FindAll(x => x._LocId >= 59000 && x._LocId <= 78999))
            {
                //
                if (_myloc._LocId != 0)
                {
                    if (_myloc._Loc_Type.Equals("region"))
                    {
                        //Write_Region_HTML_File(_myloc);
                    }
                    else
                    {
                        if (!_myloc._Loc_Type.Equals("region"))
                        {
                            HTML_Loc.Write_Loc_HTML_File(_myloc, path, _characters, _items, _locations, _players, _ships, _skills, _storms, _tradexrefs);
                        }
                        else
                        {
                            Console.WriteLine(_myloc._LocId + " | " + _myloc._LocId_Conv + "|" + _myloc._Name + "|" + _myloc._Loc_Type + "|" + _myloc._First_Line);
                        }
                    }
                }
            }
        }
        private static void Generate_Structure_Pages(string path, List<TradeXref> _tradexrefs)
        {
            foreach (Location _myloc in _locations.FindAll(x => x._LocId > 0 && x._LocId <= 9999))
            {
                //
                if (_myloc._LocId != 0)
                {
                    HTML_Loc.Write_Loc_HTML_File(_myloc, path, _characters, _items, _locations, _players, _ships, _skills, _storms, _tradexrefs);
                }
            }
        }
        private static void Generate_Char_Pages(string path)
        {
            foreach (Character _mychar in _characters)
            {
                if (_mychar._CharId != 0)
                {
                    if (!_mychar._Char_Type.Contains("garr"))
                    {
                        HTML_Char.Write_Char_HTML_File(_mychar, path, _characters, _items, _locations, _ships, _skills);
                    }
                    else
                    {
                        HTML_Char.Write_Char_HTML_File(_mychar, path, _characters, _items, _locations, _ships, _skills);
                    }
                }
            }
        }
        private static void Generate_Ship_Pages(string path)
        {
            foreach (Ship _myship in _ships)
            {
                if (_myship._ShipId != 0)
                {
                    HTML_Ship.Write_Ship_HTML_File(_myship, path,_characters,_items, _locations,_ships, _storms);
                }
            }
        }
        private static void Process_JSON_File(JObject o1, List<Character> _characters, List<Itemz> _items, List<Location> _locations, List<Player> _players, List<Ship> _ships, List<Skill> _skills, List<Storm> _storms)
        {
            foreach (JToken child in o1.Children())
            {
                String var1 = child.First.SelectToken("firstline").ToString();
                if (var1.Trim() != "")
                {
                    if (var1.ToString().ToLower().Trim().Contains("player") == true)
                    {
                        String var2 = child.First.ToString();
                        Player.Add(child.Path, var2, _players);
                    }
                    else
                    {
                        if (var1.ToString().ToLower().Trim().Contains("loc") == true)
                        {
                            //Console.WriteLine("loc" + " " + child1.Value);
                            String var2 = child.First.ToString();
                            Location.Add(child.Path, var2, _locations);
                        }
                        else
                        {
                            if (var1.ToString().ToLower().Trim().Contains("char") == true)
                            {
                                //Console.WriteLine("char" + " " + child1.Value);
                                String var2 = child.First.ToString();
                                Character.Add(child.Path, var2, _characters);
                            }
                            else
                            {
                                if (var1.ToString().ToLower().Trim().Contains("item") == true)
                                {
                                    String var2 = child.First.ToString();
                                    Itemz.Add(child.Path, var2, _items);
                                }
                                else
                                {
                                    if (var1.ToString().ToLower().Trim().Contains("ship") == true)
                                    {
                                        String var2 = child.First.ToString();
                                        Ship.Add(child.Path, var2, _ships);
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
                                                Storm.Add(child.Path, var2, _storms);
                                            }
                                            else
                                            {
                                                if (var1.ToString().ToLower().Trim().Contains("skill") == true)
                                                {
                                                    String var2 = child.First.ToString();
                                                    Skill.Add(child.Path, var2, _skills);
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
        private static void Generate_Glue_Pages(string path)
        {
            HTML.Write_Index_HTML_File(path);
            HTML.Write_Main_Map_HTML_File(path);
            HTML.Write_Hades_Map_HTML_File(path);
            Console.WriteLine(".Writing Main Map Leaf HTML pages.");
            HTML.Write_Main_Map_Leaves_HTML_File(path, _characters, _locations);
            Console.WriteLine(".Writing Faery Map Leaf HTML pages.");
            HTML.Write_Faery_Map_Leaves_HTML_File(path, _locations);
            Console.WriteLine(".Writing Hades Map Leaf HTML pages.");
            HTML.Write_Hades_Map_Leaves_HTML_File(path, _locations);
        }
        public static void Copy_Critical_Files(string path)
        {
            if (!System.IO.File.Exists(System.IO.Path.Combine(path,"map.css")))
            {
                // copy map.css
                System.IO.File.Copy(System.IO.Path.Combine("", "map.css"), System.IO.Path.Combine(path,"map.css"),false);
            }
            if (!System.IO.File.Exists(System.IO.Path.Combine(path, "grey.gif")))
            {
                // copy map.css
                System.IO.File.Copy(System.IO.Path.Combine("", "grey.gif"), System.IO.Path.Combine(path, "grey.gif"), false);
            }
        }
    }
}
