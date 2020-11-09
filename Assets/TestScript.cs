using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;
    int spacebarPress = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Start Function";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
            spacebarPress += 1;
            print("Spacebar Pressed " + spacebarPress + " Times");
            scoreText.GetComponent<Text>().text = "Spacebar " + spacebarPress + " Times";
		}
    }
}
