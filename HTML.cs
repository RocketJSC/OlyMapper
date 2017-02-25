using OlyMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class HTML
    {
        public static void Write_Home_HTML_File(string path)
        {
            using (FileStream fs = new FileStream(System.IO.Path.Combine(path,"home.html"), FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>Olympia Mapper Tool</TITLE>");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    w.WriteLine("<table>");
                    w.WriteLine("<tr>");
                    w.WriteLine("<th>");
                    w.WriteLine("<ul>Maps<br>");
                    w.WriteLine("<li><a href=\"main_map.html\">Main</a></li>");
                    w.WriteLine("<li>Hades</li>");
                    w.WriteLine("<li>Faery</li>");
                    w.WriteLine("</ul>");
                    w.WriteLine("</th>");
                    w.WriteLine("<th>");
                    w.WriteLine("<ul>Reports<br>");
                    w.WriteLine("<li><a href=\"master_item_list.html\">Items</a></li>");
                    w.WriteLine("<li><a href=\"master_player_list.html\">Players</a></li>");
                    w.WriteLine("<li>Characters</li>");
                    w.WriteLine("<li><a href=\"master_ship_list.html\">Ships</a></li>");
                    w.WriteLine("</ul>");
                    w.WriteLine("</th>");
                    w.WriteLine("<th>");
                    w.WriteLine("<ul>Links<br>");
                    w.WriteLine("<li><a href=\"http://shadowlandgames.com/olympia/rules.html\">Olympia Rules</a></li>");
                    w.WriteLine("<li><a href=\"http://shadowlandgames.com/olympia/orders.html\">Olympia Orders</a></li>");
                    w.WriteLine("<li><a href=\"http://shadowlandgames.com/olympia/skills.html\">Olympia Skills</a></li>");
                    w.WriteLine("</ul>");
                    w.WriteLine("</th>");
                    w.WriteLine("</tr>");
                    w.WriteLine("</table>");
                    w.WriteLine("</BODY>");
                    w.WriteLine("</HTML>");
                }
                fs.Close();
            }
        }
        public static void Write_Main_Map_HTML_File(string path )
        {
            using (FileStream fs = new FileStream(System.IO.Path.Combine(path, "main_map.html"), FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>Main Map</TITLE>");
                    w.WriteLine("<link href=\"map.css\" rel=\"stylesheet\" type=\"text/css\">");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    w.WriteLine("<h3>Olympia Main Map</h3>");
                    w.WriteLine ("<img height=\"320\" width=\"320\" src=\"map.gif\" usemap=\"#oly\" />");
                    w.WriteLine("<map name=\"oly\" id=\"oly\">");
                    w.WriteLine("<area shape=\"rect\" coords=\"0, 0, 60, 60\" href=\"main_map_leaf_aa00.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"60,0,100,60\" href=\"main_map_leaf_aa10.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"100,0,140,60\" href=\"main_map_leaf_aa20.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"140,0,180,60\" href=\"main_map_leaf_aa30.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"180,0,220,60\" href=\"main_map_leaf_aa40.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"220,0,260,60\" href=\"main_map_leaf_aa50.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"260,0,320,60\" href=\"main_map_leaf_aa60.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"0,60,60,100\" href=\"main_map_leaf_an00.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"60,60,100,100\" href=\"main_map_leaf_an10.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"100,60,140,100\" href=\"main_map_leaf_an20.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"140,60,180,100\" href=\"main_map_leaf_an30.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"180,60,220,100\" href=\"main_map_leaf_an40.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"220,60,260,100\" href=\"main_map_leaf_an50.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"260,60,320,100\" href=\"main_map_leaf_an60.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"0,100,60,140\" href=\"main_map_leaf_ba00.html\" />");
                     w.WriteLine("<area shape=\"rect\" coords=\"60,100,100,140\" href=\"main_map_leaf_ba10.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"100,100,140,140\" href=\"main_map_leaf_ba20.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"140,100,180,140\" href=\"main_map_leaf_ba30.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"180,100,220,140\" href=\"main_map_leaf_ba40.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"220,100,260,140\" href=\"main_map_leaf_ba50.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"260,100,320,140\" href=\"main_map_leaf_ba60.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"0,140,60,180\" href=\"main_map_leaf_bn00.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"60,140,100,180\" href=\"main_map_leaf_bn10.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"100,140,140,180\" href=\"main_map_leaf_bn20.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"140,140,180,180\" href=\"main_map_leaf_bn30.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"180,140,220,180\" href=\"main_map_leaf_bn40.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"220,140,260,180\" href=\"main_map_leaf_bn50.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"260,140,320,180\" href=\"main_map_leaf_bn60.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"0,180,60,220\" href=\"main_map_leaf_ca00.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"60,180,100,220\" href=\"main_map_leaf_ca10.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"100,180,140,220\" href=\"main_map_leaf_ca20.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"140,180,180,22\" href=\"main_map_leaf_ca30.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"180,180,220,220\" href=\"main_map_leaf_ca40.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"220,180,260,220\" href=\"main_map_leaf_ca50.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"260,180,320,220\" href=\"main_map_leaf_ca60.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"0,220,60,260\" href=\"main_map_leaf_cn00.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"60,220,100,260\" href=\"main_map_leaf_cn10.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"100,220,140,260\" href=\"main_map_leaf_cn20.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"140,220,180,260\" href=\"main_map_leaf_cn30.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"180,220,220,260\" href=\"main_map_leaf_cn40.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"220,220,260,260\" href=\"main_map_leaf_cn50.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"260,220,320,260\" href=\"main_map_leaf_cn60.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"0,260,60,320\" href=\"main_map_leaf_da00.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"60,260,100,320\" href=\"main_map_leaf_da10.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"100,260,140,320\" href=\"main_map_leaf_da20.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"140,260,180,320\" href=\"main_map_leaf_da30.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"180,260,220,320\" href=\"main_map_leaf_da40.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"220,260,260,320\" href=\"main_map_leaf_da50.html\" />");
                    w.WriteLine("<area shape=\"rect\" coords=\"260,260,320,320\" href=\"main_map_leaf_da60.html\" />");
                    w.WriteLine("</map>");
                    w.WriteLine("</BODY>");
                    w.WriteLine("</html>");
                }
                fs.Close();
            }
        }
        public static void Write_Main_Map_Leaves_HTML_File(string path)
        {
            int StartingPoint = 10000;
            int CurrentPoint;
            for (int outery = 0; outery < 7; outery++)
            {
                StartingPoint = 10000 + (outery * 1000);
                for (int outerx = 0; outerx < 7; outerx++)
                {
                    CurrentPoint = StartingPoint + (outerx * 10);
                    using (FileStream fs = new FileStream(System.IO.Path.Combine(path, "main_map_leaf_" + Utilities.to_oid(CurrentPoint.ToString()) + ".html"), FileMode.Create))
                    {
                        using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                        {
                            w.WriteLine("<HTML>");
                            w.WriteLine("<HEAD>");
                            w.WriteLine("<TITLE>Main Map Leaf " + Utilities.to_oid(CurrentPoint.ToString()) + "</TITLE>");
                            w.WriteLine("<link href=\"map.css\" rel=\"stylesheet\" type=\"text/css\">");
                            w.WriteLine("</HEAD>");
                            w.WriteLine("<BODY>");
                            w.WriteLine("<table>");
                            // determine nav
                            bool TopNav = false;
                            bool BotNav = false;
                            bool LeftNav = false;
                            bool RightNav = false;
                            bool UpperLeftNav = false;
                            bool UpperRightNav = false;
                            bool LowerLeftNav = false;
                            bool LowerRightNav = false;
                            if (CurrentPoint > 10099)
                            {
                                TopNav = true;
                            }
                            if (CurrentPoint < 16000)
                            {
                                BotNav = true;
                            }
                            int y1 = (CurrentPoint - 10000) % 100;
                            if ((y1 % 10) > 1 || (y1 / 10) > 0)
                            {
                                LeftNav = true;
                                if (TopNav)
                                {
                                    UpperLeftNav = true;
                                }
                                if (BotNav)
                                {
                                    LowerLeftNav = true;
                                }
                            }
                            if ((y1 % 10) > 1 || (y1 / 10) < 6)
                            {
                                RightNav = true;
                                if (TopNav)
                                {
                                    UpperRightNav = true;
                                }
                                if (BotNav)
                                {
                                    LowerRightNav = true;
                                }
                            }
                            //
                            if (TopNav)
                            {
                                // write top navigation
                                w.WriteLine("<tr>");
                                if (UpperLeftNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"main_map_leaf_" + Utilities.to_oid((CurrentPoint - 1010).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("<td colspan = \"20\" class=\"top\"><a href = \"main_map_leaf_" + Utilities.to_oid((CurrentPoint - 1000).ToString()) + ".html\"><img src=\"grey.gif\" width=\"840\" height=\"20\"></a></td>");
                                if (UpperRightNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"main_map_leaf_" + Utilities.to_oid((CurrentPoint - 990).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("</tr>");
                            }
                            for (int x = 0; x < 20; x++)
                            {
                                w.WriteLine("<tr>");
                                for (int y = 0; y < 20; y++)
                                {
                                    StringBuilder outline = new StringBuilder();
                                    // see if need left navigation
                                    if (x == 0 && y == 0)
                                    {
                                        if (LeftNav)
                                        {
                                            //<td rowspan="20" class="left"><a href="map_bc23.html"><img src="img/grey.gif" width="20" height="840"></a></td>
                                            StringBuilder outline2 = new StringBuilder();
                                            outline2.Append("<td rowspan=\"20\" class=\"left\">");
                                            outline2.Append("<a href=\"main_map_leaf_" + Utilities.to_oid((CurrentPoint - 10).ToString()) + ".html\">");
                                            outline2.Append("<img src=\"grey.gif\" width=\"20\" height=\"840\"></a></td>");
                                            w.WriteLine(outline2);
                                        }
                                    }
                                    int Cell = CurrentPoint + (x * 100) + (y);
                                    Location _myloc = Program._locations.Find(z => z._LocId == Cell);
                                    if (_myloc != null)
                                    {
                                        // determine if province has more than 50 men in it - set border to red
                                        if (_myloc._LO_Barrier > 0)
                                        {
                                            outline.Append("<td style=\"border: 2px solid purple\" ");
                                        }
                                        else
                                        {
                                            if (_myloc._nbr_men >= 50)
                                            {
                                                outline.Append("<td style=\"border: 2px solid red\" ");
                                            }
                                            else
                                            {
                                                if (_myloc._ships_found)
                                                {
                                                    outline.Append("<td style=\"border: 2px solid yellow\" ");
                                                }
                                                else
                                                {
                                                    if (_myloc._enemy_found)
                                                    {
                                                        outline.Append("<td style=\"border: 2px solid orange\" ");
                                                    }
                                                    else
                                                    {
                                                        outline.Append("<td ");
                                                    }
                                                }
                                            }
                                        }
                                        // write cell
                                        outline.Append("id=\"" + _myloc._LocId_Conv + "\" class =" + "\"");
                                        outline.Append(_myloc._Loc_Type + "\"" + ">");
                                        if (_myloc._LO_Civ_Level > 0)
                                        {
                                            outline.Append("<b>");
                                        }
                                        outline.Append(Utilities.format_anchor2(_myloc._LocId_Conv, _myloc._LocId_Conv));
                                        if (_myloc._LO_Civ_Level > 0)
                                        {
                                            outline.Append("</b>");
                                        }
                                        if (Location.Return_CI(_myloc) != null)
                                        {
                                            outline.Append(Location.Return_CI(_myloc));
                                        }
                                        if (_myloc._LI_Here_List != null)
                                        {
                                            //if (_myloc._LI_Here_List.Count > 0 && !_myloc._Loc_Type.Equals("ocean"))
                                            if (_myloc._LI_Here_List.Count > 0)
                                            {
                                                // >= 56760
                                                Location loc1 = null;
                                                Location loc2 = null;
                                                Location city = null;
                                                Location graveyard = null;
                                                int Count = 0;
                                                foreach (string _here_id in _myloc._LI_Here_List)
                                                {
                                                    if (Convert.ToInt32(_here_id) >= 56760 && Convert.ToInt32(_here_id) <= 78999)
                                                    {
                                                        Count++;
                                                        if (Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id))._Loc_Type.Contains("city"))
                                                        {
                                                            city = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id));
                                                        }
                                                        else
                                                        {
                                                            if (Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id))._Loc_Type.Contains("graveyard"))
                                                            {
                                                                graveyard = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id));
                                                            }
                                                            else
                                                            {
                                                                if (loc1 == null)
                                                                {
                                                                    loc1 = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id)); ;
                                                                }
                                                                else
                                                                {
                                                                    if (loc2 == null)
                                                                    {
                                                                        loc2 = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id));
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                if (city != null)
                                                {
                                                    if (loc2 == null)
                                                    {
                                                        loc2 = loc1;
                                                    }
                                                    loc1 = city;
                                                }
                                                if (graveyard != null)
                                                {
                                                    if (loc1 == null)
                                                    {
                                                        if (loc2 == null)
                                                        {
                                                            loc2 = loc1;
                                                        }
                                                        loc1 = graveyard;
                                                    }
                                                    else
                                                    {
                                                        if (loc2 == null)
                                                        {
                                                            loc2 = graveyard;
                                                        }
                                                    }
                                                }
                                                if (Count > 2)
                                                {
                                                    outline.Append("<br />many");
                                                }
                                                else
                                                {
                                                    if (loc2 != null)
                                                    {
                                                        if (loc2._Loc_Type.Contains("city") || loc2._Loc_Type.Equals("graveyard"))
                                                        {
                                                            outline.Append("<br />");
                                                            outline.Append(Utilities.format_anchor2(loc2._LocId_Conv,Utilities.format_loc_type(loc2._Loc_Type)));
                                                        }
                                                        else
                                                        {
                                                            outline.Append("<br />");
                                                            if (loc2._LO_Hidden != null)
                                                            {
                                                                if (loc2._LO_Hidden.Equals("1"))
                                                                {
                                                                    outline.Append("<i>");
                                                                }
                                                            }
                                                            outline.Append(Utilities.format_loc_type(loc2._Loc_Type));
                                                            if (loc2._LO_Hidden != null)
                                                            {
                                                                if (loc2._LO_Hidden.Equals("1"))
                                                                {
                                                                    outline.Append("</i>");
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        outline.Append("<br />&nbsp;");
                                                    }
                                                }
                                                if (loc1 != null)
                                                {
                                                    if (loc1._Loc_Type.Contains("city") || loc1._Loc_Type.Equals("graveyard"))
                                                    {
                                                        outline.Append("<br />");
                                                        outline.Append(Utilities.format_anchor2(loc1._LocId_Conv, Utilities.format_loc_type(loc1._Loc_Type)));
                                                    }
                                                    else
                                                    {
                                                        outline.Append("<br />");
                                                        if (loc1._LO_Hidden != null)
                                                        {
                                                            if (loc1._LO_Hidden.Equals("1"))
                                                            {
                                                                outline.Append("<i>");
                                                            }
                                                        }
                                                        outline.Append(Utilities.format_loc_type(loc1._Loc_Type));
                                                        if (loc1._LO_Hidden != null)
                                                        {
                                                            if (loc1._LO_Hidden.Equals("1"))
                                                            {
                                                                outline.Append("<i>");
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    outline.Append("<br />&nbsp;");
                                                }
                                                outline.Append("</td>");
                                            }
                                            else
                                            {
                                                outline.Append("<br />&nbsp;<br />&nbsp;");
                                                outline.Append("</td>");
                                            }
                                        }
                                        else
                                        {
                                            outline.Append("<br />&nbsp;<br />&nbsp;");
                                            outline.Append("</td>");
                                        }
                                    }
                                    else
                                    {
                                        // location not found in Location list
                                        outline.Append("<td id=\"" + Utilities.to_oid(Cell.ToString()) + "\" class=\"x_sea\">" + Utilities.to_oid(Cell.ToString()) + "</td>");
                                    }
                                    w.WriteLine(outline);
                                    // see if need right navigation
                                    if (x == 0 && y == 19)
                                    {
                                        if (RightNav)
                                        {
                                            //<td rowspan="20" class="left"><a href="map_bc23.html"><img src="img/grey.gif" width="20" height="840"></a></td>
                                            StringBuilder outline2 = new StringBuilder();
                                            outline2.Append("<td rowspan=\"20\" class=\"right\">");
                                            outline2.Append("<a href=\"main_map_leaf_" + Utilities.to_oid((CurrentPoint + 10).ToString()) + ".html\">");
                                            outline2.Append("<img src=\"grey.gif\" width=\"20\" height=\"840\"></a></td>");
                                            w.WriteLine(outline2);
                                        }
                                    }
                                }
                                w.WriteLine("</tr>");
                            }
                            if (BotNav)
                            {
                                // write top navigation
                                w.WriteLine("<tr>");
                                if (LowerLeftNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"main_map_leaf_" + Utilities.to_oid((CurrentPoint + 990).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("<td colspan = \"20\" class=\"bottom\"><a href = \"main_map_leaf_" + Utilities.to_oid((CurrentPoint + 1000).ToString()) + ".html\"><img src=\"grey.gif\" width=\"840\" height=\"20\"></a></td>");
                                if (LowerRightNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"main_map_leaf_" + Utilities.to_oid((CurrentPoint + 1010).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("</tr>");
                            }
                            w.WriteLine("</table>");
                            w.WriteLine("</BODY>");
                            w.WriteLine("</HTML>");
                        }
                        fs.Close();
                    }
                }
            }
        }
        public static void Write_Faery_Map_Leaves_HTML_File(string path)
        {
            int StartingPoint = 18000;
            int CurrentPoint;
            for (int outery = 0; outery < 7; outery++)
            {
                StartingPoint = 18000 + (outery * 1000);
                for (int outerx = 0; outerx < 7; outerx++)
                {
                    CurrentPoint = StartingPoint + (outerx * 10);
                    using (FileStream fs = new FileStream(System.IO.Path.Combine(path, "faery_map_leaf_" + Utilities.to_oid(CurrentPoint.ToString()) + ".html"), FileMode.Create))
                    {
                        using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                        {
                            w.WriteLine("<HTML>");
                            w.WriteLine("<HEAD>");
                            w.WriteLine("<TITLE>Faery Map Leaf " + Utilities.to_oid(CurrentPoint.ToString()) + "</TITLE>");
                            w.WriteLine("<link href=\"map.css\" rel=\"stylesheet\" type=\"text/css\">");
                            w.WriteLine("</HEAD>");
                            w.WriteLine("<BODY>");
                            w.WriteLine("<table>");
                            // determine nav
                            bool TopNav = false;
                            bool BotNav = false;
                            bool LeftNav = false;
                            bool RightNav = false;
                            bool UpperLeftNav = false;
                            bool UpperRightNav = false;
                            bool LowerLeftNav = false;
                            bool LowerRightNav = false;
                            if (CurrentPoint > 18099)
                            {
                                TopNav = true;
                            }
                            if (CurrentPoint < 22000)
                            {
                                BotNav = true;
                            }
                            int y1 = (CurrentPoint - 18000) % 100;
                            if ((y1 % 10) > 1 || (y1 / 10) > 0)
                            {
                                LeftNav = true;
                                if (TopNav)
                                {
                                    UpperLeftNav = true;
                                }
                                if (BotNav)
                                {
                                    LowerLeftNav = true;
                                }
                            }
                            if ((y1 % 10) > 1 || (y1 / 10) < 4)
                            {
                                RightNav = true;
                                if (TopNav)
                                {
                                    UpperRightNav = true;
                                }
                                if (BotNav)
                                {
                                    LowerRightNav = true;
                                }
                            }
                            //
                            if (TopNav)
                            {
                                // write top navigation
                                w.WriteLine("<tr>");
                                if (UpperLeftNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"faery_map_leaf_" + Utilities.to_oid((CurrentPoint - 1010).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("<td colspan = \"20\" class=\"top\"><a href = \"faery_map_leaf_" + Utilities.to_oid((CurrentPoint - 1000).ToString()) + ".html\"><img src=\"grey.gif\" width=\"840\" height=\"20\"></a></td>");
                                if (UpperRightNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"faery_map_leaf_" + Utilities.to_oid((CurrentPoint - 990).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("</tr>");
                            }
                            for (int x = 0; x < 20; x++)
                            {
                                w.WriteLine("<tr>");
                                for (int y = 0; y < 20; y++)
                                {
                                    StringBuilder outline = new StringBuilder();
                                    // see if need left navigation
                                    if (x == 0 && y == 0)
                                    {
                                        if (LeftNav)
                                        {
                                            //<td rowspan="20" class="left"><a href="map_bc23.html"><img src="img/grey.gif" width="20" height="840"></a></td>
                                            StringBuilder outline2 = new StringBuilder();
                                            outline2.Append("<td rowspan=\"20\" class=\"left\">");
                                            outline2.Append("<a href=\"faery_map_leaf_" + Utilities.to_oid((CurrentPoint - 10).ToString()) + ".html\">");
                                            outline2.Append("<img src=\"grey.gif\" width=\"20\" height=\"840\"></a></td>");
                                            w.WriteLine(outline2);
                                        }
                                    }
                                    int Cell = CurrentPoint + (x * 100) + (y);
                                    Location _myloc = Program._locations.Find(z => z._LocId == Cell);
                                    if (_myloc != null)
                                    {
                                        outline.Append("<td id=\"" + _myloc._LocId_Conv + "\"class =" + "\"");
                                        outline.Append(_myloc._Loc_Type + "\"" + ">");
                                        outline.Append(Utilities.format_anchor2(_myloc._LocId_Conv, _myloc._LocId_Conv));
                                        if (_myloc._LI_Here_List != null)
                                        {
                                            //if (_myloc._LI_Here_List.Count > 0 && !_myloc._Loc_Type.Equals("ocean"))
                                            if (_myloc._LI_Here_List.Count > 0)
                                            {
                                                // >= 56760
                                                Location loc1 = null;
                                                Location loc2 = null;
                                                int Count = 0;
                                                foreach (string _here_id in _myloc._LI_Here_List)
                                                {
                                                    if (Convert.ToInt32(_here_id) >= 56760)
                                                    {
                                                        Count++;
                                                        if (loc2 == null)
                                                        {
                                                            loc2 = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id));
                                                        }
                                                        else
                                                        {
                                                            if (loc1 == null)
                                                            {
                                                                loc1 = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id));
                                                            }
                                                        }
                                                    }
                                                }
                                                if (loc1 != null)
                                                {
                                                    if (Count > 2)
                                                    {
                                                        outline.Append("<br />many");
                                                    }
                                                    else
                                                    {
                                                        if (loc1._Loc_Type.Contains("city") || loc1._Loc_Type.Equals("graveyard"))
                                                        {
                                                            outline.Append("<br />" + Utilities.format_anchor2(loc1._LocId_Conv, loc1._Loc_Type));
                                                        }
                                                        else
                                                        {
                                                            outline.Append("<br />" + Utilities.format_loc_type(loc1._Loc_Type));
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    outline.Append("<br />&nbsp;");
                                                }
                                                if (loc2 != null)
                                                {
                                                    if (loc2._Loc_Type.Contains("city") || loc2._Loc_Type.Equals("graveyard"))
                                                    {
                                                        outline.Append("<br />" + Utilities.format_anchor2(loc2._LocId_Conv, loc2._Loc_Type));
                                                    }
                                                    else
                                                    {
                                                        outline.Append("<br />" + Utilities.format_loc_type(loc2._Loc_Type));
                                                    }
                                                }
                                                else
                                                {
                                                    outline.Append("<br />&nbsp;");
                                                }
                                            }
                                            else
                                            {
                                                outline.Append("<br />&nbsp;<br />&nbsp;");
                                                outline.Append("</td>");
                                            }
                                        }
                                        else
                                        {
                                            outline.Append("<br />&nbsp;<br />&nbsp;");
                                            outline.Append("</td>");
                                        }
                                    }
                                    else
                                    {
                                        // location not found in Location list
                                        outline.Append("<td id=\"" + Utilities.to_oid(Cell.ToString()) + "\" class=\"x_sea\">" + Utilities.to_oid(Cell.ToString()) + "</td>");
                                    }
                                    w.WriteLine(outline);
                                    // see if need right navigation
                                    if (x == 0 && y == 19)
                                    {
                                        if (RightNav)
                                        {
                                            //<td rowspan="20" class="left"><a href="map_bc23.html"><img src="img/grey.gif" width="20" height="840"></a></td>
                                            StringBuilder outline2 = new StringBuilder();
                                            outline2.Append("<td rowspan=\"20\" class=\"right\">");
                                            outline2.Append("<a href=\"faery_map_leaf_" + Utilities.to_oid((CurrentPoint + 10).ToString()) + ".html\">");
                                            outline2.Append("<img src=\"grey.gif\" width=\"20\" height=\"840\"></a></td>");
                                            w.WriteLine(outline2);
                                        }
                                    }
                                }
                                w.WriteLine("</tr>");
                            }
                            if (BotNav)
                            {
                                // write top navigation
                                w.WriteLine("<tr>");
                                if (LowerLeftNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"faery_map_leaf_" + Utilities.to_oid((CurrentPoint + 990).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("<td colspan = \"20\" class=\"bottom\"><a href = \"faery_map_leaf_" + Utilities.to_oid((CurrentPoint + 1000).ToString()) + ".html\"><img src=\"grey.gif\" width=\"840\" height=\"20\"></a></td>");
                                if (LowerRightNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"faery_map_leaf_" + Utilities.to_oid((CurrentPoint + 1010).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("</tr>");
                            }
                            w.WriteLine("</table>");
                            w.WriteLine("</BODY>");
                            w.WriteLine("</HTML>");
                        }
                        fs.Close();
                    }
                }
            }
        }
        public static void Write_Hades_Map_Leaves_HTML_File(string path)
        {
            int StartingPoint = 24000;
            int CurrentPoint;
            for (int outery = 0; outery < 7; outery++)
            {
                StartingPoint = 24000 + (outery * 1000);
                for (int outerx = 0; outerx < 7; outerx++)
                {
                    CurrentPoint = StartingPoint + (outerx * 10);
                    using (FileStream fs = new FileStream(System.IO.Path.Combine(path, "hades_map_leaf_" + Utilities.to_oid(CurrentPoint.ToString()) + ".html"), FileMode.Create))
                    {
                        using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                        {
                            w.WriteLine("<HTML>");
                            w.WriteLine("<HEAD>");
                            w.WriteLine("<TITLE>Hades Map Leaf " + Utilities.to_oid(CurrentPoint.ToString()) + "</TITLE>");
                            w.WriteLine("<link href=\"map.css\" rel=\"stylesheet\" type=\"text/css\">");
                            w.WriteLine("</HEAD>");
                            w.WriteLine("<BODY>");
                            w.WriteLine("<table>");
                            // determine nav
                            bool TopNav = false;
                            bool BotNav = false;
                            bool LeftNav = false;
                            bool RightNav = false;
                            bool UpperLeftNav = false;
                            bool UpperRightNav = false;
                            bool LowerLeftNav = false;
                            bool LowerRightNav = false;
                            if (CurrentPoint > 24099)
                            {
                                TopNav = true;
                            }
                            if (CurrentPoint < 28000)
                            {
                                BotNav = true;
                            }
                            int y1 = (CurrentPoint - 24000) % 100;
                            if ((y1 % 10) > 1 || (y1 / 10) > 0)
                            {
                                LeftNav = true;
                                if (TopNav)
                                {
                                    UpperLeftNav = true;
                                }
                                if (BotNav)
                                {
                                    LowerLeftNav = true;
                                }
                            }
                            if ((y1 % 10) > 1 || (y1 / 10) < 4)
                            {
                                RightNav = true;
                                if (TopNav)
                                {
                                    UpperRightNav = true;
                                }
                                if (BotNav)
                                {
                                    LowerRightNav = true;
                                }
                            }
                            //
                            if (TopNav)
                            {
                                // write top navigation
                                w.WriteLine("<tr>");
                                if (UpperLeftNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"hades_map_leaf_" + Utilities.to_oid((CurrentPoint - 1010).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("<td colspan = \"20\" class=\"top\"><a href = \"hades_map_leaf_" + Utilities.to_oid((CurrentPoint - 1000).ToString()) + ".html\"><img src=\"grey.gif\" width=\"840\" height=\"20\"></a></td>");
                                if (UpperRightNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"hades_map_leaf_" + Utilities.to_oid((CurrentPoint - 990).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("</tr>");
                            }
                            for (int x = 0; x < 20; x++)
                            {
                                w.WriteLine("<tr>");
                                for (int y = 0; y < 20; y++)
                                {
                                    StringBuilder outline = new StringBuilder();
                                    // see if need left navigation
                                    if (x == 0 && y == 0)
                                    {
                                        if (LeftNav)
                                        {
                                            //<td rowspan="20" class="left"><a href="map_bc23.html"><img src="img/grey.gif" width="20" height="840"></a></td>
                                            StringBuilder outline2 = new StringBuilder();
                                            outline2.Append("<td rowspan=\"20\" class=\"left\">");
                                            outline2.Append("<a href=\"hades_map_leaf_" + Utilities.to_oid((CurrentPoint - 10).ToString()) + ".html\">");
                                            outline2.Append("<img src=\"grey.gif\" width=\"20\" height=\"840\"></a></td>");
                                            w.WriteLine(outline2);
                                        }
                                    }
                                    int Cell = CurrentPoint + (x * 100) + (y);
                                    Location _myloc = Program._locations.Find(z => z._LocId == Cell);
                                    if (_myloc != null)
                                    {
                                        outline.Append("<td id=\"" + _myloc._LocId_Conv + "\" class =" + "\"");
                                        outline.Append(_myloc._Loc_Type + "\"" + ">");
                                        outline.Append(Utilities.format_anchor2(_myloc._LocId_Conv, _myloc._LocId_Conv));
                                        if (_myloc._LI_Here_List != null)
                                        {
                                            if (_myloc._LI_Here_List.Count > 0 && !_myloc._Loc_Type.Equals("ocean"))
                                            {
                                                // >= 56760
                                                Location loc1 = null;
                                                Location loc2 = null;
                                                int Count = 0;
                                                foreach (string _here_id in _myloc._LI_Here_List)
                                                {
                                                    if (Convert.ToInt32(_here_id) >= 56760)
                                                    {
                                                        Count++;
                                                        if (loc2 == null)
                                                        {
                                                            loc2 = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id));
                                                        }
                                                        else
                                                        {
                                                            if (loc1 == null)
                                                            {
                                                                loc1 = Program._locations.Find(z => z._LocId == Convert.ToInt32(_here_id));
                                                            }
                                                        }
                                                    }
                                                }
                                                if (loc1 != null)
                                                {
                                                    if (Count > 2)
                                                    {
                                                        outline.Append("<br />many");
                                                    }
                                                    else
                                                    {
                                                        if (loc1._Loc_Type.Contains("city") || loc1._Loc_Type.Equals("graveyard"))
                                                        {
                                                            outline.Append("<br />" + Utilities.format_anchor2(loc1._LocId_Conv, loc1._Loc_Type));
                                                        }
                                                        else
                                                        {
                                                            outline.Append("<br />" + Utilities.format_loc_type(loc1._Loc_Type));
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    outline.Append("<br />&nbsp;");
                                                }
                                                if (loc2 != null)
                                                {
                                                    if (loc2._Loc_Type.Contains("city") || loc2._Loc_Type.Equals("graveyard"))
                                                    {
                                                        outline.Append("<br />" + Utilities.format_anchor2(loc2._LocId_Conv, loc2._Loc_Type));
                                                    }
                                                    else
                                                    {
                                                        outline.Append("<br />" + Utilities.format_loc_type(loc2._Loc_Type));
                                                    }
                                                }
                                                else
                                                {
                                                    outline.Append("<br />&nbsp;");
                                                }
                                            }
                                            else
                                            {
                                                outline.Append("<br />&nbsp;<br />&nbsp;");
                                                outline.Append("</td>");
                                            }
                                        }
                                        else
                                        {
                                            outline.Append("<br />&nbsp;<br />&nbsp;");
                                            outline.Append("</td>");
                                        }
                                    }
                                    else
                                    {
                                        // location not found in Location list
                                        outline.Append("<td id=\"" + Utilities.to_oid(Cell.ToString()) + "\" class=\"x_sea\">" + Utilities.to_oid(Cell.ToString()) + "</td>");
                                    }
                                    w.WriteLine(outline);
                                    // see if need right navigation
                                    if (x == 0 && y == 19)
                                    {
                                        if (RightNav)
                                        {
                                            //<td rowspan="20" class="left"><a href="map_bc23.html"><img src="img/grey.gif" width="20" height="840"></a></td>
                                            StringBuilder outline2 = new StringBuilder();
                                            outline2.Append("<td rowspan=\"20\" class=\"right\">");
                                            outline2.Append("<a href=\"hades_map_leaf_" + Utilities.to_oid((CurrentPoint + 10).ToString()) + ".html\">");
                                            outline2.Append("<img src=\"grey.gif\" width=\"20\" height=\"840\"></a></td>");
                                            w.WriteLine(outline2);
                                        }
                                    }
                                }
                                w.WriteLine("</tr>");
                            }
                            if (BotNav)
                            {
                                // write top navigation
                                w.WriteLine("<tr>");
                                if (LowerLeftNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"hades_map_leaf_" + Utilities.to_oid((CurrentPoint + 990).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("<td colspan = \"20\" class=\"bottom\"><a href = \"hades_map_leaf_" + Utilities.to_oid((CurrentPoint + 1000).ToString()) + ".html\"><img src=\"grey.gif\" width=\"840\" height=\"20\"></a></td>");
                                if (LowerRightNav)
                                {
                                    w.WriteLine("<td class=\"corner\"><a href = \"hades_map_leaf_" + Utilities.to_oid((CurrentPoint + 1010).ToString()) + ".html\"><img src=\"grey.gif\" width=\"20\" height=\"20\"></a></td>");
                                }
                                w.WriteLine("</tr>");
                            }
                            w.WriteLine("</table>");
                            w.WriteLine("</BODY>");
                            w.WriteLine("</HTML>");
                        }
                        fs.Close();
                    }
                }
            }
        }
        public static void Generate_Item_List_HTML(string path)
        {
            using (FileStream fs = new FileStream(System.IO.Path.Combine(path, "master_item_list.html"), FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>Olympia Master Item List</TITLE>");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    w.WriteLine("<h3>Olympia Master Item List</h3>");
                    w.WriteLine("<table border=\"1\">");
                    w.WriteLine("<tr>");
                    w.WriteLine("<th>Item</th><th>Item Type</th><th>Weight</th><th>Man Item</th><th>Prominent</th><th>Animal</th><th>Land Cap</th><th>Riding cap</th><th>Flying Cap</th><th>Who Has</th><th>Notes</th>");
                    w.WriteLine("</tr>");
                    foreach (Itemz _item in Program._items)
                    {
                        w.WriteLine("<tr>");
                        w.WriteLine("<td>" + _item._Name + " [" + _item._ItemId_Conv + "]</td>");
                        w.WriteLine("<td>" + (_item._Item_Type != "0"?_item._Item_Type:"std item") + "</td>");
                        w.WriteLine("<td>" + _item._Weight + "</td>");
                        w.WriteLine("<td>" + (_item._IT_Man_Item == "1" ? "yes":"") + "</td>");
                        w.WriteLine("<td>" + (_item._IT_Prominent == "1" ? "yes" : "") + "</td>");
                        w.WriteLine("<td>" + (_item._IT_Animal == "1" ? "yes" : "") + "</td>");
                        w.WriteLine("<td>" + _item._Land_Capacity + "</td>");
                        w.WriteLine("<td>" + _item._Ride_Capacity + "</td>");
                        w.WriteLine("<td>" + _item._Fly_Capacity + "</td>");
                        if (_item._IT_Who_Has != 0)
                        {
                            if (Program._characters.Find(x=>x._CharId == _item._IT_Who_Has) != null)
                            {
                                Character _mychar = Program._characters.Find(x => x._CharId == _item._IT_Who_Has);
                                w.WriteLine("<td>" + _mychar._Name + " " + Utilities.format_anchor(_mychar._CharId.ToString()) + "</td>");
                            }
                            else
                            {
                                w.WriteLine("<td>&nbsp;</td>");
                            }
                        }
                        else
                        {
                            w.WriteLine("<td>&nbsp;</td>");
                        }
                        w.WriteLine("<td>" + Itemz.Determine_Use(_item) + "</td>");
                        w.WriteLine("</tr>");
                    }
                    w.WriteLine("</table>");
                    w.WriteLine("</BODY>");
                    w.WriteLine("</HTML>");
                }
                fs.Close();
            }
        }
        public static void Generate_Player_List_HTML(string path)
        {
            using (FileStream fs = new FileStream(System.IO.Path.Combine(path, "master_player_list.html"), FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>Olympia Master Player List</TITLE>");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    w.WriteLine("<h3>Olympia Master Player List</h3>");
                    w.WriteLine("<table border=\"1\">");
                    w.WriteLine("<tr>");
                    w.WriteLine("<th>Player</th><th>Name</th><th>Player Type</th><th># Units</th>");
                    w.WriteLine("</tr>");
                    foreach (Player _player in Program._players)
                    {
                        w.WriteLine("<tr>");
                        w.WriteLine("<td>" + _player._FactionId_Conv + "</td>");
                        w.WriteLine("<td>" + _player._Name + "</td>");
                        w.WriteLine("<td>" + _player._Player_Type + "</td>");
                        if (_player._Unit_List != null)
                        {
                            w.WriteLine("<td>" + _player._Unit_List.Count + "</td>");
                        }
                        else
                        {
                            w.WriteLine("<td>&nbsp;</td>");
                        }
                        w.WriteLine("</tr>");
                    }
                    w.WriteLine("</table>");
                    w.WriteLine("</BODY>");
                    w.WriteLine("</HTML>");
                }
                fs.Close();
            }
        }
        public static void Generate_Ship_List_HTML(string path)
        {
            using (FileStream fs = new FileStream(System.IO.Path.Combine(path, "master_ship_list.html"), FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>Olympia Master Ship List</TITLE>");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    w.WriteLine("<h3>Olympia Master Ship List</h3>");
                    w.WriteLine("<table border=\"1\" style=\"border-collapse: collapse\">");
                    w.WriteLine("<tr>");
                    w.WriteLine("<th>Id</th><th>Type</th><th>Captain</th><th>Location</th><th>Damage</th><th>Load</th><th>Storm (strength)</th>");
                    w.WriteLine("</tr>");
                    foreach (Ship _ship in Program._ships)
                    {
                        w.WriteLine("<tr>");
                        w.WriteLine("<td>{0} {1}</td>", _ship._Name,Utilities.format_anchor(_ship._ShipId.ToString()));
                        w.WriteLine("<td>{0}&nbsp;&nbsp;</td>", _ship._Ship_Type);
                        List<Stack> ship_stack = new List<Stack>();
                        int level = 0;
                        ship_stack = Stack.chase_structure(_ship._ShipId, ship_stack, level);
                        if (ship_stack.Count > 0)
                        {
                            bool printed_captain = false;
                            foreach (Stack stack_entry in ship_stack.Where(x => x._entity_type == "char"))
                            {
                                Character mychar = Program._characters.Find(x => x._CharId == stack_entry._entityid);
                                if (mychar != null)
                                {
                                    w.WriteLine("<td>{0} {1}</td>", mychar._Name, Utilities.format_anchor(mychar._CharId.ToString()));
                                    printed_captain = true;
                                    break;
                                }
                            }
                            if (!printed_captain)
                            {
                                w.WriteLine("<td>{0}</td>", "&nbsp;");
                            }
                        }
                        else
                        {
                            w.WriteLine("<td>{0}</td>", "&nbsp;");
                        }
                        if (_ship._LI_Where != 0)
                        {
                            Location myloc = Program._locations.Find(x => x._LocId == _ship._LI_Where);
                            if (myloc != null)
                            {
                                w.WriteLine("<td>{0} {1}</td>", myloc._Name, Utilities.format_anchor(myloc._LocId_Conv));
                            }
                            else
                            {
                                w.WriteLine("<td>{0}</td>", "&nbsp;");
                            }
                        }
                        else
                        {
                            w.WriteLine("<td>{0}</td>", "&nbsp;");
                        }
                        w.WriteLine("<td>{0}%</td>", _ship._SL_Damage);
                        if (ship_stack.Count > 0)
                        {
                            int total_weight = Ship.determine_ship_weight(ship_stack);
                            // adjust capacity for damage
                            int actual_capacity = _ship._SL_Capacity - ((_ship._SL_Capacity * _ship._SL_Damage) / 100);
                            w.WriteLine("<td>{0}%</td>", ((total_weight * 100) / actual_capacity)); // calculate load
                        }
                        else
                        {
                            w.WriteLine("<td>{0}</td>", "&nbsp;");
                        }
                        if (_ship._SL_Bound_Storm != 0)
                        {
                            Storm bound_storm = Program._storms.Find(x=>x._StormId == _ship._SL_Bound_Storm);
                            if (bound_storm != null)
                            {
                                w.WriteLine("<td>{0} [{1}] ({2})</td>", bound_storm._Storm_Type, bound_storm._StormId, bound_storm._Storm_Strength);
                            }
                            else
                            {
                                w.WriteLine("<td>{0}</td>", _ship._SL_Bound_Storm);
                            }
                        }
                        else
                        {
                            w.WriteLine("<td>{0}</td>", "&nbsp;");
                        }
                        w.WriteLine("</tr>");
                    }
                    w.WriteLine("</table>");
                    w.WriteLine("</BODY>");
                    w.WriteLine("</HTML>");
                }
                fs.Close();
            }
        }
    }
}
