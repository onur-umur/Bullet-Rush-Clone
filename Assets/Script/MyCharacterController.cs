using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
 [SerializeField]  Rigidbody myRigidbody;
 [Range(200,2000)][SerializeField] private int moveSpeed;
 
    public void Update()
 {
    //transform.position = Vector3.MoveTowards(transform.position,myRigidbody.transform.position,moveSpeed*Time.deltaTime);

    


 }
 protected void Move(Vector3 direction)
 {
    myRigidbody.velocity = direction * moveSpeed*Time.deltaTime;
 }
}