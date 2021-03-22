using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    
    void Start()
    {

    }

  
    void Update()
    {
        
    }


    public void ChangeToColorScene()
    {
        SceneManager.LoadScene("01colorScene");
  
    }

    public void ChangeToNumberScene()
    {
        SceneManager.LoadScene("02numberScene");

    }

    public void ChangeToWelcomeScene()
    {
        SceneManager.LoadScene("00welcomeScene");

    }
}
