using UnityEngine;

public class PushForce : MonoBehaviour
{
    float force;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        force = 30.0f;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(rigidbody.transform.forward*force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {

    }
}
