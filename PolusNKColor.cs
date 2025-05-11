using MiraAPI.Colors;
using UnityEngine;

namespace PolusNK;

[RegisterCustomColors]
public static class PolusNKColor
{
    public static CustomColor NK { get; } = new("NK", new Color(0.35f, 0.35f, 0.67f));

}
