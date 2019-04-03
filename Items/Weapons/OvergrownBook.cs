using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod.Items.Weapons
{
	public class OvergrownBook : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Overgrown Book");
            Tooltip.SetDefault("Vile");
        }
        public override void SetDefaults()
		{
			item.damage = 27;
            item.mana = 8;
            item.melee = true;
			item.width = 28;
			item.height = 30;
			item.useTime = 10;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 50000;
			item.rare = 4;
			item.UseSound = SoundID.Item8;
            item.shootSpeed = 30;
            item.shoot = 7;
            item.autoReuse = true;

        }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(521, 15);
            recipe.AddIngredient(ItemID.Vine, 5);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(ItemID.Vilethorn, 1);
            recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
