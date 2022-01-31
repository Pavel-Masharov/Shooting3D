using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingControl : MonoBehaviour
{
    [SerializeField] private Transform SpawnPositionBullet;
    private float _timeOfFire;
    public void Update()
    {
        _timeOfFire -= Time.deltaTime;
    }
    public void Shoot(Vector3 target)
    {
        if (_timeOfFire <= 0)
        {
            Vector3 LookDirection = target - transform.position;
            transform.LookAt(LookDirection);
            GameObject bullet = ObjectPool.Instanse.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = SpawnPositionBullet.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<Bullet>().DirectionTarget = target;
                gameObject.GetComponent<Player>().SettingGameValues.ChangeShot();
                bullet.GetComponent<Bullet>().ForceShot = gameObject.GetComponent<Player>().SettingGameValues.GetForceShot;
                gameObject.GetComponent<AnimatorController>().AnimationShot();
                _timeOfFire = gameObject.GetComponent<Player>().SettingGameValues.GetTimeOfFire;
            }
        }
    }
}
