using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public int tal = 2;
    public GameObject player;

    public Transform t;
    
    public Vector3 v;

    public PlayerMover pm;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

       
        float kommatal = 0.5f;
        string tekst = "tekst";
        bool tjek = true;
        
        print(kommatal);
        print(tekst);
        print(tjek);
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("Update");
        print(tal);
    }
}
