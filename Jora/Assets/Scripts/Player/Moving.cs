using UnityEngine;

public class Moving : MonoBehaviour
{
    private SpriteRenderer sprite;
    Animator animator;
    
    private void Awake(){
        sprite = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            transform.position = transform.position + new Vector3(0,1,0);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            sprite.flipX = true;
            transform.position = transform.position + new Vector3(-1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.S)){
            transform.position = transform.position + new Vector3(0,-1,0);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            sprite.flipX = false;
            transform.position = transform.position + new Vector3(1,0,0);
        }
    }
}
