using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod.Items.Weapons
{
	public class BreadBlade : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bread Blade");
            Tooltip.SetDefault("Pain");
        }
        public override void SetDefaults()
		{
			item.damage = 19;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 50000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
            item.shootSpeed = 18;
            item.shoot = mod.ProjectileType<Projectiles.BreadBladeProjectile>();

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
