﻿using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Tiles
{
    public class ShadowCrate : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = 2;
            item.maxStack = 99;
            item.useAnimation = 15;
            item.useTime = 15;
            item.autoReuse = true;
            item.useStyle = 1;
            item.consumable = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.createTile = mod.TileType("ShadowCrateSheet");
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Crate");
            Tooltip.SetDefault("Right click to open");
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if(Main.rand.Next(6) == 0)
            {
                int index = Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("ShadowLockBox"), 1, false, -1, false, false);

                if (Main.netMode == 1)
                {
                    NetMessage.SendData(21, -1, -1, null, index, 1f, 0f, 0f, 0, 0, 0);
                }
            }
            
            //bypass all checks and spawn defaults
            player.openCrate(4000);
        }
    }
}