using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lago : MonoBehaviour
{
    public BoxCollider2D bc;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "interacao"){
            key.SetActive(true);
            FindObjectOfType<GameManager>().possuiChave = true;
            Destroy(bc);
            Invoke("DestroiChave", 2.5f);
        }
    }
    void DestroiChave(){
        key.SetActive(false);
    }
}
