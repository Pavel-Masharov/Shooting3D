using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SettingGameScriptableObject SettingGameValues;
    [HideInInspector] public bool ModeShot = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Tower"))
        {
            ModeShot = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tower"))
        {
            ModeShot = false;
        }
    }
}
