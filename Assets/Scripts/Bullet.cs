using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    private readonly float _speedFly = 50;
    private readonly float lifeTime = 2f;
    [HideInInspector] public Vector3 DirectionTarget;
    [HideInInspector] public float ForceShot;

    private void Start()
    {
        Invoke(nameof(Deactive), lifeTime);
    }
    void Update()
    {
        FlyBullet();
    }
    public void FlyBullet()
    {
        float step = _speedFly * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, DirectionTarget, step);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.GetComponentInParent<RagdollController>())
        {
            collision.collider.gameObject.GetComponentInParent<RagdollController>().RigidbodyIsKinematicOff();
            collision.collider.attachedRigidbody.AddForce(transform.forward * ForceShot, ForceMode.Impulse);
        }
        gameObject.SetActive(false);
    }

    private void Deactive()
    {
        gameObject.SetActive(false);
    }
}
