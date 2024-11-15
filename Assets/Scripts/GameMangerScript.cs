using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMangerScript : MonoBehaviour
{
    public GameObject livesDisplay;
    public GameObject gameOverDisplay;    
    private int lives = 3;
    private TMP_Text livesDisplayText;
    public static GameMangerScript gameMangerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameMangerScript = this;
        livesDisplayText = livesDisplay.GetComponent<TMP_Text>();
        UpdateLivesDisplay();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateLivesDisplay()
    {
        livesDisplayText.text = "Lives: " + lives;
        if(lives < 1)
        {
            gameOverDisplay.SetActive(true);
            Invoke("gotoMainManu", 3.0f);
        }
    }

    public void loseLives(int lives)
    {
        this.lives -= lives;
        UpdateLivesDisplay();
    }

    private void gotoMainManu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
