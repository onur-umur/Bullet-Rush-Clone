using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyController : MyCharacterController
{
 [SerializeField] private PlayerController player;

 public void FixedUpdate()
 {
     var delta = -transform.position + player.transform.position;
     delta.y = 0;
    var direction = delta.normalized;
    //transform.position = Vector3.MoveTowards(transform.position,Enemy.transform.position,Speed*Time.deltaTime);
    Move(direction);
    transform.LookAt(player.transform);

 }
//  private void OnCollisionEnter(Collision collision)
//  {
    
//  }
 private void OnTriggerEnter(Collider collision)
 {
    if (collision.transform.CompareTag("Bullet"))
    {
        gameObject.SetActive(false);
        collision.gameObject.SetActive(false);
    }
 }


}
