using UnityEngine.SceneManagement;
using UnityEngine;

public class EndTutorial : MonoBehaviour
{

    public GameMenager gameManager;
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
    }

}
