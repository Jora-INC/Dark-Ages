using UnityEngine;

public class Moving : MonoBehaviour
{
    public Transform[] Check;
    [SerializeField] private bool[] isWall;
    public LayerMask[] CheckingLayers;
    public float RadiusOfDetected = 0.2f;
    
    public GameObject player;
    private SpriteRenderer sprite;
    Animator animator;
    
    private void Awake(){
        sprite = player.GetComponent<SpriteRenderer>();
        animator = player.GetComponent<Animator>();

        for(int i = 0; i < isWall.Length; i++){
            isWall[i] = false;
        }
    }

    private void FixedUpdate(){
        CheckNear();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && isWall[2] == false){
            transform.position = transform.position + new Vector3(0,1,0);
        }
        if(Input.GetKeyDown(KeyCode.A) && isWall[0] == false){
            sprite.flipX = true;
            transform.position = transform.position + new Vector3(-1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.S) && isWall[3] == false){
            transform.position = transform.position + new Vector3(0,-1,0);
        }
        if(Input.GetKeyDown(KeyCode.D) && isWall[1] == false){
            sprite.flipX = false;
            transform.position = transform.position + new Vector3(1,0,0);
        }
    }

    private void CheckNear(){
        for(int i = 0; i < Check.Length; i++){
            Collider2D[] NumbersOfWall = Physics2D.OverlapCircleAll(Check[i].position, RadiusOfDetected, CheckingLayers[0]);
            isWall[i] = NumbersOfWall.Length > 0;
        }
    }
}
