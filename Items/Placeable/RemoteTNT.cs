using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OP_Rainbow_Swordz.Items.Placeable
{
	public class RemoteTNT : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Remote TNT");
			Tooltip.SetDefault("Use with TNT detonator.");
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 5;
			item.useTime = 5;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TileTNT");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.DirtBlock, 1);
			recipe2.SetResult(this, 1); // Just if you want 1 and not 999!
			recipe2.AddRecipe();
		}
	}
}