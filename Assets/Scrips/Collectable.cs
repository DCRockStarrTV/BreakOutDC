using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    private void OnTriggarEnter2D(Collider2D collision)
    {
        if (collision.tag == "Paddle")
        {
            this.ApplyEffect();
        }
        if (collision.tag == "Paddle" || collision.tag == "DethCollider")
        {
            Destroy(this.gameObject);
        }
    }

    protected abstract void ApplyEffect();
}
