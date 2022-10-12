using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerController : MyCharacterController
{
[SerializeField] private ScreenTouchController input;
[SerializeField] private ShootScript shootController;
private bool isShooting;
private List<Transform> enemies =new();

public void FixedUpdate()
{
    var direction = new Vector3(input.Direction.x,0,input.Direction.y);
    Move(direction);


}

 private void OnCollisionEnter(Collision collision)
{
    if (collision.transform.CompareTag("Enemy"))
    {
        Dead();
    }



}
 private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag($"Enemy"))
        {
            if(!enemies.Contains(other.transform))
            enemies.Add(other.transform);
            AutoShoot();


             
            
        }
    }
   
    private void AutoShoot()
    {
        IEnumerator Do()
        {

            while (enemies.Count>0)
            {
                var enemy = enemies[0];
                var direction = enemy.transform.position - transform.position;
                direction.y=0;
                direction = direction.normalized;
                shootController.Shoot(direction,transform.position);
               // transform.LookAt(enemy.transform);
                enemies.RemoveAt(0);

                yield return new WaitForSeconds(shootController.Delay);

            }
            isShooting=false;
        }
        if (!isShooting)
        {
            isShooting=true;
            StartCoroutine(Do());
        }
    }

public void Dead(){
    Debug.Log("Dead");
    Time.timeScale=0f;
}



}

