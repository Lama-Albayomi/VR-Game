using System.Collections;
using Facebook.WitAi.Lib;
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

    // just for combat fun to show cube hitting another cube
    internal void attackEnemy(GameObject enemy)
    {
        StartCoroutine(unleashAttack(enemy));
    }


    IEnumerator unleashAttack(GameObject enemy)
    {
        var currentPosition = transform.position;
        while (collidedWithEnemy)
        {
            yield return StartCoroutine(pingPongAttack(transform, currentPosition, enemy.transform.position - Vector3.forward, .25f));
            yield return StartCoroutine(pingPongAttack(transform, enemy.transform.position - 2 *Vector3.forward, currentPosition , .25f));
        }
    }

    IEnumerator pingPongAttack(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
