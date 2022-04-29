using UnityEngine;

public class PlayerControllerStackColor : MonoBehaviour
{
    [SerializeField] Color myColor;
    [SerializeField] Renderer[] myRends;

    [SerializeField] bool isPlaying;
    [SerializeField] float forwardSpeed;
    Rigidbody myRB;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        SetColor(myColor);
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying)
        {
            MoveForward();
        }
    }

    void SetColor(Color colorIn)
    {
        myColor = colorIn;
        for(int i=0; i<myRends.Length; i++)
        {
            myRends[i].material.SetColor("_Color", myColor);
        }
    }

    void MoveForward()
    {
        myRB.velocity = Vector3.forward * forwardSpeed;
    }
}
