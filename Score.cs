using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{

    bool gameHasEnded = false;
    
    public Transform player;
    public Text scoreText;
   
    
    void Update ()
    {
        if (gameHasEnded == false)
        {
            scoreText.text = player.position.z.ToString("0");

        }
            

    }
    public void ColisionScore()
    {
        gameHasEnded = true;
        scoreText.text = player.position.z.ToString("0");
    }
    
}
