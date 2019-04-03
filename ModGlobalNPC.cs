using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(80) == 0)
            {
                if (npc.type == NPCID.Zombie)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Vermilion"));
                }
            }
            if (Main.rand.Next(200) == 0)
            {
                if (npc.type == NPCID.Skeleton)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OldFruit"));
                }
                if (npc.type == NPCID.AngryBones)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OldFruit"));
                }
            }
        }
    }
}