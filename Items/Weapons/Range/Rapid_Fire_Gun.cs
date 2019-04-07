using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OP_Rainbow_Swordz.Items.Weapons.Range
{
	public class Rapid_Fire_Gun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rapid Fire Gun");
			Tooltip.SetDefault("This is a cheat Fire Gun! It's super quick.\nUses fire arrows even if you don't have any, also doesn't consume ammo.");
		}
		public override void SetDefaults() {
			item.damage = 2000;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 1;
			item.useAnimation = 5;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 999;
			item.value = 90000000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.FireArrow;
			item.shootSpeed = 6f;
			item.scale = 1.5f;
			Main.NewText("Rapid Fire Gun!", 255, 255, 255, false);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override Vector2? HoldoutOffset() {
			return new Vector2(-4, 4);
		}
	}
}
