using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class ShootScript : MonoBehaviour
{
    [SerializeField]private BulletController bulletPrefab;
    [SerializeField]private float delay;
    public float Delay => delay;
    public void Shoot(Vector3 direction,Vector3 position)
    {
        var bullet= Instantiate(bulletPrefab,position,Quaternion.identity);
        bullet.Fire(direction);
    }
    void Update()
    {


       // transform.Translate(0,0,speed*Time.deltaTime);
    }
    
   


    /*void OnTriggerEnter(Collider other)
    {
        GameObject player =other.GetComponent<GameObject>();
        if (player != enemy)
        {
            player.Hurt(damage);
        }
    }
    private void Hurt()
    {

    }*/


    


}
