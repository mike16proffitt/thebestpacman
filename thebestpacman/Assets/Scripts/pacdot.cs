 using System.Collections;
using UnityEngine;

public class pacdot : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
        {
            Destroy(gameObject);
            Score.scoreValue += 3;
        }
    }
}
