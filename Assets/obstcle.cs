
using UnityEngine;

public class obstcle : MonoBehaviour
{

    public PlayerMovement movement;
    public Vector3 startpoint;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstcle") {

            transform.position =startpoint ;   
                }

                



    }



}