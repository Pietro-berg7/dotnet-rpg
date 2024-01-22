namespace dotnet_rpg.Services.FightService;

public interface IFightService
{
    Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
}
