using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrop : MonoBehaviour
{
    public int rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
