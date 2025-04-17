using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{       
    public GameObject prefab;
    public int contPrefabs;
    public float timer;
    public float interval;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if(contPrefabs > 0)
            {
                Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
                contPrefabs -= 1;
                timer = interval;
            }
        }
    }
}
