using UnityEngine;
//This script is for rotating the cannon. 
public class MoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    //float tilt = 20.0f;
    //float overallSpeed;
    Transform trans;
    void Start()
    {
        trans = GetComponent<Transform>();
        //overallSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetAxis("Horizontal")>0){
            trans.RotateAround(new Vector3(0,3,0), new Vector3(0,0,1), 20*Time.deltaTime);
        }
        if(Input.GetAxis("Horizontal") < 0){
            trans.RotateAround(new Vector3(0,3,0), new Vector3(0,0,-1), 20*Time.deltaTime);
        }
        
    }
}
