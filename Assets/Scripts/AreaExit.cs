using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    public string areaToLoad;
    public string areaTransitionNameExit;

    private string _playerTag = "Player";

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(_playerTag))
        {
            SceneManager.LoadScene(areaToLoad);

            PlayerController.instance.areaTransitionNamePC = areaTransitionNameExit;
        }
    }
}
