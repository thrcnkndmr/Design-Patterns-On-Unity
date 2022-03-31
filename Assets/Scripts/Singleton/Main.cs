using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    void Start()
    {
        GameManager.Instance.a = 5;
    }

    
    void Update()
    {
        Debug.Log(Singleton.Instance.GetText());
        Debug.Log(GameManager.Instance.a);
    }
}
