using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Rigidbody rb;
    private int count;

    public float forceValue;
    public TextMeshProUGUI score;
    public TextMeshProUGUI end;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moverDir=new Vector3(h,0,v);

        rb.AddForce(moverDir*forceValue);
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);

        count++;
        
        refreshUI();
    }
    void refreshUI()
    {
        score.text = "Current Score : " + count;

        if (count >= 8)
        {
            end.gameObject.SetActive(true);
        }
    }
}
