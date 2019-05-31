using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Black_Rabbit
{
    public class task_message : MonoBehaviour
    {

        public Text content;

        public void ShowTask(string content_text)
        {
            content.text = content_text;
            this.GetComponent<CanvasGroup>().alpha = 1;

        }

        public void HideTask()
        {
            this.GetComponent<CanvasGroup>().alpha = 0;
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

}
