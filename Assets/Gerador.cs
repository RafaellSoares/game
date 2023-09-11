using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    public Animator anim;
    public bool GeradorAtivado;
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        GeradorAtivado = false;
        anim = GetComponent<Animator>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "interacao" && FindObjectOfType<GameManager>().possuiGasolina == true){
            anim.enabled = true;
            GeradorAtivado = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
