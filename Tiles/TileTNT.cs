using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OP_Rainbow_Swordz.Tiles
{
	public class TileTNT : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("ExampleBlock");
			AddMapEntry(new Color(200, 200, 200));
			SetModTree(new ExampleTree());
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			r = 0.1f;
			g = 0.1f;
			b = 0.1f;
		}
	}
}