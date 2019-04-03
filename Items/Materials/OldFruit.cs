using Terraria.ID;
using Terraria.ModLoader;

namespace CasterMod.Items.Materials
{
	public class OldFruit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Old Fruit");
			Tooltip.SetDefault("Smells ripe...");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.value = 10000;
			item.rare = 3;
		}
	}
}
