using UnityEngine.SceneManagement;
using UnityEngine;

public class InputEvent : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Home))
            SceneManager.LoadScene("MainMenu");
        else if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");
    }
}
