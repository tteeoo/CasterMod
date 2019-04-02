using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace teosterrariamod.Items.Projectiles
{
    public class BreadBladeProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 50;
            projectile.aiStyle = 9;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.melee = true;
            projectile.scale = 1f;

        }

    }
}