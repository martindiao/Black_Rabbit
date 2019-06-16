using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_base : MonoBehaviour
{

    public void LoadScene(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
