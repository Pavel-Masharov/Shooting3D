using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputController : MonoBehaviour
{
    [SerializeField] private Player Player;
    private Vector3 _target;
    void Update()
    {
        TochControl();
    }

    private void TochControl()
    {
        if(Input.GetMouseButton(0))
        {
            GetPosition();
            
            if (!Player.ModeShot)
            {
                Player.GetComponent<MotionControl>().Move(_target);
            }
            else if(Player.ModeShot)
            {
                Player.GetComponent<ShootingControl>().Shoot(_target);
            }
        }
    }

    private void GetPosition()
    { 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            _target = hit.point;
        }
    }
}
