using UnityEngine;

public class MoveCharater : MonoBehaviour
{
    internal bool isDroppedOnBoard = false;
    internal bool collidedWithEnemy = false;

    private void Update()
    {
        RaycastHit hit;
        if (!collidedWithEnemy && isDroppedOnBoard && Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.tag == "Enemy")
                transform.position = Vector3.MoveTowards(transform.position, hit.transform.position, Time.deltaTime);
        }
    }

}
