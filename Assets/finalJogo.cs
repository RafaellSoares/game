using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class finalJogo : MonoBehaviour
{
    public GameObject FinalPanel;
    public Text TextoFinal;

    public bool startDialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            FindObjectOfType<Player>().speed = 0f;
            StartDialogue();
            
        }
    }
    void StartDialogue(){
        startDialogue = true;
        FinalPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
