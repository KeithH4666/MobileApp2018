﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bullet;
    public AudioClip audioData;

    // Update is called once per frame
    void Update () {

        // Space bar used to shoot
       //if (Input.GetButtonDown("Fire1"))
        if(Input.GetMouseButton(1))
        {
            Shoot();
            Debug.Log("fire");
        }

        
		
	}

    void Shoot()
    {
        Debug.Log("fire2");
        AudioSource.PlayClipAtPoint(audioData, transform.position);
        //Create a bullet at the player firepoint
        Instantiate(bullet,firePoint.position,firePoint.rotation);
    }
}
