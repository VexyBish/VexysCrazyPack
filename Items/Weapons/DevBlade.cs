using Terraria.ID;
using Terraria.ModLoader;

namespace VexysCrazyPack.Items.Weapons
{
	public class DevBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Gemsword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("The sword of the idiotic god that thought it was a good idea to add this.");
        }
        //This is a note for testing
        public override void SetDefaults() 
		{
			item.damage = 5000;
			item.melee = true;
			item.width = 65;
			item.height = 100;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("DevBladeProjectile");
			item.shootSpeed = 18f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Diamond, 10);
            recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddIngredient(ItemID.FragmentSolar, 100);
            recipe.AddIngredient(ItemID.FragmentNebula, 100);
            recipe.AddIngredient(ItemID.FragmentStardust, 100);
            recipe.AddIngredient(ItemID.FragmentVortex, 100);
            recipe.AddIngredient(ItemID.LunarBar, 250);
            recipe.AddIngredient(ItemID.SolarTablet, 1);
            recipe.AddIngredient(ItemID.TitaniumBar, 25);
			recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 10);
            recipe.AddRecipeGroup("IronBar", 35);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}