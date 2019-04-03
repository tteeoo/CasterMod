using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod.Items.Weapons
{
	public class Banana : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Banana");
            Tooltip.SetDefault("Banana");
        }
        public override void SetDefaults()
		{
			item.damage = 34;
			item.melee = true;
			item.width = 24;
			item.height = 33;
			item.useTime = 15;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 30000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
            item.shootSpeed = 10;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType<Projectiles.BananaProjectile>();

        }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("OldFruit"), 1);
            recipe.AddIngredient(ItemID.GoldenKey, 3);
            recipe.AddIngredient(ItemID.PurificationPowder, 10);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
