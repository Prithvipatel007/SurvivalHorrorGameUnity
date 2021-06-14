using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    [SerializeField]
    public GameObject TheGun;

    [SerializeField]
    public GameObject MuzzleFlash;

    [SerializeField]
    public AudioSource GunFire;

    public bool isFiring = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(isFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }

    IEnumerator FiringPistol()
    {
        isFiring = true;
        TheGun.GetComponent<Animation>().Play("PistolShotAnim");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleAnim");
        GunFire.Play();
        yield return new WaitForSeconds(0.5f);
        isFiring = false;
        MuzzleFlash.SetActive(false);


    }
}
