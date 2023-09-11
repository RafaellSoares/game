using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool possuiGasolina;
    public bool possuiChave;
    public GameObject TelaPanel;
    public GameObject imgGasolina;
    public GameObject imgChave;
    // Start is called before the first frame update
    void Start()
    {
        possuiGasolina = false;
        possuiChave = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(possuiGasolina){
            mostraGasolina();
       }else{
            escondeGasolina();
       } 
        
        if(possuiChave){
            mostraChave();
       }else{
            escondeChave();
       }


    }

    void escondeGasolina(){
        imgGasolina.SetActive(false);
    }
    void mostraGasolina(){
        imgGasolina.SetActive(true);
    }
    void escondeChave(){
        imgChave.SetActive(false);
    }
    void mostraChave(){
        imgChave.SetActive(true);
    }

}
