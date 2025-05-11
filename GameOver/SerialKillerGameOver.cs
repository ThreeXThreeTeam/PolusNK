using PolusNKRoles;
using MiraAPI.GameEnd;
using MiraAPI.Utilities;
using UnityEngine;

namespace PolusNK.GameOver;

public class SerialKillerGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        return winners is [{ Role: SerialKiller }];
    }

    public override void AfterEndGameSetup(EndGameManager endGameManager)
    {
        endGameManager.WinText.text = "Outcast Killer Wins!";
        endGameManager.WinText.color = Color.magenta;
        endGameManager.BackgroundBar.material.SetColor(ShaderID.Color, Color.magenta);
    }
}
