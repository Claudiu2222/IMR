using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : MonoBehaviour
{
    private Animator _animator;
    private float _distanceBetween;
    public GameObject AnotherCactus;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("isAttacking", false);
    }

    // Update is called once per frame
    void Update()
    {
        _distanceBetween = Vector3.Distance(this.transform.position, AnotherCactus.transform.position);
        if (_distanceBetween < 1)
        {
            _animator.SetBool("isAttacking",true);
        }
        else
        {
            _animator.SetBool("isAttacking", false);
        }



    }
}
