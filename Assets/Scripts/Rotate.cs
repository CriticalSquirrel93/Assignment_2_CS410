using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;


   void Update () {
    Quaternion lookRotation = Quaternion.LookRotation(player.position - transform.position);

    transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);

   }


}
