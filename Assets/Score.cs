using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    private List<int> hiscores = new List<int>();
    static bool scoreRecorded = false;
    public Text hiscore1;
    public Text hiscore2;
    public Text hiscore3;
    public Text hiscore4;
    public Text hiscore5;
    public Text hiscore6;
    public Text hiscore7;
    public Text hiscore8;
    public Text hiscore9;
    public Text hiscore10;

    private void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
            hiscores.Add(0);
        if (PlayerPrefs.GetInt("numofscores") > 0)
        {
            for (int i = 0; i < PlayerPrefs.GetInt("numofscores"); i++)
                hiscores.Add(PlayerPrefs.GetInt("hiscore" + i));

        }
        scoreRecorded = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sky.dead == true && scoreRecorded == false) recordScore();
    }
    void recordScore()
    {
        hiscores.Add(Nest.score);
        hiscores.Sort();
        hiscores.Reverse();
        PlayerPrefs.SetInt("numofscores", hiscores.Count);

        for (int i = 0; i < 10; i++)
            PlayerPrefs.SetInt("hiscore" + i, hiscores[i]);
        hiscore1.text = hiscores[0].ToString();
        hiscore2.text = hiscores[1].ToString();
        hiscore3.text = hiscores[2].ToString();
        hiscore4.text = hiscores[3].ToString();
        hiscore5.text = hiscores[4].ToString();
        hiscore6.text = hiscores[5].ToString();
        hiscore7.text = hiscores[6].ToString();
        hiscore8.text = hiscores[7].ToString();
        hiscore9.text = hiscores[9].ToString();
        hiscore10.text = hiscores[9].ToString();
        /*
        switch (hiscores.Count)
        {
            case 1:
                hiscore1.text = hiscores[0].ToString();
                break;
            case 2:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                break;
            case 3:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                break;
            case 4:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                hiscore4.text = hiscores[3].ToString();
                break;
            case 5:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                hiscore4.text = hiscores[3].ToString();
                hiscore5.text = hiscores[4].ToString();
                break;
            case 6:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                hiscore4.text = hiscores[3].ToString();
                hiscore5.text = hiscores[4].ToString();
                hiscore6.text = hiscores[5].ToString();
                break;
            case 7:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                hiscore4.text = hiscores[3].ToString();
                hiscore5.text = hiscores[4].ToString();
                hiscore6.text = hiscores[5].ToString();
                hiscore7.text = hiscores[6].ToString();
                break;
            case 8:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                hiscore4.text = hiscores[3].ToString();
                hiscore5.text = hiscores[4].ToString();
                hiscore6.text = hiscores[5].ToString();
                hiscore7.text = hiscores[6].ToString();
                hiscore8.text = hiscores[7].ToString();
                break;
            case 9:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                hiscore4.text = hiscores[3].ToString();
                hiscore5.text = hiscores[4].ToString();
                hiscore6.text = hiscores[5].ToString();
                hiscore7.text = hiscores[6].ToString();
                hiscore8.text = hiscores[7].ToString();
                hiscore9.text = hiscores[9].ToString();
                break;
            case 10:
                hiscore1.text = hiscores[0].ToString();
                hiscore2.text = hiscores[1].ToString();
                hiscore3.text = hiscores[2].ToString();
                hiscore4.text = hiscores[3].ToString();
                hiscore5.text = hiscores[4].ToString();
                hiscore6.text = hiscores[5].ToString();
                hiscore7.text = hiscores[6].ToString();
                hiscore8.text = hiscores[7].ToString();
                hiscore9.text = hiscores[9].ToString();
                hiscore10.text = hiscores[9].ToString();
                break;
                }
                */


        scoreRecorded = true;
    }
}
/*
 * when (gameover == true){ListOfScores.add(Sky.score)}
 * ListofScores.Sort()
 * */