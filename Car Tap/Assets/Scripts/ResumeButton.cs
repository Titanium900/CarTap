using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour {
    public Button resumeButton;
    public GameObject pauseMenu;
    void Start()
    {
        Button btn1 = resumeButton.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Destroy(pauseMenu.gameObject);
        Destroy(this);
        Time.timeScale = 1;
    }
}
