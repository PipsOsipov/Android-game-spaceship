using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]  
    private float speed = 14f;
    

    void OnMouseDrag()
    {
        if (!Player.lose)
        {


            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.6f ? 2.6f : mousePos.x; // проверка позиции игрока по иксу в пределах 2.6f
            mousePos.x = mousePos.x < -2.6f ? -2.6f : mousePos.x; // проверка позиции игрока по иксу в пределах -2.6f
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y),
                speed * Time.deltaTime);//логика движения(откуда, куда, скорость).
        }
    }
}
