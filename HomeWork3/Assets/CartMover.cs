using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CartMover : MonoBehaviour
{

    public CinemachineDollyCart dollyCart;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dollyCart !=null){
            dollyCart.m_Position += speed * Time.deltaTime;
            Debug.Log("Dolly Position: " + dollyCart.m_Position);
        }
        else{
            Debug.Log("DollyCart not assigned!");
        }
    }
}
