using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;
    public float ThresholdAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            hit.transform.gameObject.GetComponent<CubeScript>().CubeCut();    
        }
        previousPos = transform.position;



        //If you want cutting mechanism to be directional

        /*RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > ThresholdAngle)
            {
                hit.transform.gameObject.GetComponent<CubeScript>().CubeCut();
            }
        }
        previousPos = transform.position;*/
    }
}
