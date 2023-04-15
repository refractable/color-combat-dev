using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public int minutes = 3; // set the number of minutes here

    private float timer;
    public TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        timer = minutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        int minutesLeft = Mathf.FloorToInt(timer / 60f);
        int secondsLeft = Mathf.FloorToInt(timer % 60f);

        textMesh.text = string.Format("{0:0}:{1:00}", minutesLeft, secondsLeft);

        if (timer <= 0f)
        {
            // call your function here
            SceneManager.LoadScene("YouWin");
            textMesh.text = "DONE!";
        }
    }
}
