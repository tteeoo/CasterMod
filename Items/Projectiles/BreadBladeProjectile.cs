using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace CasterMod.Items.Projectiles
{
    public class BreadBladeProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 18;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.melee = true;
            projectile.scale = 1f;
            projectile.ignoreWater = true;
            
        }
        public virtual void OnTileCollide(Vector2 oldVelocity) {
			Main.PlaySound(SoundID.Item7, projectile.position);
		}
        public override void AI()
        {

            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2; // projectile sprite faces up
                                                                                         // or
            projectile.rotation = projectile.velocity.ToRotation();
            if (Main.rand.Next(5) == 0) // only spawn 20% of the time
            {
                int choice = Main.rand.Next(3); // choose a random number: 0, 1, or 2
                if (choice == 0) // use that number to select dustID: 15, 57, or 58
                {
                    choice = 0;
                }
                else if (choice == 1)
                {
                    choice = 7;
                }
                else
                {
                    choice = 9;
                }
                // Spawn the dust
                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
            }
        }

    }
}