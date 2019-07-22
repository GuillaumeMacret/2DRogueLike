using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        if(GameManager1.instance == null)
        {
            Instantiate(gameManager);
        }
    }
}
