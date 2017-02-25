using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlyMapper
{
    class Stack
    {
        public int _entityid { get; set; }
        public string _entity_type { get; set; }
        public int _entity_level { get; set; }
        public static Stack Add(int entity_id, string loc, int level)
        {
            Stack stack_entry = new Stack
            {
                _entityid = entity_id,
                _entity_type = loc,
                _entity_level = level
            };
            return stack_entry;
        }
        public static List<Stack> chase_structure(int entity_id, List<Stack> stack_list, int level)
        {
            if (Program._locations.Find(x => x._LocId == entity_id) != null)
            {
                stack_list.Add(Add(entity_id, "loc", level));
                Location myloc = Program._locations.Find(x => x._LocId == entity_id);
                if (myloc._LI_Here_List != null)
                {
                    level++;
                    foreach (string loc in myloc._LI_Here_List)
                    {
                        stack_list = chase_structure(Convert.ToInt32(loc), stack_list, level);
                    }
                }
            }
            else
            {
                if (Program._characters.Find(x => x._CharId == entity_id) != null)
                {
                    stack_list.Add(Add(entity_id, "char", level));
                    Character mychar = Program._characters.Find(x => x._CharId == entity_id);
                    if (mychar._LI_Here_List != null)
                    {
                        level++;
                        foreach (string chars in mychar._LI_Here_List)
                        {
                            stack_list = chase_structure(Convert.ToInt32(chars), stack_list, level);
                        }
                    }
                }
                else
                {
                    if (Program._ships.Find(x => x._ShipId == entity_id) != null)
                    {
                        stack_list.Add(Add(entity_id, "ship", level));
                        Ship myship = Program._ships.Find(x => x._ShipId == entity_id);
                        if (myship._LI_Here_List != null)
                        {
                            level++;
                            foreach (int ship in myship._LI_Here_List)
                            {
                                stack_list = chase_structure(ship, stack_list, level);
                            }
                        }
                    }
                    else
                    {
                        stack_list.Add(Add(entity_id, "unknown", level));
                    }
                }
            }
            return stack_list;
        }
    }
}
