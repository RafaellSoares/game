using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavanca : MonoBehaviour
{
    public Animator anim;
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        bc = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "interacao" && FindObjectOfType<Gerador>().GeradorAtivado == true){
            anim.enabled = true;
            FindObjectOfType<PortaMetal>().AtivaPortaMetal = true;
        }
    }

}
