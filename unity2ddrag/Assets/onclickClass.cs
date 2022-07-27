using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclickClass : MonoBehaviour
{
    [SerializeField] GameObject _respawnPoint;
    Vector3 _offset;

    private void OnMouseDown()
    {
        Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clickPosition.z = 0;
        _offset = clickPosition - transform.position;
    }
    private void OnMouseDrag()
    {
        if (!DieOnHit.IsCollidingWall)
        {
            Vector3 playerNewPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            playerNewPosition.z = 0;
            transform.position = playerNewPosition - _offset;
        }

    }

    public void respawn() 
    {
            gameObject.transform.position = _respawnPoint.transform.position;
    }

}
