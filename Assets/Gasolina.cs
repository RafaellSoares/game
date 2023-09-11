using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gasolina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D algo){
        if(algo.gameObject.CompareTag("Player")){
            FindObjectOfType<GameManager>().possuiGasolina = true;
            Destroy(this.gameObject);
        }
    }
}
