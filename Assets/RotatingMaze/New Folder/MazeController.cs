using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeController : MonoBehaviour
{
    public float angleToTurn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            this.transform.Rotate(Vector3.forward * -angleToTurn);
        }
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            this.transform.Rotate(Vector3.forward * angleToTurn);
        }
    }

    public void ResetRotation()
    {
        this.transform.rotation = new Quaternion();
    }
}
