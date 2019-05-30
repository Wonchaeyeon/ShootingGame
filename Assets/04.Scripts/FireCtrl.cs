﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour {

    public GameObject[] pos;
    public GameObject bullet;

    public float delayTime = 0.2f;

    public AudioClip sfx;
    public AudioSource audioSource;

    void Start(){
        InvokeRepeating("Fire", 1.0f, delayTime);
    }
    
    void Update(){
        
    }

    void Fire() {
        audioSource.PlayOneShot(sfx, 0.2f);
        for(int i = 0; i< pos.Length; i++) {
            Instantiate(bullet, pos[i].transform.position, pos[i].transform.rotation);
        }
    }
}
