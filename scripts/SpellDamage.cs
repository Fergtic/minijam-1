using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class SpellDamage : MonoBehaviour
{
    public int damageAmount = 10;
    public string element;
    void OnTriggerEnter2D(Collider2D other)
    {
        Absorb player = other.GetComponent<Absorb>();
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            if (!player.IsImmune(element))
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log("Player took Damage!");
            }
            else
            {
                Debug.Log("Player is immune to Water attack!");
            }

            Destroy(gameObject);
        }
    }

}
