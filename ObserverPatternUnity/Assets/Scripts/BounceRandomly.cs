using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceRandomly : MonoBehaviour
{
    // Script attached to collider adds force to collided rigid body (Circles in our case)

    public delegate void UpdateCollidedStatusDelegate(GameObject gameObject);
    public static event UpdateCollidedStatusDelegate updateCollidedStatusEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D collidedRigidBody = collision.rigidbody;
        
        if (collidedRigidBody != null)
        {
            float randomDirection = GetRandomDirection(collidedRigidBody);
            collidedRigidBody.AddRelativeForce(new Vector2(randomDirection, 0), ForceMode2D.Impulse);

            // Inform subscribers about collided object
            updateCollidedStatusEvent?.Invoke(collision.gameObject); // collidedRigidBody.gameObject);
        }
    }

    private float GetRandomDirection(Rigidbody2D rigidbody)
    {
        // Randomly choose left or right
        //float[] directionFactor = new float[] { -1f, 1f };
        //float direction = directionFactor[Random.Range(0, directionFactor.Length)];

        return Random.Range(5f, 10f) * (rigidbody.velocity.x < 0 ? -1f : 1f); //* direction;


    }
}
