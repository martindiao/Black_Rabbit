using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    public class pause_menu : MonoBehaviour
    {

        public bool isShow;
        public GameObject pauseMenu;
        // Start is called before the first frame update
        void Start()
        {
            isShow = false;
            pauseMenu.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                isShow = !isShow;
                if (isShow)
                {
                    Time.timeScale = 0;
                }
                else
                {
                    Time.timeScale = 1;
                }
                pauseMenu.SetActive(isShow);
            }
        }
    }
}

