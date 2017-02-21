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
        public static void Write_Home_HTML_File()
        {
            using (FileStream fs = new FileStream(@"d:\Temp\turn163\home.html", FileMode.Create))
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
                    w.WriteLine("<li>Main</li>");
                    w.WriteLine("<li>Hades</li>");
                    w.WriteLine("<li>Faery</li>");
                    w.WriteLine("</ul>");
                    w.WriteLine("</th>");
                    w.WriteLine("<th>");
                    w.WriteLine("<ul>Reports<br>");
                    w.WriteLine("<li>Characters</li>");
                    w.WriteLine("<li>Ships</li>");
                    w.WriteLine("</ul>");
                    w.WriteLine("</th>");
                    w.WriteLine("<th>");
                    w.WriteLine("<ul>Links<br>");
                    w.WriteLine("<li>Olympia Rules</li>");
                    w.WriteLine("<li>Olympia Orders</li>");
                    w.WriteLine("<li>Olympia Skills</li>");
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
        public static void Write_Main_Map_HTML_File()
        {
            using (FileStream fs = new FileStream(@"d:\Temp\turn163\main_map.html", FileMode.Create))
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
        public static void Write_Main_Map_Leaves_HTML_File()
        {
            int StartingPoint = 10000;
            int CurrentPoint;
            for (int outery = 0; outery < 7; outery++)
            {
                StartingPoint = 10000 + (outery * 1000);
                for (int outerx = 0; outerx < 7; outerx++)
                {
                    CurrentPoint = StartingPoint + (outerx * 10);
                    using (FileStream fs = new FileStream(@"d:\Temp\turn163\main_map_leaf_" + Utilities.to_oid(CurrentPoint.ToString()) + ".html", FileMode.Create))
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
                                        if (Location.FiftyMen(_myloc))
                                        {
                                            outline.Append("<td style=\"border: 1px solid red\" ");
                                        }
                                        else
                                        {
                                            outline.Append("<td ");
                                        }
                                        // border: 1px solid black
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
                                            if (_myloc._LI_Here_List.Count > 0 && !_myloc._Loc_Type.Equals("ocean"))
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
        public static void Write_Faery_Map_Leaves_HTML_File()
        {
            int StartingPoint = 18000;
            int CurrentPoint;
            for (int outery = 0; outery < 7; outery++)
            {
                StartingPoint = 18000 + (outery * 1000);
                for (int outerx = 0; outerx < 7; outerx++)
                {
                    CurrentPoint = StartingPoint + (outerx * 10);
                    using (FileStream fs = new FileStream(@"d:\Temp\turn163\faery_map_leaf_" + Utilities.to_oid(CurrentPoint.ToString()) + ".html", FileMode.Create))
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
        public static void Write_Hades_Map_Leaves_HTML_File()
        {
            int StartingPoint = 24000;
            int CurrentPoint;
            for (int outery = 0; outery < 7; outery++)
            {
                StartingPoint = 24000 + (outery * 1000);
                for (int outerx = 0; outerx < 7; outerx++)
                {
                    CurrentPoint = StartingPoint + (outerx * 10);
                    using (FileStream fs = new FileStream(@"d:\Temp\turn163\hades_map_leaf_" + Utilities.to_oid(CurrentPoint.ToString()) + ".html", FileMode.Create))
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
        public static void Write_Ship_HTML_File(Ship _myship)
        {
            using (FileStream fs = new FileStream(@"d:\Temp\turn163\" + _myship._ShipId + ".html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>" + _myship._Name +
                                " [" + _myship._ShipId + "], " +
                                _myship._ShipId +
                                "</TITLE>");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    Write_Ship_Page_Header(_myship, w);
                    Write_Ship_Basic_Info(_myship, w);
                    w.WriteLine("</BODY>");
                    w.WriteLine("</HTML>");
                }
                fs.Close();
            }
        }
        private static void Write_Ship_Page_Header(Ship _myship, StreamWriter w)
        {
            StringBuilder outline3 = new StringBuilder();
            outline3.Append("<H3>");
            outline3.Append(_myship._Name);
            outline3.Append(" [");
            outline3.Append(_myship._ShipId);
            outline3.Append("]");
            outline3.Append(", " + _myship._Ship_Type);
            outline3.Append("</H3>");
            w.WriteLine(outline3);
        }
        private static void Write_Ship_Basic_Info(Ship _myship, StreamWriter w)
        {
            StringBuilder outline = new StringBuilder();
            w.WriteLine("<table>");
            // location
            w.WriteLine("<tr>");
            w.WriteLine("<td>Location:</td>");
            outline.Append("<td>");
            Location _myloc = Program._locations.Find(x => x._LocId == Convert.ToInt32(_myship._LI_Where));
            if (_myloc != null)
            {
                Determine_Char_Location(outline, _myloc);
            }
            outline.Append("</td>");
            w.WriteLine(outline);
            outline.Clear();
            w.WriteLine("</tr>");
            if (_myship._SL_Effort_Given < _myship._SL_Effort_Required)
            {
                w.WriteLine("<tr>");
                w.WriteLine("<td>Percent Complete:</td>");
                w.WriteLine("<td>" + ((float)_myship._SL_Effort_Given /(float)_myship._SL_Effort_Required) * 100f + "%</td>");
                w.WriteLine("</tr>");
            }
            w.WriteLine("<tr>");
            w.WriteLine("<td>Loaded:</td>");
            outline.Append("<td>");
            // calculate load of all passengers
            if (_myship._LI_Here_List != null)
            {
                int total_weight = 0;
                foreach (int _mycharid in _myship._LI_Here_List)
                {
                    if (Program._characters.Find(x => x._CharId == _mycharid) != null)
                    {
                        total_weight += Program._characters.Find(x => x._CharId == _mycharid).Accumulated_Weight;
                    }
                }
                outline.Append((float)((((float)_myship._LI_Here_List.Count * 100) + (float)total_weight)/ (float)_myship._SL_Capacity) * 100 + "%");
            }
            else
            {
                outline.Append("0%");
            }
            outline.Append("</td>");
            w.WriteLine(outline);
            outline.Clear();
            w.WriteLine("</tr>");
            w.WriteLine("<tr>");
            w.WriteLine("<td>Defense:</td>");
            w.WriteLine("<td>" + _myship._SL_Defense + "</td>");
            w.WriteLine("</tr>");
            w.WriteLine("<tr>");
            w.WriteLine("<td>Damaged:</td>");
            w.WriteLine("<td>" + _myship._SL_Damage + "%</td>");
            w.WriteLine("</tr>");
            w.WriteLine("<tr>");
            w.WriteLine("<td>Owner:</td>");
            outline.Append("<td>");
            if (_myship._LI_Here_List != null)
            {
                if (_myship._LI_Here_List.Count > 0)
                {
                    Character _mychar = Program._characters.Find(x => x._CharId == _myship._LI_Here_List[0]);
                    outline.Append(_mychar._Name + " " + Utilities.format_anchor(_mychar._CharId.ToString()));
                }
                else
                {
                    outline.Append("unoccupied");
                }
            }
            else
            {
                outline.Append("unoccupied");
            }
            outline.Append("</td>");
            w.WriteLine(outline);
            outline.Clear();
            w.WriteLine("</tr>");
            if (_myship._LI_Here_List != null)
            {
                string label1 = "Seen Here:";
                foreach (int _charonship in _myship._LI_Here_List)
                {
                    if (Program._characters.Find(x => x._CharId == _charonship) != null)
                    {
                        Character _mychar = Program._characters.Find(x => x._CharId == _charonship);
                        w.WriteLine("<tr>");
                        w.WriteLine("<td>" + label1 + "</td>");
                        label1 = "";
                        outline.Append("<td>");
                        outline.Append(_mychar._Name + " " + Utilities.format_anchor(_mychar._CharId.ToString()));
                        outline.Append("</td>");
                        w.WriteLine(outline);
                        outline.Clear();
                        w.WriteLine("</tr>");
                    }
                }
            }
            if (_myship._SL_Bound_Storm != 0)
            {
                Storm _mystorm = Program._storms.Find(x => x._StormId == _myship._SL_Bound_Storm);
                if (_mystorm != null)
                {
                    w.WriteLine("<tr>");
                    w.WriteLine("<td>Bound Storm:</td>");
                    w.WriteLine("<td>" + _mystorm._Storm_Type + " [" +_myship._SL_Bound_Storm + "] (strength: " + _mystorm._Storm_Strength + ")</td>");
                    w.WriteLine("</tr>");
                }
            }
            w.WriteLine("</table>");
        }
        public static void Write_Char_HTML_File(Character _mychar)
        {
            using (FileStream fs = new FileStream(@"d:\Temp\turn163\" + _mychar._CharId + ".html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>" + _mychar._Name +
                                " [" + _mychar._CharId + "], " +
                                _mychar._CharId +
                                "</TITLE>");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    Write_Char_Page_Header(_mychar, w);
                    Write_Char_Basic_Info(_mychar, w);
                    w.WriteLine("</BODY>");
                    w.WriteLine("</HTML>");
                }
                fs.Close();
            }
        }
        private static void Write_Char_Page_Header(Character _myChar, StreamWriter w)
        {
            StringBuilder outline3 = new StringBuilder();
            outline3.Append("<H3>");
            outline3.Append(_myChar._Name);
            outline3.Append(" [");
            outline3.Append(_myChar._CharId);
            outline3.Append("]");
            outline3.Append("</H3>");
            w.WriteLine(outline3);
        }
        private static void Write_Char_Basic_Info(Character _myChar, StreamWriter w)
        {
            StringBuilder outline = new StringBuilder();
            w.WriteLine("<table>");
            // location
            w.WriteLine("<tr>");
            w.WriteLine("<td>Location:</td>");
            outline.Append("<td>");
            Location _myloc = Program._locations.Find(x => x._LocId == Convert.ToInt32(_myChar._LI_Where));
            if (_myloc != null)
            {
                Determine_Char_Location(outline, _myloc);
            }
            else
            {
                Character _mychar2 = Program._characters.Find(x => x._CharId == Convert.ToInt32(_myChar._LI_Where));
                if (_mychar2 != null)
                {
                    Location _myloca = Program._locations.Find(x => x._LocId == Convert.ToInt32(_mychar2._LI_Where));
                    if (_myloca != null)
                    {
                        Determine_Char_Location(outline, _myloca);
                    }
                }
                else
                {
                    Ship _myship = Program._ships.Find(x => x._ShipId == Convert.ToInt32(_myChar._LI_Where));
                    if (_myship != null)
                    {
                        outline.Append(_myship._Name + " " + Utilities.format_anchor(_myship._ShipId.ToString()) + ", ");
                        Location _myloca = Program._locations.Find(x => x._LocId == _myship._LI_Where);
                        if (_myloca != null)
                        {
                            Determine_Char_Location(outline, _myloca);
                        }
                    }
                }
            }
            outline.Append("</td>");
            w.WriteLine(outline);
            w.WriteLine("</tr>");
            // loyalty
            w.WriteLine("<tr>");
            w.WriteLine("<td>Loyalty:</td>");
            w.WriteLine("<td>" + Utilities.xlate_loyalty(_myChar._CH_LOY_Kind, _myChar._CH_LOY_Rate)+ "</td>");
            w.WriteLine("</tr>");
            // stacked under
            if (Program._characters.Find(x => x._CharId == Convert.ToInt32(_myChar._LI_Where)) != null)
            {
                Character _mychar_under = Program._characters.Find(x => x._CharId == Convert.ToInt32(_myChar._LI_Where));
                if (_mychar_under._Char_Type == "0")
                {
                    w.WriteLine("<tr>");
                    w.WriteLine("<td>Stacked Under:</td>");
                    w.WriteLine("<td>" + _mychar_under._Name + " " + Utilities.format_anchor(_mychar_under._CharId.ToString()) + "</td>");
                    w.WriteLine("</tr>");
                }
            }
            // stacked over
            if (_myChar._LI_Here_List != null)
            {
                StringBuilder outline2 = new StringBuilder();
                StringBuilder outline3 = new StringBuilder();
                outline2.Append("Stacked Over:");
                foreach (string _stacked_under in _myChar._LI_Here_List)
                { 
                    if (Program._characters.Find(x => x._CharId == Convert.ToInt32(_stacked_under)) != null)
                    {
                        Character _mychar_over = Program._characters.Find(x => x._CharId == Convert.ToInt32(_stacked_under));
                        if (_mychar_over._Char_Type == "0")
                        {
                            outline2.Append("<br>");
                            outline3.Append(_mychar_over._Name + " " + Utilities.format_anchor(_mychar_over._CharId.ToString()) + "<br>");
                        }
                    }
                }
                w.WriteLine("<tr><td>" + outline2 + "</td><td>" + outline3 + "</td></tr>");
            }
            // Health
            w.WriteLine("<tr>");
            w.WriteLine("<td>Health:</td>");
            w.WriteLine("<td>" + _myChar._CH_Health + "%</td>");
            w.WriteLine("</tr>");
            // combat
            w.WriteLine("<tr>");
            w.WriteLine("<td>Combat:</td>");
            outline.Clear();
            outline.Append("<td>" + "attack " + _myChar._CH_Attack + ", defense " + _myChar._CH_Defense +
                            ", missile " + _myChar._CH_Missile);
            if (_myChar._CH_Behind != null)
            {
                outline.Append("<br>" + "behind: " +
                                _myChar._CH_Behind + (_myChar._CH_Behind.Equals(0) ? " (front line in combat)" : " (stay behind in combat)") );
            }
            outline.Append("</td>");
            w.WriteLine(outline);
            w.WriteLine("</tr>");
            // break point
            w.WriteLine("<tr>");
            w.WriteLine("<td>Break Point:</td>");
            w.WriteLine("<td>" + _myChar._CH_Break_Point + (_myChar._CH_Break_Point.Equals(0) ? "% (fight to the death)" : "%") + " </td>");
            w.WriteLine("</tr>");
            // vision protection
            if (_myChar._CM_Vision_Protect != null)
            { w.WriteLine("<tr>");
                w.WriteLine("<td>Receive Vision:</td>");
                w.WriteLine("<td>" + _myChar._CM_Vision_Protect + " protection" + " </td>");
                w.WriteLine("</tr>");
            }
            // pledged to
            if (_myChar._CM_Pledged_To != 0)
            {
                Character _mychar2 = Program._characters.Find(x => x._CharId == _myChar._CM_Pledged_To);
                if (_mychar2 != null)
                {
                    w.WriteLine("<tr>");
                    w.WriteLine("<td>Pledged to:</td>");
                    w.WriteLine("<td>" + _mychar2._Name + Utilities.format_anchor(_mychar2._CharId.ToString())  + " </td>");
                    w.WriteLine("</tr>");
                }
            }
            // pledged to us
            List<Character> _pledgedlist = Program._characters.FindAll(x => x._CM_Pledged_To == _myChar._CharId);
            if (_pledgedlist != null)
            {
                string pledgelabel = "Pledged to us:";
                foreach (Character _pledgechar in _pledgedlist)
                {
                    w.WriteLine("<tr>");
                    w.WriteLine("<td>" + pledgelabel +"</td>");
                    pledgelabel = "&nbsp;";
                    w.WriteLine("<td>" + _pledgechar._Name + Utilities.format_anchor(_pledgechar._CharId.ToString()) + " </td>");
                    w.WriteLine("</tr>");
                }
            }
            // concealed
            if (_myChar._CM_Hide_Self != null)
            {
                if (_myChar._CM_Hide_Self == "1")
                {
                    w.WriteLine("<tr>");
                    w.WriteLine("<td>Concealed:</td>");
                    w.WriteLine("<td>Yes (but not sure if alone)</td>");
                    w.WriteLine("</tr>");
                }
            }
            // aura
            if (_myChar._CM_Magician != null)
            {
                if (_myChar._CM_Magician == "1")
                {
                    if (_myChar._CM_Cur_Aura != null)
                    {
                        w.WriteLine("<tr><td>Current Aura:</td><td>" + _myChar._CM_Cur_Aura + "</td></tr>");
                    }
                    if (_myChar._CM_Max_Aura != null)
                    {
                        w.WriteLine("<tr><td>Max Aura:</td><td>" + _myChar._CM_Max_Aura + "</td></tr>");
                    }
                }
            }
            w.WriteLine("</table>");
            // skills known
            if (_myChar._CH_Skills_List != null)
            {
                int iterations = _myChar._CH_Skills_List.Count() / 5;
                bool printKnown = false;
                bool printUnknown = false;
                for (int i = 0; i < iterations; i++)
                {
                    string _skill = _myChar._CH_Skills_List[(i * 5) + 0];
                    string _know = _myChar._CH_Skills_List[(i * 5) + 1];
                    string _days_studied = _myChar._CH_Skills_List[(i * 5) + 2];
                    if (_know == "2")
                    {
                        if (!printKnown)
                        {
                            w.WriteLine("<p>Skills known:</p>");
                            w.WriteLine("<ul style=\"list-style-type:none\">");
                            printKnown = true;
                        }
                        if (Program._skills.Find(x => x._SkillId == Convert.ToInt32(_skill)) != null)
                        {
                            Skill _myskill = Program._skills.Find(x => x._SkillId == Convert.ToInt32(_skill));
                            w.WriteLine("<li>" + (_myskill._SK_Required_Skill != 0 ? "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" : "") + _myskill._Name + " [" + _myskill._SkillId + "]</li>");
                        }
                    }
                    if (_know == "1")
                    {
                        if (!printUnknown)
                        {
                            if (printKnown)
                            {
                                w.WriteLine("</ul>");
                            }
                            w.WriteLine("<p>Partially known skills:</p>");
                            w.WriteLine("<ul style=\"list-style-type:none\">");
                            printUnknown = true;
                        }
                        if (Program._skills.Find(x => x._SkillId == Convert.ToInt32(_skill)) != null)
                        {
                            Skill _myskill = Program._skills.Find(x => x._SkillId == Convert.ToInt32(_skill));
                            w.WriteLine("<li>" + _myskill._Name + " [" + _myskill._SkillId + "], {0}/{1}</li>",_days_studied,_myskill._SK_Time_to_learn);
                        }
                    }
                }
                if (printKnown || printUnknown)
                {
                    w.WriteLine("</ul>");
                }
            }
            // Inventory - same logic as Character.Calculate_Weights
            int total_weight = 0;
            if (_myChar._Item_List != null)
            {
                int iterations = _myChar._Item_List.Count() / 2;
                w.WriteLine("Inventory:");
                w.WriteLine("<table>");
                w.WriteLine("<tr><td style=\"text-align:right\">qty</td><td style=\"text-align:left\">name</td><td style=\"text-align:right\">weight</td></tr>");
                w.WriteLine("<tr><td style=\"text-align:right\">---</td><td style=\"text-align:left\">----</td><td style=\"text-align:right\">-----</td></tr>");
                for (int i = 0; i < iterations; i++)
                {
                    int _item = _myChar._Item_List[(i * 2)];
                    int _qty = _myChar._Item_List[(i * 2)+1];
                    w.WriteLine("<tr>");
                    w.WriteLine("<td style=\"text-align:right\">" + _qty + "</td>");
                    Itemz _myitem = Program._items.Find(x=>x._ItemId == _item);
                    if (_myitem != null)
                    {
                        w.WriteLine("<td style=\"text-align:left\">" + (_qty == 1 ?_myitem._Name:_myitem._Plural) + " [" + Utilities.to_oid(_item.ToString()) + "]</td>");
                        w.WriteLine("<td style=\"text-align:right\">" + (_myitem._Weight * _qty) + "</td>");
                        total_weight += (_myitem._Weight * _qty);
                    }
                    else
                    {
                        w.WriteLine("<td>" + "undefined" + "</td>");
                        w.WriteLine("<td>" + 0 + "</td>");
                    }
                    w.WriteLine("</tr>");
                }
                w.WriteLine("<tr><td></td><td></td><td style=\"text-align:right\">=====</td></tr>");
                w.WriteLine("<tr><td></td><td></td><td style=\"text-align:right\">" + total_weight + "</td></tr>");
                w.WriteLine("</table>");
            }
            // capacity
            w.WriteLine("<p>Capacity:</p>");
            // pending trades
            if (_myChar._Trade_List != null)
            {
                int iterations = _myChar._Trade_List.Count() / 8;
                w.WriteLine("<p>Pending Trades:</p>");
                w.WriteLine("<table>");
                w.WriteLine("<tr><td style=\"text-align:right\">trade</td><td style=\"text-align:right\">price</td><td style=\"text-align:right\">qty</td><td style=\"text-align:left\">item</td></tr>");
                w.WriteLine("<tr><td style=\"text-align:right\">---</td><td style=\"text-align:right\">----</td><td style=\"text-align:left\">-----</td></tr>");
                for (int i = 0; i < iterations; i++)
                {
                    string _type = _myChar._Trade_List[(i * 8)];
                    string _item = _myChar._Trade_List[(i * 8) + 1];
                    int _qty = Convert.ToInt32(_myChar._Trade_List[(i * 8) + 2]);
                    int _cost = Convert.ToInt32(_myChar._Trade_List[(i * 8) + 3]);
                    w.WriteLine("<tr>");
                    Itemz _myitem = Program._items.Find(x => x._ItemId == Convert.ToInt32(_item));
                    if (_myitem != null)
                    {
                        w.WriteLine("<td style=\"text-align:right\">" + (_type == "1" ? "buy" : "sell") + "</td>");
                        w.WriteLine("<td style=\"text-align:right\">" + _cost + "</td>");
                        w.WriteLine("<td style=\"text-align:right\">" + _qty + "</td>");
                        w.WriteLine("<td style=\"text-align:left\">" + (_qty == 1 ? _myitem._Name : _myitem._Plural) + " [" + Utilities.to_oid(_item.ToString()) + "]</td>");
                    }
                    w.WriteLine("</tr>");
                }
                w.WriteLine("</table>");
            }
        }

        private static void Determine_Char_Location(StringBuilder outline, Location _myloc)
        {
            outline.Append(_myloc._Name + " " + Utilities.format_anchor(_myloc._LocId_Conv));
            if (Program._locations.Find(x => x._LocId == _myloc._LI_Where) != null)
            {
                Location _myloc2 = Program._locations.Find(x => x._LocId == _myloc._LI_Where);
                if (_myloc2._Loc_Type != "region")
                {
                    outline.Append(", in " + _myloc2._Name + " " + Utilities.format_anchor(_myloc2._LocId_Conv));
                    if (Program._locations.Find(x => x._LocId == _myloc2._LI_Where) != null)
                    {
                        Location _myloc3 = Program._locations.Find(x => x._LocId == _myloc2._LI_Where);
                        if (_myloc3._Loc_Type != "region")
                        {
                            outline.Append(", in " + _myloc3._Name + " " + Utilities.format_anchor(_myloc3._LocId_Conv));
                            if (Program._locations.Find(x => x._LocId == _myloc3._LI_Where) != null)
                            {
                                Location _myloc4 = Program._locations.Find(x => x._LocId == _myloc3._LI_Where);
                                if (_myloc4._Loc_Type != "region")
                                {
                                    outline.Append(", in " + _myloc4._Name + " " + Utilities.format_anchor(_myloc4._LocId_Conv));
                                }
                                else
                                {
                                    outline.Append(", in " + _myloc4._Name);
                                }
                            }
                        }
                        else
                        {
                            outline.Append(", in " + _myloc3._Name);
                        }
                    }
                }
                else
                {
                    outline.Append(", in " + _myloc2._Name);
                }
            }
        }

        public static void Write_Loc_HTML_File(Location _myloc)
        {
            using (FileStream fs = new FileStream(@"d:\Temp\turn163\" + _myloc._LocId_Conv + ".html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<HTML>");
                    w.WriteLine("<HEAD>");
                    w.WriteLine("<TITLE>" + _myloc._Name +
                                " [" + _myloc._LocId_Conv + "], " +
                                _myloc._Loc_Type + ", in " +
                                (Program._locations.Find(x => x._LocId == Convert.ToInt32(_myloc._LI_Where))._Name) +
                                "</TITLE>");
                    w.WriteLine("</HEAD>");
                    w.WriteLine("<BODY>");
                    Write_Loc_Page_Header(_myloc, w);
                    Write_Controlled_By(_myloc, w);
                    Write_Routes_Out(_myloc, w);
                    Write_Nearby_Cities(_myloc, w);
                    Write_Skills_Report(_myloc, w);
                    Write_Market_Report(_myloc, w);
                    // Print Here List (Inner Locations and Seen Here)
                    if (_myloc._LI_Here_List != null)
                    {
                        Write_Here_List_HTML(_myloc, w);
                    }
                    // if hidden, print which factions have accessed it
                    if (_myloc._LO_Hidden != null)
                    {
                        if (_myloc._LO_Hidden == "1")
                        {
                            Write_Hidden_Accesses_HTML(_myloc, w);
                        }
                    }
                    w.WriteLine("</BODY>");
                    w.WriteLine("</HTML>");
                }
                fs.Close();
            }
        }

        private static void Write_Loc_Page_Header(Location _myloc, StreamWriter w)
        {
            StringBuilder outline3 = new StringBuilder();
            outline3.Append("<H3>");
            outline3.Append(_myloc._Name);
            outline3.Append(" [");
            outline3.Append(_myloc._LocId_Conv);
            outline3.Append("], ");
            outline3.Append(_myloc._Loc_Type);
            outline3.Append(", in ");
            if (_myloc._Loc_Type.Contains("city"))
            {
                outline3.Append("province ");
            }
            outline3.Append((Program._locations.Find(x => x._LocId == Convert.ToInt32(_myloc._LI_Where))._Name));
            if (_myloc._Loc_Type.Contains("city"))
            {
                outline3.Append(" [");
                outline3.Append((Program._locations.Find(x => x._LocId == Convert.ToInt32(_myloc._LI_Where))._LocId_Conv));
                outline3.Append("]");
            }
            if (_myloc._SL_Safe != null)
            {
                if (_myloc._SL_Safe.Equals("1"))
                {
                    outline3.Append(", safe haven");
                }
            }
            if (_myloc._LO_Hidden != null)
            {
                if (_myloc._LO_Hidden == "1")
                {
                    outline3.Append(", hidden");
                }
            }
            // civ level only for provinces, not sublocations
            if (_myloc._LocId >= 10000 && _myloc._LocId < 18000)
            {
                outline3.Append(", " + (_myloc._LO_Civ_Level.Equals(0) ? "wilderness" : "civ-" + _myloc._LO_Civ_Level));
            }
            outline3.Append("</H3>");
            w.WriteLine(outline3);
        }

        private static void Write_Controlled_By(Location _myloc, StreamWriter w)
        {
            // Print Province Controlled By
            if (_myloc._LI_Here_List != null)
            {
                foreach (String _my_inner in _myloc._LI_Here_List)
                {
                    Character _my_dest_char = Program._characters.Find(x => x._CharId == Convert.ToInt32(_my_inner));
                    if (_my_dest_char != null)
                    {
                        if (!_my_dest_char._MI_Garrison_Castle.Equals(0))
                        {
                            StringBuilder outline = new StringBuilder();
                            outline.Append("Province controlled by ");
                            Location _my_dest_loc = Program._locations.Find(x => x._LocId == Convert.ToInt32(_my_dest_char._MI_Garrison_Castle));
                            if (_my_dest_loc != null)
                            {
                                outline.Append(_my_dest_loc._Name + " ");
                                outline.Append(Utilities.format_anchor(_my_dest_loc._LocId_Conv));
                                outline.Append(", " + _my_dest_loc._Loc_Type);
                                Location _my_dest_loc2 = Program._locations.Find(x => x._LocId == Convert.ToInt32(_my_dest_loc._LI_Where));
                                if (_my_dest_loc2 != null)
                                {
                                    // see if in city.  If so, get province location
                                    if (!_my_dest_loc2._Loc_Type.Equals("city"))
                                    {
                                        outline.Append(" in ");
                                        outline.Append(_my_dest_loc2._Name + " ");
                                        outline.Append(Utilities.format_anchor(_my_dest_loc2._LocId_Conv));
                                    }
                                    else
                                    {
                                        Location _my_dest_loc3 = Program._locations.Find(x => x._LocId == Convert.ToInt32(_my_dest_loc2._LI_Where));
                                        if (_my_dest_loc3 != null)
                                        {
                                            outline.Append(" in ");
                                            outline.Append(_my_dest_loc3._Name + " ");
                                            outline.Append("[" + _my_dest_loc3._LocId_Conv + "]");
                                        }
                                    }
                                }
                            }
                            w.WriteLine(outline);
                            outline.Clear();
                            //// ruled by
                            // not doing for now because I'll have to follow the pledge chain
                            if (_my_dest_loc._LI_Here_List != null)
                            {
                                Character _my_dest_char2 = Program._characters.Find(x => x._CharId == Convert.ToInt32(_my_dest_loc._LI_Here_List[0]));
                                if (_my_dest_char2 != null)
                                {
                                    outline.Append("<br>Ruled by ");
                                    outline.Append("'too lazy to calculate for now'");
                                    //outline.Append(_my_dest_char2._Name);
                                    //outline.Append("," + _my_dest_char2._CH_Rank);
                                    w.WriteLine(outline);
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        private static void Write_Routes_Out(Location _myloc, StreamWriter w)
        {
            // Print Routes Out
            //if (!_myloc._Loc_Type.Contains("city"))
            if (_myloc._LocId >= 10000 && _myloc._LocId < 18000)
            {
                if (_myloc._LO_Province_Destination != null)
                {
                    Write_Province_Destinations_HTML(_myloc, w);
                }
            }
            else
            {
                w.WriteLine("<H4>Routes leaving " + _myloc._Name + ":</H4>");
                StringBuilder outline = new StringBuilder();
                w.WriteLine("<ul>");
                if (_myloc._Loc_Type.Contains("city"))
                {
                    // to ocean provinces (city province can't be a mountain)
                    if (!Program._locations.Find(x => x._LocId == _myloc._LI_Where)._Loc_Type.Equals("mountain"))
                    {
                        Location _locations1 = Program._locations.Find(x => x._LocId == _myloc._LI_Where);
                        int dest_count = -1;
                        foreach (int _destloc in _locations1._LO_Province_Destination)
                        {
                            dest_count++;
                            if (Program._locations.Find(x => x._LocId == _destloc)._Loc_Type.Equals("ocean"))
                            {
                                outline.Append("<li>");
                                string direction;
                                switch (dest_count)
                                {
                                    case 0: direction = "North"; break;
                                    case 1: direction = "East"; break;
                                    case 2: direction = "South"; break;
                                    case 3: direction = "West"; break;
                                    default: direction = "Undefined"; break;
                                }
                                outline.Append(direction);
                                outline.Append(", to ");
                                outline.Append(Program._locations.Find(x => x._LocId == _destloc)._Name + " ");
                                outline.Append(Utilities.format_anchor((Program._locations.Find(x => x._LocId == _destloc)._LocId_Conv)));
                                // get region name
                                outline.Append(", " + Program._locations.Find(y => y._LocId == Program._locations.Find(x => x._LocId == _destloc)._LI_Where)._Name);
                                outline.Append(", 1 day");
                                outline.Append("</li>");
                            }
                        }
                    }
                }
                // to province
                outline.Append("<li>");
                outline.Append("Out, to ");
                outline.Append(Program._locations.Find(x => x._LocId == _myloc._LI_Where)._Name + " ");
                outline.Append(Utilities.format_anchor(Program._locations.Find(x => x._LocId == _myloc._LI_Where)._LocId_Conv));
                outline.Append(", 1 day");
                outline.Append("</li>");
                w.WriteLine(outline);
                w.WriteLine("</ul>");
            }
        }

        private static void Write_Nearby_Cities(Location _myloc, StreamWriter w)
        {
            // cities near by
            if (_myloc._SL_Near_Cities != null)
            {
                w.WriteLine("<H4>Cities rumored to be nearby:</H4>");
                w.WriteLine("<ul>");
                foreach (String locationnb in _myloc._SL_Near_Cities)
                {
                    StringBuilder outline = new StringBuilder();
                    Location _nearby_city = Program._locations.Find(x => x._LocId == Convert.ToInt32(locationnb));
                    Location _city_province = Program._locations.Find(x => x._LocId == _nearby_city._LI_Where);
                    outline.Append("<li>");
                    outline.Append(_nearby_city._Name + " ");
                    outline.Append(Utilities.format_anchor(_nearby_city._LocId_Conv));
                    outline.Append(", in " + _city_province._Name + " ");
                    outline.Append(Utilities.format_anchor(_city_province._LocId_Conv));
                    outline.Append("</li>");
                    w.WriteLine(outline);
                }
                w.WriteLine("</ul>");
            }
        }

        private static void Write_Skills_Report(Location _myloc, StreamWriter w)
        {
            // Skills
            if (_myloc._SL_Teaches != null)
            {
                w.WriteLine("<H4>Skills taught here:</H4>");
                w.WriteLine("<ul>");
                foreach (String skill in _myloc._SL_Teaches)
                {
                    Skill _myskill = Program._skills.Find(x => x._SkillId == Convert.ToInt32(skill));
                    w.WriteLine("<li>" + _myskill._Name + " [" + skill + "]</li>");
                }
                w.WriteLine("</ul>");
            }
        }

        private static void Write_Market_Report(Location _myloc, StreamWriter w)
        {
            // Market Report
            if (_myloc._Trade_List != null)
            {
                // create consolidated trade list (location and characters)
                List<Trade> _trades = new List<Trade>();
                int iterations = _myloc._Trade_List.Count / 8;
                for (int i = 0; i < iterations; i++)
                {
                    if (_myloc._Trade_List[(i * 8) + 0] == "1"
                    || _myloc._Trade_List[(i * 8) + 0] == "2")
                    {
                        Itemz _myitem = Program._items.Find(x=>x._ItemId == Convert.ToInt32(_myloc._Trade_List[(i*8)+1]));
                        if (_myitem != null)
                        {
                            _trades.Add(new Trade
                            {
                                _ItemId = _myitem._ItemId,
                                _ItemId_Conv = _myitem._ItemId_Conv,
                                _Who_id = _myloc._LocId,
                                _Who_id_Conv = _myloc._LocId_Conv,
                                _Who_Type = 1,
                                _Trade_Kind = Convert.ToInt32(_myloc._Trade_List[(i*8) + 0]),
                                _Number = Convert.ToInt32(_myloc._Trade_List[(i * 8) + 2]),
                                _Price = Convert.ToInt32(_myloc._Trade_List[(i * 8) + 3]),
                                _Weight = _myitem._Weight,
                                _Item_Name = _myitem._Name
                            });
                        }
                    }
                }
                List<Character> _chartradelist = Program._characters.FindAll(x=>x._LI_Where == _myloc._LocId && x._Trade_List != null);
                if (_chartradelist.Count > 0)
                {
                    foreach (Character _mychar in _chartradelist)
                    {
                        int iterations2 = _mychar._Trade_List.Count / 8;
                        for (int i = 0; i < iterations2; i++)
                        {
                            if (_mychar._Trade_List[(i * 8) + 0] == "1"
                            || _mychar._Trade_List[(i * 8) + 0] == "2")
                            {
                                Itemz _myitem = Program._items.Find(x => x._ItemId == Convert.ToInt32(_mychar._Trade_List[(i * 8) + 1]));
                                if (_myitem != null)
                                {
                                    _trades.Add(new Trade
                                    {
                                        _ItemId = _myitem._ItemId,
                                        _ItemId_Conv = _myitem._ItemId_Conv,
                                        _Who_id = _mychar._CharId,
                                        _Who_id_Conv = _mychar._CharId.ToString(),
                                        _Who_Type = 2,
                                        _Trade_Kind = Convert.ToInt32(_mychar._Trade_List[(i * 8) + 0]),
                                        _Number = Convert.ToInt32(_mychar._Trade_List[(i * 8) + 2]),
                                        _Price = Convert.ToInt32(_mychar._Trade_List[(i * 8) + 3]),
                                        _Weight = _myitem._Weight,
                                        _Item_Name = _myitem._Name
                                    });
                                }
                            }
                        }
                    }
                }
                List<Trade> _trades_sorted = _trades.OrderBy(z => z._Trade_Kind).ThenBy(a=>a._Who_id_Conv).ThenBy(b => b._ItemId_Conv).ToList();
                //  write report
                w.WriteLine("<H4>Market Report:</H4>");
                w.WriteLine("<table border=\"1\" cellpadding=\"5\">");
                w.WriteLine("<tr><th>trade</th><th>who</th><th>price</th><th>qty</th><th>wt/ea</th><th>item</th></tr>");
                foreach (Trade _mytrade in _trades_sorted)
                {
                        StringBuilder outline = new StringBuilder();
                        outline.Append("<tr><td>");
                        outline.Append(_mytrade._Trade_Kind == 1 ? "buy" : "sell");
                        outline.Append("</td><td>");
                        outline.Append(_mytrade._Who_id_Conv);
                        outline.Append("</td><td>");
                        outline.Append(_mytrade._Price);
                        outline.Append("</td><td>");
                        outline.Append(_mytrade._Number);
                        outline.Append("</td><td>");
                        outline.Append(_mytrade._Weight);
                        outline.Append("</td><td>");
                        outline.Append(_mytrade._Item_Name + " [" + _mytrade._ItemId_Conv + "]");
                        outline.Append("</td></tr>");
                        w.WriteLine(outline);
                }
                w.WriteLine("</Table>");
            }
        }

        public static void Write_Province_Destinations_HTML(Location _myloc, StreamWriter w)
        {
            w.WriteLine("<H4>Routes leaving " + _myloc._Name + ":</H4>");
            w.WriteLine("<ul>");
            if (_myloc._LO_Province_Destination.Count.CompareTo(0) > 0)
            {
                if (_myloc._LO_Province_Destination[0] != 0)
                {
                    Write_Province_Destination_HTML(_myloc._LO_Province_Destination[0], w, "North", _myloc._Loc_Type);
                }
            }
            if (_myloc._LO_Province_Destination.Count.CompareTo(1) > 0)
            {
                if (_myloc._LO_Province_Destination[1] != 0)
                {
                    Write_Province_Destination_HTML(_myloc._LO_Province_Destination[1], w, "East", _myloc._Loc_Type);
                }
            }
            if (_myloc._LO_Province_Destination.Count.CompareTo(2) > 0)
            {
                if (_myloc._LO_Province_Destination[2] != 0)
                {
                    Write_Province_Destination_HTML(_myloc._LO_Province_Destination[2], w, "South", _myloc._Loc_Type);
                }
            }
            if (_myloc._LO_Province_Destination.Count.CompareTo(3) > 0)
            {
                if (_myloc._LO_Province_Destination[3] != 0)
                {
                    Write_Province_Destination_HTML(_myloc._LO_Province_Destination[3], w, "West", _myloc._Loc_Type);
                }
            }
            if (_myloc._LO_Province_Destination.Count.CompareTo(4) > 0)
            {
                if (_myloc._LO_Province_Destination[4] != 0)
                {
                    Write_Province_Destination_HTML(_myloc._LO_Province_Destination[4], w, "Up", _myloc._Loc_Type);
                }
            }
            if (_myloc._LO_Province_Destination.Count.CompareTo(5) > 0)
            {
                if (_myloc._LO_Province_Destination[5] != 0)
                {
                    Write_Province_Destination_HTML(_myloc._LO_Province_Destination[5], w, "Down", _myloc._Loc_Type);
                }
            }
            w.WriteLine("</ul>");
        }

        public static void Write_Characters_HTML(Character _myChar, StreamWriter w)
        {
            StringBuilder outline = new StringBuilder();
            outline.Append("<li>");
            outline.Append(_myChar._Name + " ");
            outline.Append(Utilities.format_anchor(_myChar._CharId.ToString()));
            if (!_myChar._Char_Type.Equals("0"))
            {
                outline.Append(", " + _myChar._Char_Type);
            }
            if (_myChar._CH_Guard != null)
            {
                if (_myChar._CH_Guard.Equals("1"))
                {
                    outline.Append(", on guard");
                }
            }
            //concealed
            if (_myChar._CM_Hide_Self != null)
            {
                if (_myChar._CM_Hide_Self.Equals("1"))
                {
                    outline.Append(", concealed (maybe)");
                }
            }
            // get possessions
            if (_myChar._Item_List != null)
            {
                int num_items = _myChar._Item_List.Count / 2;
                for (int i = 0; i < num_items; i++)
                {
                    if (Program._items.Find(x => x._ItemId == _myChar._Item_List[Convert.ToInt32((i * 2) + 0)])._IT_Prominent == "1")
                    {
                        outline.Append(", " + _myChar._Item_List[(i * 2) + 1] + " " + 
                            (Convert.ToInt32(_myChar._Item_List[(i * 2) + 1]) == 1 ?
                            Program._items.Find(x => x._ItemId == _myChar._Item_List[Convert.ToInt32((i * 2) + 0)])._Name : 
                            Program._items.Find(x => x._ItemId == _myChar._Item_List[Convert.ToInt32((i * 2) + 0)])._Plural));
                    }
                }
            }
            if (_myChar._LI_Here_List != null)
            {
                outline.Append(", accompanied by: ");
            }
            outline.Append("</li>");
            w.WriteLine(outline);
            if (_myChar._LI_Here_List != null)
            {
                w.WriteLine("<ul>");
                foreach (String _my_stacked_charid in _myChar._LI_Here_List)
                {
                    Character _my_stacked_char = Program._characters.Find(x => x._CharId == Convert.ToInt32(_my_stacked_charid));
                    Write_Characters_HTML(_my_stacked_char,w);
                }
                w.WriteLine("</ul>");
            }
        }
        public static void Write_Here_List_HTML(Location _myloc, StreamWriter w)
        {
            Boolean print_inner = false;
            Boolean seen_here = false;
            Boolean ships_docked = false;
            // Determine if Inner Locations/Seen Here
            foreach (String _my_inner in _myloc._LI_Here_List)
            {
                Location _my_dest_loc = Program._locations.Find(x => x._LocId == Convert.ToInt32(_my_inner));
                if (_my_dest_loc != null)
                {
                    print_inner = true;
                }
                else
                {
                    Character _my_dest_char = Program._characters.Find(x => x._CharId == Convert.ToInt32(_my_inner));
                    if (_my_dest_char != null)
                    {
                        seen_here = true;
                    }
                    else
                    {
                        Ship _my_dest_ship = Program._ships.Find(x => x._ShipId == Convert.ToInt32(_my_inner));
                        if (_my_dest_ship != null)
                        {
                            ships_docked = true;
                        }
                        else
                        {
                            Storm _my_dest_storm = Program._storms.Find(x => x._StormId == Convert.ToInt32(_my_inner));
                            if (_my_dest_storm != null)
                            {
                                // storm
                            }
                            else
                            {
                                Console.WriteLine("What is this? {0}", _my_inner);
                            }
                        }
                    }
                }
            }
            if (print_inner)
            {
                w.WriteLine("<H4>Inner Locations:</H4>");
                w.WriteLine("<ul>");
                print_inner = true;
                foreach (String _my_inner in _myloc._LI_Here_List)
                {
                    Location _my_dest_loc = Program._locations.Find(x => x._LocId == Convert.ToInt32(_my_inner));
                    if (_my_dest_loc != null)
                    {
                        Write_Sub_Locs_HTML(_myloc, w, _my_dest_loc);
                    }
                    //else
                    //{
                    //    break;
                    //}
                }
                w.WriteLine("</ul>");
            }
            if (seen_here)
            {
                w.WriteLine("<H4>Seen Here:</H4>");
                w.WriteLine("<ul>");
                print_inner = true;
                foreach (String _my_inner in _myloc._LI_Here_List)
                {
                    Character _my_char = Program._characters.Find(x => x._CharId == Convert.ToInt32(_my_inner));
                    if (_my_char != null)
                    { 
                        Write_Characters_HTML(_my_char, w);
                    }
                }
                w.WriteLine("</ul>");
            }
            if (ships_docked)
            {
                w.WriteLine("<H4>Ships docked at port:</H4>");
                w.WriteLine("<ul>");
                print_inner = true;
                foreach (String _my_inner in _myloc._LI_Here_List)
                {
                    Ship _my_ship = Program._ships.Find(x => x._ShipId == Convert.ToInt32(_my_inner));
                    if (_my_ship != null)
                    {
                        Write_Ships_HTML(_my_ship, w);
                    }
                }
                w.WriteLine("</ul>");
            }
        }
        public static void Write_Hidden_Accesses_HTML(Location _myloc, StreamWriter w)
        {
            bool firstline = true;
            foreach (Player _myplayer in Program._players)
            { 
                if (_myplayer._Known != null)
                {
                    foreach (int _loc in _myplayer._Known)
                    {
                        if (_loc == _myloc._LocId)
                        {
                            if (firstline)
                            {
                                w.WriteLine("<H4>hidden location known by:</H4>");
                                w.WriteLine("<ul>");
                                firstline = false;
                            }
                            w.WriteLine("<li>" + _myplayer._Name + " [" + _myplayer._FactionId_Conv + "]</li>");
                        }
                    }
                }
            }
            if (!firstline)
            {
                w.WriteLine("</ul>");
            }
        }
        private static void Write_Sub_Locs_HTML(Location _myloc, StreamWriter w, Location _my_dest_loc)
        {
            StringBuilder outline = new StringBuilder();
            outline.Append("<li>");
            outline.Append(_my_dest_loc._Name);
            outline.Append(" ");
            outline.Append(Utilities.format_anchor(_my_dest_loc._LocId_Conv));
            outline.Append(", " + _my_dest_loc._Loc_Type);
            if (_my_dest_loc._LO_Hidden != null)
            {
                if (_my_dest_loc._LO_Hidden.Equals("1"))
                {
                    outline.Append(", hidden");
                }
            }
            if (!_myloc._Loc_Type.Contains("city"))
            {
                outline.Append(", 1 day");
            }
            // defense
            if (_my_dest_loc._SL_Defense != 0)
            {
                outline.Append(", defense " + _my_dest_loc._SL_Defense);
            }
            if (_my_dest_loc._Loc_Type.Contains("castle"))
            {
                // level
                if (_my_dest_loc._SL_Castle_Level != null)
                {
                    outline.Append(", level " + _my_dest_loc._SL_Castle_Level);
                }
            }
            if (_my_dest_loc._Loc_Type.Contains("mine"))
            {
                // level
                if (_my_dest_loc._SL_Shaft_Depth != null)
                {
                    outline.Append(", level " + _my_dest_loc._SL_Shaft_Depth);
                }
            }
            // % completed
            if (_my_dest_loc._SL_Effort_Given != 0 && _my_dest_loc._SL_Effort_Required != 0)
            {
                float pctComp = ((float)_my_dest_loc._SL_Effort_Given / (float)_my_dest_loc._SL_Effort_Required) * (float)100;
                outline.Append(", " + Convert.ToInt32(pctComp) + "% completed");
            }
            // damage
            if (_my_dest_loc._SL_Damage != 0)
            {
                outline.Append(", " + _my_dest_loc._SL_Damage + "% damaged");
                // what about collapsed??
            }
            // owner
            if (Program._locations.Find(x => x._LocId == _myloc._LI_Where)._Loc_Type.Equals("region"))
            {
                outline.Append("</li>");
                w.WriteLine(outline);
            }
            else
            {
                if (_my_dest_loc._LI_Here_List != null)
                {
                    outline.Append(", owner: ");
                }
                outline.Append("</li>");
                w.WriteLine(outline);
                // check for inner locations and/or characters
                if (_my_dest_loc._LI_Here_List != null)
                {
                    w.WriteLine("<ul>");
                    foreach (String _my_inner in _my_dest_loc._LI_Here_List)
                    {
                        Location _my_dest_loc2 = Program._locations.Find(x => x._LocId == Convert.ToInt32(_my_inner));
                        if (_my_dest_loc2 != null)
                        {
                            Write_Sub_Locs_HTML(_myloc, w, _my_dest_loc2);
                        }
                        else
                        {
                            Character _my_char_loc2 = Program._characters.Find(x => x._CharId == Convert.ToInt32(_my_inner));
                            if (_my_char_loc2 != null)
                            {
                                Write_Characters_HTML(_my_char_loc2, w);
                            }
                            else
                            {
                                Ship _my_ship_loc2 = Program._ships.Find(x => x._ShipId == Convert.ToInt32(_my_inner));
                                if (_my_ship_loc2 != null)
                                {
                                    Write_Ships_HTML(_my_ship_loc2, w);
                                }
                                else
                                {
                                    Storm _my_storm_loc2 = Program._storms.Find(x => x._StormId == Convert.ToInt32(_my_inner));
                                    if (_my_storm_loc2 != null)
                                    {
                                        //Write_Storms_HTML(_my_ship_loc2, w);
                                    }
                                    else
                                    {
                                        Console.WriteLine("What is it?? {0}", _my_inner);
                                    }
                                }
                            }
                        }
                    }
                    w.WriteLine("</ul>");
                }
            }
        }

        public static void Write_Province_Destination_HTML(Int32 destination_location, StreamWriter w, String dest, String from_type)
        {
            StringBuilder outline = new StringBuilder();
            Location _my_dest_loc = Program._locations.Find(x => x._LocId == destination_location);
            outline.Append("<li>");
            outline.Append(dest);
            if (_my_dest_loc._Loc_Type.Contains("city"))
            {
                outline.Append(", city");
            }
            outline.Append(", to ");
            outline.Append(_my_dest_loc._Name + " ");
            outline.Append(Utilities.format_anchor(_my_dest_loc._LocId_Conv));
            // determine days to move
            if (from_type == "ocean")
            {
                if (_my_dest_loc._Loc_Type == "ocean")
                {
                    outline.Append(", 3 days");
                }
                else
                {
                    if ((_my_dest_loc._Loc_Type.Contains("city")))
                    {
                        outline.Append(", ");
                        outline.Append(Program._locations.Find(x => x._LocId == _my_dest_loc._LI_Where)._Name);
                        outline.Append(", 1 day");
                    }
                    else
                    {
                        outline.Append(", ");
                        outline.Append(Program._locations.Find(x => x._LocId == _my_dest_loc._LI_Where)._Name);
                        if (_my_dest_loc._Loc_Type == "mountain")
                        {
                            outline.Append(", impassible");
                        }
                        else
                        {
                            outline.Append(", 2 days");
                        }
                    }
                }
            }
            else
            {
                if (_my_dest_loc._Loc_Type == "plain")
                {
                    outline.Append(", 7 days");
                }
                else
                {
                    if (_my_dest_loc._Loc_Type == "forest")
                    {
                        outline.Append(", 8 days");
                    }
                    else
                    {
                        if (_my_dest_loc._Loc_Type == "mountain")
                        {
                            outline.Append(", 10 days");
                        }
                        else
                        {
                            if (_my_dest_loc._Loc_Type == "swamp")
                            {
                                outline.Append(", 14 days");
                            }
                            else
                            {
                                if (_my_dest_loc._Loc_Type == "desert")
                                {
                                    outline.Append(", 8 days");
                                }
                                else
                                {
                                    if (_my_dest_loc._Loc_Type == "ocean")
                                    {
                                        outline.Append(", ");
                                        outline.Append(Program._locations.Find(x => x._LocId == _my_dest_loc._LI_Where)._Name);
                                        if (from_type == "mountain")
                                        {
                                            outline.Append(", impassible");
                                        }
                                        else
                                        {
                                            // see if contains city, if so, impassible
                                            Boolean contains_city = false;
                                            foreach (int destloc in _my_dest_loc._LO_Province_Destination)
                                            {
                                                if ((Program._locations.Find(x => x._LocId == destloc)._Loc_Type.Contains("city")))
                                                {
                                                    contains_city = true;
                                                }
                                            }
                                            if (!contains_city)
                                            {
                                                outline.Append(", 2 days");
                                            }
                                            else
                                            {
                                                outline.Append(", impassible");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //Console.WriteLine("undefined: " + _my_dest_loc._Loc_Type);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            outline.Append("</li>");
            w.WriteLine(outline);
            // check to see if was moving to city from ocean
            // if so, need to write impassible line
            if (from_type.Contains("ocean") && _my_dest_loc._Loc_Type.Contains("city"))
            {
                StringBuilder outlinein = new StringBuilder();
                Location _my_dest_locin = Program._locations.Find(x => x._LocId == _my_dest_loc._LI_Where);
                outlinein.Append("<li>");
                outlinein.Append(dest);
                outlinein.Append(", to ");
                outlinein.Append(_my_dest_locin._Name + " ");
                outlinein.Append(Utilities.format_anchor(_my_dest_locin._LocId_Conv));
                outlinein.Append(", ");
                outlinein.Append(Program._locations.Find(x => x._LocId == _my_dest_locin._LI_Where)._Name);
                outlinein.Append(", impassible");
                outlinein.Append("</li>");
                w.WriteLine(outlinein);
            }
        }
        public static void Write_Ships_HTML(Ship _myship, StreamWriter w)
        {
            StringBuilder outline = new StringBuilder();
            outline.Append("<li>");
            outline.Append(_myship._Name);
            outline.Append(" " + Utilities.format_anchor(_myship._ShipId.ToString()));
            outline.Append(", " + _myship._Ship_Type);
            // bound storm
            if (_myship._SL_Bound_Storm != 0)
            {
                outline.Append(", Storm " + _myship._SL_Bound_Storm);
            }
            // loaded
            // defense
            if (_myship._SL_Defense != 0)
            {
                outline.Append(", defense " + _myship._SL_Defense);
            }
            // % completed
            if (_myship._SL_Effort_Given != 0 && _myship._SL_Effort_Required != 0)
            {
                float pctComp = ((float)_myship._SL_Effort_Given / (float)_myship._SL_Effort_Required) * (float)100;
                outline.Append(", " + (Convert.ToInt32(pctComp)) + "% completed");
            }
            // damage
            if (_myship._SL_Damage != 0)
            {
                outline.Append(", " + _myship._SL_Damage + "% damaged");
            }

            // owner
            if (_myship._LI_Here_List != null)
            {
                outline.Append(", owner:");
            }
            outline.Append("</li>");
            w.WriteLine(outline);
            if (_myship._LI_Here_List != null)
            {
                w.WriteLine("<ul>");
                foreach (int _charid in _myship._LI_Here_List)
                {
                    Character _my_char = Program._characters.Find(x => x._CharId == Convert.ToInt32(_charid));
                    if (_my_char != null)
                    {
                        Write_Characters_HTML(_my_char, w);
                    }
                    else
                    {
                        Console.WriteLine("Non-Character {0} in Ship {1}",_charid, _myship._ShipId);
                    }
                }
                w.WriteLine("</ul>");
            }
        }
        public static void Generate_Item_List_HTML()
        {
            using (FileStream fs = new FileStream(@"d:\Temp\turn163\master_item_list.html", FileMode.Create))
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
    }
}
