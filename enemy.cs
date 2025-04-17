using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 5f;
    public int checkpointId;
    public float step;
    public GameObject[] checkpoints;
    public string tag;
    void Start()
    {
        step = speed * Time.deltaTime;
        checkpoints = GameObject.FindGameObjectsWithTag(tag);
    }
    void Update()
        {
            if(checkpointId < checkpoints.Length )
            {
                Transform currentCheckpoint = checkpoints[checkpointId].transform;
                transform.position = Vector3.MoveTowards(transform.position, currentCheckpoint.position, step);
                if(Vector3.Distance(transform.position, currentCheckpoint.position)< 0.25f)
                {
                    checkpointId++;
                }
            }
            else
                    {
                        checkpointId = checkpoints.Length ;
                    }
        }
}
