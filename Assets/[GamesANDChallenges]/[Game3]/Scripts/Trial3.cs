using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trial3 : MonoBehaviour
{
    private int age;
    void Start()
    {
        Debug.Log(GenerateRandomAge());
    }

    private int GenerateRandomAge()
    {
       age = Random.Range(1, 101);
        return age;
    }
}
