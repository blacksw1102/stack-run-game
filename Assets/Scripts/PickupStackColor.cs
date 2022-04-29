using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupStackColor : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] Color pickUpColor;

    // Start is called before the first frame update
    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", pickUpColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
