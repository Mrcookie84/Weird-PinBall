using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      Destroy(other.gameObject);
      AudioManager.instance.PlaySound(audioType.Destroyed, audioSourceType.Player);
   }
}
