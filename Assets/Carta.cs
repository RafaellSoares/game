using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Carta : MonoBehaviour
{   
    public GameObject DialogoPanel;
    public Text DialogoTexto;
    public Text CartaTexto;

    public bool readyToSpeak;
    public bool startDialogue;
    // Start is called before the first frame update
    void Start()
    {
        DialogoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && readyToSpeak && !startDialogue){

                FindObjectOfType<Player>().speed = 0f;
                StartDialogue();
        }
        if(Input.GetMouseButtonDown(0) && DialogoPanel && startDialogue){
                DialogoPanel.SetActive(false);
                startDialogue = false;
                Invoke("VoltaSpeed", 0.5f); 
        }
    }
    void VoltaSpeed(){
        FindObjectOfType<Player>().speed = 5f;
    }
    void StartDialogue(){
        CartaTexto.text = "Carta:";
        startDialogue = true;
        DialogoPanel.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            readyToSpeak = true;
            Debug.Log("consegui");
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
           readyToSpeak = false; 
            
        }
    }
}
