using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Datastructures;
using Vintagestory.GameContent;

namespace DecayingBuffsMod.decayingbuffs.items
{
    //Class to handle the application of buffs to items in jsons.
    internal class Buffs : ItemWearable
    {

        //Declare dictionary to hold items.

        /*private Dictionary<string, Item> _items = new()
        {
            {"blankBadge", new Item() },
            {"charcoalBadge", new Item() },
            {"healthBadge", new Item() },
        };

        private Dictionary<int, string> _buffs = new()
        {
            {1, "blank" },
            {2, "charcoalDrop" },
            {3, "maxHealth" },

        };
        //Methods to get dictionary entries.
        private Item GetItemsEntry(string loc)
        {
            return _items[loc];
        }

        private string GetBuffsEntry(int loc)
        {
            return _buffs[loc];
        }*/



        enum BuffsEnum
        {
            Blank,
            Charcoal,
            Health,
            Speed
        }

        enum ItemNames
        {
            BlankBadge,
            CharcoalBadge,
            HealthBadge,
            SpeedBadge
        }



        //Methods to handle switch case with enums.
        private BuffsEnum HandleEnum(BuffsEnum buffsLocal)
        {
            switch (buffsLocal)
            {
                case BuffsEnum.Charcoal:
                    return BuffsEnum.Charcoal;
                case BuffsEnum.Health:
                    return BuffsEnum.Health;
            }
            return BuffsEnum.Blank;

           
        }

        private ItemNames HandleEnum(ItemNames namesLocal)
        {
            switch (namesLocal)
            {
                case ItemNames.CharcoalBadge:
                    return ItemNames.CharcoalBadge;
            }
            return ItemNames.BlankBadge;
        }

        //Override GetHeldItemInfo.
        public override void GetHeldItemInfo(ItemSlot inSlot, StringBuilder dsc, IWorldAccessor world, bool withDebugInfo)
        {
            //base.GetHeldItemInfo(inSlot, dsc, world, withDebugInfo);
            

        }
        
        //Override OnHeldInteractStart to wear the item on right click.
        public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, bool firstEvent, ref EnumHandHandling handling)
        {
            //base.OnHeldInteractStart(slot, byEntity, blockSel, entitySel, firstEvent, ref handling);

            if(byEntity.Controls.LeftMouseDown)
            {
                if (HandleEnum(ItemNames.CharcoalBadge) == ItemNames.CharcoalBadge)
                {
                    
                }
            }
            
            
        }

    }
}
