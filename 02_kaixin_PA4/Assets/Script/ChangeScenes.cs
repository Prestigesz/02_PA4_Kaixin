using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void MyLoadingFunction()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=1)
        {
            SceneManager.LoadScene(1);
        }
    }
}
