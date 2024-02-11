using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   public void OnTriggerEnter(Collider collider) {
        if(collider.tag == "Player") {
            if(SceneManager.GetActiveScene().buildIndex == 5) {
                SceneManager.LoadScene(0);
            }
            if(SceneManager.GetActiveScene().buildIndex < 5) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
   }
}
