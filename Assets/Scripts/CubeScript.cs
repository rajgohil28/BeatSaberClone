using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField] private float _CubeSpeed = 2.0f;
    public GameObject CutPrefab;
    public string BladeTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * _CubeSpeed;
    }
    public void CubeCut()
    {
        
        Instantiate(CutPrefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if(other.tag == BladeTag)
        {
            CubeCut();
        }
    }
}
