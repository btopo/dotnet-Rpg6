using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_Rpg6.Dtos.Character;
using dotnet_Rpg6.Dtos.Weapon;

namespace dotnet_Rpg6.Services.CharacterService.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}