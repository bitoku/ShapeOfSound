using System;
using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject deleter;
    void Start()
    {
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(3, 0, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name != deleter.name) return;
        Debug.Log(other.gameObject.name);
        Destroy(gameObject);
    }
}
