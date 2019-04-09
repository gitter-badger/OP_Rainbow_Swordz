using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OP_Rainbow_Swordz.Items.Weapons.Melee
{
	public class OP_Sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("OP Rainbow Sword");
			Tooltip.SetDefault("This is a cheat sword! Look at the damage!!");
		}
		public override void SetDefaults()
		{
			item.damage = 90000000;
			item.melee = true;
			item.width = 3450;
			item.height = 3450;
			item.useTime = 999;
			item.useAnimation = 5;
			item.useStyle = 1; // Swinging
			item.knockBack = 999;
			item.value = 100000000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
