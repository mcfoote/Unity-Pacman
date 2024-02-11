using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "Player"){
            transform.position = new Vector3(transform.position.x, -10, transform.position.z);
            other.GetComponent<BallMovement>().speed += 5;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
