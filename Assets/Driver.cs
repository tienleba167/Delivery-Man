using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float SteerSpeed = 150;
    [SerializeField] float MoveSpeed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float SteerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
        float MoveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Rotate(0,0,- SteerAmount);
        transform.Translate(0,MoveAmount,0);
    }
}
