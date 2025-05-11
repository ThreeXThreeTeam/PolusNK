using MiraAPI.Roles;
using UnityEngine;

namespace PolusNKRoles;

public class Engineer : CrewmateRole, ICustomRole
{
    public string RoleName => "Engineer";
    public string RoleLongDescription => "You can use vent!";
    public string RoleDescription => RoleLongDescription;
    public Color RoleColor => new Color32(21, 35, 232, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this)
    {
        CanUseVent = true,
    };
}
