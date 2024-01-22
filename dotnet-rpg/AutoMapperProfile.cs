﻿using dotnet_rpg.Dtos.Skill;

namespace dotnet_rpg;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Character, GetCharacterDto>();
        CreateMap<AddCharacterDto, Character>();
        CreateMap<UpdateCharacterDto, Character>();
        CreateMap<Weapon, GetWeaponDto>();
        CreateMap<Skill, GetSkillDto>();
    }
}
