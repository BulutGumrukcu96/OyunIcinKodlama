using System.Threading;
using UnityEngine;

public class dROPPER : MonoBehaviour
{
    [SerializeField] float timetoWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

   
    void Update()
    {
        if (Time.time > timetoWait )
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
