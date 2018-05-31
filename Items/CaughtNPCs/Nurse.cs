using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.CaughtNPCs
{
	public class Nurse : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Nurse");
			Tooltip.SetDefault("'Show me where it hurts.'");
		}

		public override void SetDefaults()
		{			
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.rare = 1;
			item.useStyle = 1; 
			item.useAnimation = 15;
			item.useTime = 10;
			item.consumable = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item44; 
			item.makeNPC = NPCID.Nurse;
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 23));
		}
		
		public override string Texture
		{
			get
			{
				return "Terraria/NPC_18";
			}
		}
	}
}