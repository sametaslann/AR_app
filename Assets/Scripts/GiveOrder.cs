using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveOrder : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    //public void SeatAnimation()
    //{
    //    Debug.Log("animator called");
    //    animator.Play("Wolf 2", -1, 0f);
    //}

    //public void RunAnimation()
    //{
    //    animator.Play("Wolf 1", -1, 0f);
    //}


    //public void CreepAnimation()
    //{
    //    animator.Play("Wolf 4", -1, 0f);
    //}

}
