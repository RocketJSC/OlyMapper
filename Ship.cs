using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Ship
    {
        public int _ShipId { get; set; }
        public string _Name { get; set; }
        public string _First_Line { get; set; }
        public string _Ship_Type { get; set; }
        public List<int> _LI_Here_List { get; set; }
        public int _LI_Where { get; set; }
        public int _SL_Damage { get; set; }
        public int _SL_Defense { get; set; }
        public int _SL_Capacity { get; set; }
        public string _SL_Moving { get; set; }
        public int _SL_Bound_Storm { get; set; }
        public int _SL_Effort_Required { get; set; }
        public int _SL_Effort_Given { get; set; }
        public string Calc_CurrentLoc { get; set; }
        public int Calc_CurrentRegion { get; set; }
        public static void Add(string InputKey, string InputString)
        {
            JObject j1 = JObject.Parse(InputString);
            JArray myfl;
            JArray myna;
            string mychartypea;
            string mychartype;
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
                mychartypea = myfl.ToString().Substring(myfl.ToString().IndexOf("ship ") + 5);
                mychartype = mychartypea.ToString().Substring(0, mychartypea.IndexOf("\""));
            }
            else
            {
                myfl = null;
                mychartypea = null;
                mychartype = null;
            }
            Program._ships.Add(new Ship
            {
                _ShipId = Convert.ToInt32(InputKey),
                _First_Line = myfl[0].ToString(),
                _Name = myna[0].ToString(),
                _Ship_Type = mychartype
            });
            var Ship = (Program._ships.Find(x => x._ShipId == Convert.ToInt32(InputKey)));
            if (Ship != null)
            {
                if (Ship._ShipId.Equals(Convert.ToInt32(InputKey)))
                {
                    if (j1.SelectToken("LI.hl") != null && j1.SelectToken("LI.hl").HasValues)
                    {
                        JArray myhl;
                        myhl = (JArray)j1.SelectToken("LI.hl");
                        List<int> myhla;
                        myhla = myhl.ToObject<List<int>>();
                        Ship._LI_Here_List = myhla.ToList();
                    }
                    if (j1.SelectToken("LI.wh") != null && j1.SelectToken("LI.wh").HasValues)
                    {
                        JArray mywh;
                        mywh = (JArray)j1.SelectToken("LI.wh");
                        Ship._LI_Where = Convert.ToInt32(mywh[0]);
                    }
                    Ship._SL_Damage = 0;
                    if (j1.SelectToken("SL.da") != null && j1.SelectToken("SL.da").HasValues)
                    {
                        JArray myda;
                        myda = (JArray)j1.SelectToken("SL.da");
                        Ship._SL_Damage = Convert.ToInt32(myda[0]);
                    }
                    Ship._SL_Defense = 0;
                    if (j1.SelectToken("SL.de") != null && j1.SelectToken("SL.de").HasValues)
                    {
                        JArray myde;
                        myde = (JArray)j1.SelectToken("SL.de");
                        Ship._SL_Defense = Convert.ToInt32(myde[0]);
                    }
                    Ship._SL_Capacity = 0;
                    if (j1.SelectToken("SL.ca") != null && j1.SelectToken("SL.ca").HasValues)
                    {
                        JArray myca;
                        myca = (JArray)j1.SelectToken("SL.ca");
                        Ship._SL_Capacity = Convert.ToInt32(myca[0]);
                    }
                    if (j1.SelectToken("SL.mo") != null && j1.SelectToken("SL.mo").HasValues)
                    {
                        JArray mymo;
                        mymo = (JArray)j1.SelectToken("SL.mo");
                        Ship._SL_Moving = mymo[0].ToString();
                    }
                    Ship._SL_Bound_Storm = 0;
                    if (j1.SelectToken("SL.bs") != null && j1.SelectToken("SL.bs").HasValues)
                    {
                        JArray mybs;
                        mybs = (JArray)j1.SelectToken("SL.bs");
                        Ship._SL_Bound_Storm = Convert.ToInt32(mybs[0]);
                    }
                    Ship._SL_Effort_Required = 0;
                    if (j1.SelectToken("SL.er") != null && j1.SelectToken("SL.er").HasValues)
                    {
                        JArray myer;
                        myer = (JArray)j1.SelectToken("SL.er");
                        Ship._SL_Effort_Required = Convert.ToInt32(myer[0]);
                    }
                    Ship._SL_Effort_Given = 0;
                    if (j1.SelectToken("SL.eg") != null && j1.SelectToken("SL.eg").HasValues)
                    {
                        JArray myeg;
                        myeg = (JArray)j1.SelectToken("SL.eg");
                        Ship._SL_Effort_Given = Convert.ToInt32(myeg[0]);
                    }
                }
            }
        }
        public static int determine_ship_weight(List<Stack> ship_stack)
        {
            int total_weight = 0;
            foreach (Stack stack_entry in ship_stack.Where(x => x._entity_type == "char"))
            {
                if (Program._characters.Find(x => x._CharId == stack_entry._entityid) != null)
                {
                    total_weight += Character.determine_unit_weights(Program._characters.Find(x => x._CharId == stack_entry._entityid))._total_weight;
                }
            }

            return total_weight;
        }
    }
}
