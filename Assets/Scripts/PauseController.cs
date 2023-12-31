using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseController : MonoBehaviour
{
    public UnityEvent GamePaused;
    public UnityEvent GameResumed;
    private bool _isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _isPaused = !_isPaused;

            if (_isPaused)
            {
                Time.timeScale = 0f;
                GamePaused.Invoke();
            }
            else
            {
                Time.timeScale = 1f;
                GameResumed.Invoke();
            }
        }
    }
}
