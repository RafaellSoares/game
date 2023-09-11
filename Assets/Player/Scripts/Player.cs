using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vida = 5, tempoMax = 1f, tempoMin, Cronometro; /*Na variavel tempo Max coloque o tempo por segundo
 que seu player vai tomar dano, Na variavel vida coloque a vida do player */
    public bool dano; //variaveis publicas bool. 
    private bool estaAtirando = false;
    private float tempoUltimoTiro;
    // public Transform armaParado;
    public Transform armaAndando;
    public GameObject projetilPrefab;
    public float velocidadeProjetil;
    public bool interagindo;
    public Animator anim;
    public float speed;

    private Rigidbody2D _playerRigidBody2D;
    private float _playerSpeed;
    private Vector2 _playerDirection;

    void Start(){
        // _playerRigidBody2D  = GetComponent<Rigidbody2D>();
        speed = 0;
    }
    // Update is called once per frame
    void Update()
    { 
        // _playerDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);

        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("interagindo", true);
            speed = 0;
            Invoke("ParaInteracao", 1f);
        }

        transform.position = transform.position + movement * speed * Time.deltaTime;
        if (dano == true)
        {
            LevarDano();
        }
        /*essa condi��o vai fazer o player morrer quando a vida dele for menor que 10*/
        if (vida < 0f)
        {
            Destroy(gameObject);
        }


        if(Input.GetMouseButtonDown(0) && speed == 5 ){
            Atirar();
        }
        
    }
    // void FixesUpdate(){
    //     _playerRigidBody2D.MovePosition(_playerRigidBody2D.position + _playerDirection * _playerSpeed * Time.fixedDeltaTime);
    // }
    void ParaInteracao(){
        anim.SetBool("interagindo", false);
        speed = 5;
    }
    void Atirar(){
        if(Input.GetMouseButtonDown(0)){

            Transform shotPoint;
            shotPoint = armaAndando ;

            GameObject projectile = Instantiate(projetilPrefab, shotPoint.position, transform.rotation);

            estaAtirando = true;
            tempoUltimoTiro = .7f;
            // if(facingRight){
                projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeProjetil,0);
            // }else{
            //     projectile.getComponent<Rigidbody2D>().velocity = new Vector2(-velocidadeProjetil,0);
            // }

        }

        tempoUltimoTiro -= Time.deltaTime;

        if(tempoUltimoTiro <= 0) estaAtirando = false;

    }

        /*Essa void vai dizer se o inimigo entrou na colis�o do player*/
    void OnCollisionEnter2D(Collision2D C)
    {
        if (C.gameObject.tag == "Inimigo")
        {
            dano = true;
        }
    }
    /*Essa void vai dizer se o inimigo saio da colis�o do player*/
    void OnCollisionExit2D(Collision2D CE)
    {
        if (CE.gameObject.tag == "Inimigo")
            dano = false;
    }

    void LevarDano()
    { /*Essa void vai fazer o player tomar o dano. talvez se alguem tiver duvida eu trago um tutorial explicando como
 ela funciona*/
        Cronometro += Time.deltaTime;
        if (tempoMin < Cronometro)
        {
            tempoMin += tempoMax;
            vida -= 1;
        }
    }
}
