using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelKilitSistemi : MonoBehaviour {

    public Sprite kilittexture;
    public Sprite aciktexture;
    public Image[] Levels;
    public Text[] levelNumbers;
    public GameObject popUP; // prefab to instantiate
    public Canvas canvas; // father canvas
    private Vector2 position = new Vector2(340, 225);

    void Start () {

        //position.x = Random.Range(-10f, 10f);
        //position.y = Random.Range(-10f, 10f);
        
        if(PlayerPrefs.GetInt("1") == 0)
        {
            Levels[0].sprite = aciktexture;
            levelNumbers[0].text = "1";
        }
		else
        {
            Levels[0].sprite = aciktexture;
            levelNumbers[0].text = "1";
        }
        if (PlayerPrefs.GetInt("2") == 1)
        {
            Levels[1].sprite = aciktexture;
            levelNumbers[1].text = "2";
        }
        else
        {
            Levels[1].sprite = kilittexture;
            levelNumbers[1].text = "2";
        }
        if (PlayerPrefs.GetInt("3") == 1)
        {
            Levels[2].sprite = aciktexture;
            levelNumbers[2].text = "3";
        }
        else
        {
            Levels[2].sprite = kilittexture;
            levelNumbers[2].text = "3";
        }
        if (PlayerPrefs.GetInt("4") == 1)
        {
            Levels[3].sprite = aciktexture;
            levelNumbers[3].text = "4";
        }
        else
        {
            Levels[3].sprite = kilittexture;
            levelNumbers[3].text = "4";
        }
        if (PlayerPrefs.GetInt("5") == 1)
        {
            Levels[4].sprite = aciktexture;
            levelNumbers[4].text = "5";
        }
        else
        {
            Levels[4].sprite = kilittexture;
            levelNumbers[4].text = "5";
        }
        if (PlayerPrefs.GetInt("6") == 1)
        {
            Levels[5].sprite = aciktexture;
            levelNumbers[5].text = "6";
        }
        else
        {
            Levels[5].sprite = kilittexture;
            levelNumbers[5].text = "6";
        }
        if (PlayerPrefs.GetInt("7") == 1)
        {
            Levels[6].sprite = aciktexture;
            levelNumbers[6].text = "7";
        }
        else
        {
            Levels[6].sprite = kilittexture;
            levelNumbers[6].text = "7";
        }
        if (PlayerPrefs.GetInt("8") == 1)
        {
            Levels[7].sprite = aciktexture;
            levelNumbers[7].text = "8";
        }
        else
        {
            Levels[7].sprite = kilittexture;
            levelNumbers[7].text = "8";
        }
        if (PlayerPrefs.GetInt("9") == 1)
        {
            Levels[8].sprite = aciktexture;
            levelNumbers[8].text = "9";
        }
        else
        {
            Levels[8].sprite = kilittexture;
            levelNumbers[8].text = "9";
        }
        if (PlayerPrefs.GetInt("10") == 1)
        {
            Levels[9].sprite = aciktexture;
            levelNumbers[9].text = "10";
        }
        else
        {
            Levels[9].sprite = kilittexture;
            levelNumbers[9].text = "10";
        }
    }
	
	// Update is called once per frame
	public void LevelAc (string kacincilevel) {
        if (kacincilevel == "1")
        {
            Application.LoadLevel(kacincilevel);
              
        }
        if (kacincilevel == "2")
        {
            if (PlayerPrefs.GetInt("2") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "3")
        {
            if (PlayerPrefs.GetInt("3") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "4")
        {
            if (PlayerPrefs.GetInt("4") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "5")
        {
            if (PlayerPrefs.GetInt("5") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "6")
        {
            if (PlayerPrefs.GetInt("6") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "7")
        {
            if (PlayerPrefs.GetInt("7") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "8")
        {
            if (PlayerPrefs.GetInt("8") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "9")
        {
            if (PlayerPrefs.GetInt("9") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }
        if (kacincilevel == "10")
        {
            if (PlayerPrefs.GetInt("10") == 1)
            {
                Application.LoadLevel(kacincilevel);
            }
            else
            {
                Debug.Log("Level Açık Değil");
            }
        }

    }
    public void backToMaiMenu()
    {
        Application.LoadLevel("MainMenuLive");
    }

    public void PopUP()

    {
        GameObject inst = (GameObject)Instantiate(popUP, position, Quaternion.identity);
        inst.transform.SetParent(canvas.transform);
        Destroy(inst, 2.0f);
    }

}
