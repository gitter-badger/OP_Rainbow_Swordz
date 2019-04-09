using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OP_Rainbow_Swordz.Items
{
	public class TNTDetonator : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Remote TNT Detonator");
			Tooltip.SetDefault("Use with Remote TNT.\nUse to blow up all Remote TNT blocks.");
		}

		public override bool CanUseItem(Player player) {
			return true;
		}

		public override bool UseItem(Player player) {
			Main.NewText("Destruction incoming!!");
			return true;
		}


		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 4; // Holding up
			item.consumable = true;
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