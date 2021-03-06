using UnityEngine;

public class InterfaceController : MonoBehaviour
{
    private Player player;
    private float moveDirection;
    private bool needMove;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        if (player.useKeyBoard)
        {
            this.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (needMove)
        {
            player.Move(moveDirection);
        }
    }

    public void Jump()
    {
        player.Jump();
    }

    public void Use()
    {
        Debug.Log("Use");
    }

    public void MoveLeft()
    {
        needMove = true;
        moveDirection = -1f;
    }

    public void MoveRight()
    {
        needMove = true;
        moveDirection = 1f;
    }

    public void StopMove()
    {
        moveDirection = 0;
        player.StopMoving();

        needMove = false;
    }
}
