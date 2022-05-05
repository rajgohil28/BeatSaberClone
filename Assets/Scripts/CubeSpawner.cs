using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject[] _spawningPrefs;
    public Transform OriginPoint;
    public float beat = (60 / 120) * 2;
    private float timer;
    private int PrefsNumber;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        PrefsNumber = _spawningPrefs.Length;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == PrefsNumber)
        {
            counter = 0;
        }
        if (timer > beat)
        {
            if(counter <= PrefsNumber)
            {
                int _prefsNumber = _spawningPrefs.Length;
                Instantiate(_spawningPrefs[counter], OriginPoint);
                timer -= beat;
                counter++;
            }
        }
        timer += Time.deltaTime;
    }
}
