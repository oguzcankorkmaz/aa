using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    void Start()
    {
       PlayerPrefs.DeleteAll();
    }



    public void OyunaBasla()
    {
        int kayitliLevel = PlayerPrefs.GetInt("kayit");

        if(kayitliLevel == 0)
        {
            SceneManager.LoadScene(kayitliLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(kayitliLevel);
        }

        SceneManager.LoadScene(PlayerPrefs.GetInt("kayit"));
    }
    public void Cikis()
    {
        Application.Quit();
    }
	
}
