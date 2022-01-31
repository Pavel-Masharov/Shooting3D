using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator anim;
    static readonly int runStateHash = Animator.StringToHash("isRun");
    static readonly int shotStateHash = Animator.StringToHash("Shot");

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        ChangeAnimation();
    }

    public void AnimationShot()
    {
        anim.SetTrigger(shotStateHash);
    }


    private void ChangeAnimation()
    {
        if(gameObject.GetComponent<MotionControl>().isRun)
        {
            anim.SetBool(runStateHash, true);
        }
        else if(!gameObject.GetComponent<MotionControl>().isRun)
        {
            anim.SetBool(runStateHash, false);
        }
    }
}
