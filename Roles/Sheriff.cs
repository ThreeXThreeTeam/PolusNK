using MiraAPI.Roles;
using UnityEngine;

namespace PolusNKRoles;

public class Sheriff : CrewmateRole, ICustomRole
{
    public string RoleName => "Sheriff";
    public string RoleDescription => RoleLongDescription;
    public string RoleLongDescription => "Kill impostor.";
    public Color RoleColor => new Color32(255, 206, 24, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this)
    {
        CanGetKilled = true,
    };
}