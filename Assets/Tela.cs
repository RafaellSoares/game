using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tela : MonoBehaviour
{
    public GameObject imagePause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause(){
        Time.timeScale = 0f;
        imagePause.SetActive(true);
    }
    public void DesPause(){
        Time.timeScale = 1f;
        imagePause.SetActive(false);
    }
}
