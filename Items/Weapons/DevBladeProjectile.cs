using System;

using System.ComponentModel;

using System.Reflection;

using Terraria.ID;

using Terraria.ModLoader;



namespace VexysCrazyPack.Items.Weapons

{

    public class DevBladeProjectile : ModProjectile

    {
        public override void SetDefaults()

        {

            projectile.Name = "DevBladeProjectile";

            projectile.width = 20;

            projectile.height = 30;

            projectile.friendly = true;

            projectile.melee = true;

            projectile.tileCollide = true;

            projectile.penetrate = 10;

            projectile.timeLeft = 250;

            projectile.light = 0.8f;

            projectile.extraUpdates = 1;

            projectile.ignoreWater = true;

        }

        public override void AI()

        {

            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;

        }

    }

}