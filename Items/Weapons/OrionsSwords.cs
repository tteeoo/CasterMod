using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod.Items.Weapons
{
	public class OrionsSword : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orion's Sword");
            Tooltip.SetDefault("Left Click - Crystals, Right Click - High Powered Star");
        }
        public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 12;
			item.useStyle = 3;
			item.knockBack = 3;
			item.value = 80000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
            item.shootSpeed = 16;
            item.shoot = 94;
            item.autoReuse = true;

        }
        //public void OnKill()
        //{

        //}

        public override void AddRecipes()
        {
        	ModRecipe recipe = new ModRecipe(mod);
        	recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.AddIngredient(ItemID.CrystalStorm, 1);
            recipe.AddIngredient(ItemID.CrystalShard, 10);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.MythrilAnvil);
        	recipe.SetResult(this);
        	recipe.AddRecipe();
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {

                item.useTime = 70;
                item.useAnimation = 70;
                item.damage = 230;
                item.useStyle = 1;
                item.shoot = 9;
                item.autoReuse = false;


            }
            else
            {
                item.damage = 45;
                item.melee = true;
                item.width = 40;
                item.height = 40;
                item.useTime = 17;
                item.useAnimation = 12;
                item.useStyle = 3;
                item.knockBack = 3;
                item.value = 88800;
                item.rare = 4;
                item.UseSound = SoundID.Item1;
                item.shootSpeed = 30;
                item.shoot = 94;
                item.autoReuse = true;
            }
            return base.CanUseItem(player);
        }
    }
}
