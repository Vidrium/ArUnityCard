using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Enigme : MonoBehaviour
{
    public Dictionary<int, string> enigmes = new Dictionary<int, string>();
    public List<int> enigmeMentioned = new List<int>();
    public Text enigmeText;
    public string enigme = "";

    private int number;

    // Start is called before the first frame update
    void Start()
    {
        enigmeMentioned.Add(1);
        enigmeMentioned.Add(2);
        enigmeMentioned.Add(3);
        enigmes.Add(1, "Qu’est-ce qu’un homme peut porter mais que 10 hommes ne peuvent mettre debout ?");
        enigmes.Add(2, "Qu’est ce qui se brise quand on me prononce ?");
        enigmes.Add(3, "Qu'est-ce qui à des cités mais pas de maison, des forêts mais pas d'arbres et des rivières mais pas d'eau ?");

        int random = RandomEnigme();
        enigme = enigmes[random];
        Debug.Log("enigme : " + enigme);
        enigmeText.text = enigme;
    }

    // Update is called once per frame
    void Update()
    {



    }

    private int RandomEnigme()
    {
        number = Random.Range(1, 3);
        bool notMentioned = enigmeMentioned.Contains(number);
        if (notMentioned == true)
        {
            enigmeMentioned.Remove(number);
        }

        return number;
    }


}