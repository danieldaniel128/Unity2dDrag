using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool IsCollidingWall =false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
      //  gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        IsCollidingWall = true;
        GameManager.Health--;
        GameManager.livesCounter.text = "Lives: " + GameManager.Health.ToString();
        GetComponent<onclickClass>().respawn();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exited");
        Invoke("SetCollidingFalse",0.5f);
        if (GameManager.Health == 0)
            GameManager.GameOver();
    }


    void SetCollidingFalse() 
    {
        IsCollidingWall = false;
    }

}
