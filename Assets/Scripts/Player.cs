using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject menu;
    public GameObject restart;
    public static bool lose = false;

    void Awake()
    {
        lose = false;
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject.tag == "Bomb")
            lose = true;
        restart.SetActive (lose);
        menu.SetActive (lose);
    }
  
}
