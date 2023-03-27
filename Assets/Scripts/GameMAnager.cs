using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMAnager : MonoBehaviour
{ 
    public static int SelectCharacterChoice;
    
  
    public void SelectCharacter(int choice)
    {
        SelectCharacterChoice = choice;
    }
    public void SelectLevel(int levelnumber)
    {
        SceneManager.LoadScene(levelnumber);
    }
}
