using UnityEngine;

public class PlayerControllerStackColor : MonoBehaviour
{
    [SerializeField] Color myColor;
    [SerializeField] Renderer[] myRends;

    [SerializeField] bool isPlaying;
    [SerializeField] float forwardSpeed;
    [SerializeField] float sideLerpSpeed;
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

        if(Input.GetMouseButton(0))
        {
            if(isPlaying == false)
            {
                isPlaying = true;
            }
            MoveSideways();
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

    void MoveSideways()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 100))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(hit.point.x, transform.position.y, transform.position.z), sideLerpSpeed * Time.deltaTime);
        }
    }

}
