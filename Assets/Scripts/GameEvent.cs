using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public const string ENEMY_KILLED = "ENEMY_KILLED";
    public const string SENSITIVITY_CHANGED = "SENSITIVITY_CHANGED";
    public const string GAME_PAUSED = "GAME_PAUSED";
    public const string GAME_UNPAUSED = "GAME_UNPAUSED";
    public const string UPDATE_HEALTH = "UPDATE_HEALTH";
    public const string UPDATE_AMMO = "UPDATE_AMMO";
    public const string GAME_END = "GAME_END";
}
