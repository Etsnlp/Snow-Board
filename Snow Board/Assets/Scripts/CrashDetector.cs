using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime;
    [SerializeField] ParticleSystem crashEffect;

   void OnTriggerEnter2D(Collider2D other)
   {
      if(other.tag == "Ground")
      {
        FindObjectOfType<PlayerController>().StopControl();
        crashEffect.Play();
        GetComponent<AudioSource>().Play();
        Invoke("ReloadScene", delayTime);
      }
    
   }

   void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}


