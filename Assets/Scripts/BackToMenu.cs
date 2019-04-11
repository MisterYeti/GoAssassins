using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour {

    [SerializeField]
    GameObject m_Menu;
    [SerializeField]
    GameObject m_Quit;
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (m_Quit.activeSelf)
            {
                SetTimeScale(1);
                m_Quit.SetActive(false);
            }
            else if (!m_Menu.activeSelf)
            {
                m_Quit.SetActive(true);
                SetTimeScale(0);
            }
        }
	}

    public void SetTimeScale(int scale)
    {
        Time.timeScale = scale;
    }
}
