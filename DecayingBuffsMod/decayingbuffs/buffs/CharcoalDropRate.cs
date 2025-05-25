using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;
using Vintagestory.API.Client;
using Vintagestory.API.MathTools;
using Vintagestory.Common;

namespace DecayingBuffsMod.decayingbuffs.buffs
{
    //Class to handle charcoal drop rate.
    internal class CharcoalDropRate : BlockBehavior
    {
        //Constructor so class declaration works.
        public CharcoalDropRate(Block block) : base(block)
        {
        }

        //Override GetDrops().
        public override ItemStack[] GetDrops(IWorldAccessor world, BlockPos pos, IPlayer byPlayer, ref float dropChanceMultiplier, ref EnumHandling handling)
        {

            //NOTE: This code belongs in bands for ineracting, not here. Move it later.
            //Get current slot from hotbar.
            ItemSlot currentSlot = byPlayer.InventoryManager.ActiveHotbarSlot;

            if (currentSlot == null) 
            {
                return base.GetDrops(world, pos, byPlayer, ref dropChanceMultiplier, ref handling);
            }
            if (currentSlot != null)
            {
                
            }
            return new ItemStack[0];
        }
    }   
 }
