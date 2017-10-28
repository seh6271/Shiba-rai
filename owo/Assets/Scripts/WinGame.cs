using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    // Use this for initialization
    public GameObject player;
    public GameObject enemy;
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player.transform.position.x > enemy.transform.position.x-5 && player.transform.position.x < enemy.transform.position.x + 5 &&
            player.transform.position.y > enemy.transform.position.y - 5 && player.transform.position.y < enemy.transform.position.y + 5)
            SceneManager.LoadScene(2);

	}
}
