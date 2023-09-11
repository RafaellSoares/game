using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaMetal : MonoBehaviour
{
    public Animator anim;
    public bool AtivaPortaMetal;
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        AtivaPortaMetal = false;
        bc = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }
    void Update(){
        if(AtivaPortaMetal){
            anim.enabled = true;
            Destroy(bc);
        }
    }
}
