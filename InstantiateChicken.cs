
using UnityEngine;

public class InstantiateChicken : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject chicken;
    Transform transform;

    void Start()
    {

        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(chicken, transform.position, transform.rotation);
        }
        
    }
    private void FixedUpdate() {

    }
        
}
