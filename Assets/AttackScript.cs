using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("isAttack", true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            anim.SetBool("isAttack", false);
        }
    }
}
