using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour{  

    public int dano;
    public float tempoDeVida;
    public float distancia;
    public LayerMask layerInimigo;

// Start is called before the first frame update
void Start(){
    Invoke("DestruirProjetil", tempoDeVida);
}
// Update is called once per frame
void Update(){
    RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.forward, distancia, layerInimigo);

    if(hitInfo.collider != null){
        // if(hitInfo.collider.CompareTag("Inimigo")){
        //     hitInfo.collider.getComponent<EnemyAI>().TakeDamage(dano);
        // }

        DestruirProjetil();
    }
}

void DestruirProjetil(){
  Destroy(gameObject);
}

}


