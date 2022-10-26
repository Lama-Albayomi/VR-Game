using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private float _health = 100;
    internal float health
    {
        get { return _health; }
        set
        {
            _health = Mathf.Max(0, value);
            if (_health == 0)
                die();
            updateHealthBar();
        }
    }

    EnemySpawner enemySpawner;
    public Slider healthBarSlider;

    private void Start()
    {
        health = 100;
        StartCoroutine(TakeDamageOverTime());
        enemySpawner = GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<EnemySpawner>();
    }


    void updateHealthBar()
    {
        Debug.Log("Health is: " + health);
        healthBarSlider.value = health;
    }

    void die()
    {
        enemySpawner.isEnemyDestroyed = true;
        Destroy(gameObject);
    }


    IEnumerator TakeDamageOverTime()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(1.5f);
            health -= 10;
        }
    }

}
