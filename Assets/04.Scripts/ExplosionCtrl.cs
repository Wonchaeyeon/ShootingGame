using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtrl : MonoBehaviour
{

    public AudioClip sfx;
    public AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayOneShot(sfx, 0.9f);
        Invoke("destroy", 0.75f);   
    }

    void destroy()
    {
      Destroy(this.gameObject);
    }
}
