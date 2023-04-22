using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody> ();
    }

    // Update is called once per frame
    void OnMouseDrag(){
        dragging = true;
    }

    void Update(){
        if(Input.GetMouseButtonUp(0)){
            dragging = false;
        }
    }

    void FixedUpdate(){
        if(dragging){
            float x = Input.GetAxis("Mouse X")*rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y")*rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down*x);
            rb.AddTorque(Vector3.right*y);
        }
    }
}
