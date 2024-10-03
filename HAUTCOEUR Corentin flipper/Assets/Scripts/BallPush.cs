using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPush : MonoBehaviour
{
    public float strenght = 500;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Vector3 force = (collision.transform.position - transform.position).normalized * strenght;

            collision.rigidbody.AddForce(force);
            AudioManager.instance.PlaySound(audioType.Bounce, audioSourceType.Player);
        }
    }
    
}
