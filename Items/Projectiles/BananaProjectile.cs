using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace CasterMod.Items.Projectiles
{
    public class BananaProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 33;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.penetrate = 2;
            projectile.melee = true;
            projectile.scale = 1f;
            
        }
        public override void AI()
        {

           
            if (Main.rand.Next(5) == 0) // only spawn 20% of the time
            {
                int choice = Main.rand.Next(3); // choose a random number: 0, 1, or 2
                if (choice == 0) // use that number to select dustID: 15, 57, or 58
                {
                    choice = 18;
                }
                else if (choice == 1)
                {
                    choice = 19;
                }
                else
                {
                    choice = 32;
                }
                // Spawn the dust
                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
            }
        }

    }
}