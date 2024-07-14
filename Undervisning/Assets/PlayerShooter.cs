using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    private Transform transform;
    public GameObject bulletPrefab;
    public float cooldownTime = 0.3f;
    public float bulletSpeed = 100;
    private float leftoverCooldown;

    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        leftoverCooldown = leftoverCooldown - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && leftoverCooldown <= 0)
        {
            GameObject bullet = Instantiate(bulletPrefab,transform.position,quaternion.identity);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = transform.forward * bulletSpeed;
            
            animator.SetTrigger("Shoot");
            
            leftoverCooldown = cooldownTime;
        }
        
        transform.Rotate(0, Input.GetAxisRaw("TurnAround"), 0);
    }
}
