using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CreditManager : MonoBehaviour
{
    public void OpenLink(){
        Application.OpenURL("https://www.linkedin.com/in/augusta-steven-0802/");
    }

    public void MainMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
