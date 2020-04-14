
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameMenager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
