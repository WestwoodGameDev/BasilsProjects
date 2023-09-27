using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BusMove : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    public GameObject cam;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * yAxis);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * xAxis);

        cam.transform.position = transform.position + new Vector3(0.0f, 10.0f, -15.0f);
    }
}
