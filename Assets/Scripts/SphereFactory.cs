using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFactory : MonoBehaviour
{
    private GameObject _sphere;
    private GameObject _deleter;

    private float _elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        _sphere = Resources.Load<GameObject>("Sphere");
        _deleter = GameObject.Find("Deleter");
        CreateSphere();
    }

    // Update is called once per frame
    void Update()
    {
        if (_elapsedTime > 6.35f)
        {
            CreateSphere();
            _elapsedTime = 0;
        }
        _elapsedTime += Time.deltaTime;
    }

    private void CreateSphere()
    {
        Instantiate(_sphere, new Vector3(-3.5f, 2.5f, 0), Quaternion.identity);
    }
}
