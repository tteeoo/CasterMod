using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod.Items.Weapons
{
	public class ForgottenSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten Sword");
			Tooltip.SetDefault("What's this?");
		}
		public override void SetDefaults()
		{
			item.damage = 666;
			item.melee = true;
			item.width = 54;
			item.height = 54;
			item.useTime = 40;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 99999;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		//public override void AddRecipes()
		//{
		//	ModRecipe recipe = new ModRecipe(mod);
		//	recipe.AddIngredient(ItemID.DirtBlock, 10);
		//	recipe.AddTile(TileID.WorkBenches);
		//	recipe.SetResult(this);
		//	recipe.AddRecipe();
		//}
	}
}
