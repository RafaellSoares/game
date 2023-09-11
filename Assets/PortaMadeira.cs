using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaMadeira : MonoBehaviour
{
    public Animator anim;
    public bool AtivaPorta;
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        AtivaPorta = false;
        bc = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }
    void Update(){
        if(AtivaPorta){
            anim.enabled = true;
            Destroy(bc);
        }
    }
    public void Animacao(){
        anim.enabled = true;    
    }
}
