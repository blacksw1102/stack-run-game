using UnityEngine;

public class CameraStackColor : MonoBehaviour
{
    [SerializeField] Transform target;
    float deltaZ;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        deltaZ = transform.position.z - target.position.z;
        Debug.Log(deltaZ);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z + deltaZ);
        Debug.Log(count++);
    }
}
