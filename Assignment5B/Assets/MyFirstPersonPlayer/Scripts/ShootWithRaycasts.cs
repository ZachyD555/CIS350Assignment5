/*
 * Zach Daly
 * Assignment 5B
 * Controls player shooting
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    // Set cam in inspector
    public Camera cam;
    public float damage = 10f, range = 100f;

    public ParticleSystem muzzleFlash;

    public float hitForce = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            // Get target script off of hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();

            // If target script is found, make target take damage
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }
        }
    }
}
