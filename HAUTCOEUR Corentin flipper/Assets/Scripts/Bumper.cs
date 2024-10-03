using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class Bumper : MonoBehaviour
{
   public float strenght = 1;
   public Animation anim;
   private void OnCollisionEnter(Collision collision)
   {
      Vector3 force = (collision.transform.position - transform.position).normalized * strenght;

      collision.rigidbody.AddForce(force);
      anim.Play("Bumper Bump");
      AudioManager.instance.PlaySound(audioType.Bounce, audioSourceType.Player);
   }
}
