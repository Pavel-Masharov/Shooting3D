using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SettingGame", menuName = "SettingGame", order = 51)]
public class SettingGameScriptableObject : ScriptableObject
{
    [SerializeField] [Header("Скорость перезарядки")] private float _timeOfFire = 0.2f;
    [SerializeField] [Header("Скорость движения")] private float _speedPlayer;
    private float _forceShot;

    [Header("Сила выстрела")] public LevelOfDifficulty difficulty = LevelOfDifficulty.EasyShot;
    public enum LevelOfDifficulty
    {
        EasyShot = 0,
        MediumShot = 1,
        HardShot = 2
    }

    public void ChangeShot()
    {
        if (difficulty == LevelOfDifficulty.EasyShot)
        {
            _forceShot = 10f;
        }
        else if (difficulty == LevelOfDifficulty.MediumShot)
        {
            _forceShot = 200f;
        }
        else
        {
            _forceShot = 1000f;
        }
    }

    public float GetTimeOfFire
    {
        get
        {
            return _timeOfFire;
        }
    }
    public float GetSpeedPlayer
    {
        get
        {
            return _speedPlayer;
        }
    }
    public float GetForceShot
    {
        get
        {
            return _forceShot;
        }
    }
}
