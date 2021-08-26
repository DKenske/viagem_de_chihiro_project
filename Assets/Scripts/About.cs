using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class About : MonoBehaviour
{
    public GameObject credits;
    private int yes=0;


    private void Update()
    {
        QuitAbout();
    }
    public void AboutGame()
    {
        if (yes == 0)
        {
            credits.SetActive(true);
            yes = 1;
        }
    }

    public void QuitAbout()
    {
        if (yes == 1 && Input.GetKeyDown(KeyCode.Escape))
        {
            credits.SetActive(false);
            yes = 0;
        }
    }
}
