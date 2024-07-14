using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody rigidbody;
    public Animator animator;
    public GameObject gameOverCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = rigidbody.velocity;
        move.x = Input.GetAxisRaw("Horizontal") * speed;
        move.z = Input.GetAxisRaw("Vertical") * speed;
        rigidbody.velocity = move;
        
        animator.SetFloat("Speed", move.magnitude);
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
