using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloqueioPorta : MonoBehaviour
{
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "interacao" && FindObjectOfType<GameManager>().possuiChave == true){
            FindObjectOfType<PortaMadeira>().AtivaPorta = true;
            FindObjectOfType<GameManager>().possuiChave = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
