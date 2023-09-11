using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
    public BoxCollider2D caixaCollider;
    // Start is called before the first frame update
    void Start()
    {
        caixaCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKeyDown(KeyCode.Space)){
            ativarInteracao();
            Invoke("desativarInteracao", 0.5f);
        }
    }
    void ativarInteracao(){
        if(Input.GetKeyDown(KeyCode.Space)){
            caixaCollider.enabled = true;
            Debug.Log("Apertei");

        }
    }
    void desativarInteracao(){
        Debug.Log("DesaPertei");
        caixaCollider.enabled = false;
    }
}
