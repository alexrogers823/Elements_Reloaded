using System;
namespace Elements_Reloaded
{
    interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
    }

    interface IWeapon : IItem
    {
        int BaseWeaponDamage { get; set; }
    }

    interface IHeroWeapon : IWeapon
    {
        int WeaponLevel { get; set; }
        int BaseMagicUsage { get; set; }
    }

    interface IElementalStone : IItem
    {
        string ElementType { get; }
    }

    interface ITemperatureStone : IItem
    {
    }
}
