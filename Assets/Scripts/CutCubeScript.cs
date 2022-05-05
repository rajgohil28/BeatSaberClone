using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutCubeScript : MonoBehaviour
{
    public GameObject UpperCubePart;
    public GameObject LowerCubePart;

    private Rigidbody _upperCubeRigidbody;
    private Rigidbody _lowerCubeRigidbody;

    public float _force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        _upperCubeRigidbody = UpperCubePart.GetComponent<Rigidbody>();
        _lowerCubeRigidbody = LowerCubePart.GetComponent<Rigidbody>();


        _upperCubeRigidbody.AddForce(new Vector3(_force, 0, 0), ForceMode.Impulse);
        _lowerCubeRigidbody.AddForce(new Vector3(-(_force), 0, 0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
