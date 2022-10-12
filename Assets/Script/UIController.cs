using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button Retry;

   public  void PlayAgain()
    {
        SceneManager.LoadScene("Level");

    }
}
