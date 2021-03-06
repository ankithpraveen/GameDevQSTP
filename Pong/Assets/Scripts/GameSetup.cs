using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSetup : MonoBehaviour
{
    public Camera mainCam;

    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player1;
    public Transform player2;

    public RectTransform pauseButton;
    public RectTransform volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        // volumeSlider = GetComponent<Slider>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        topWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x, 0f);

        rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 1f, 0f);

        leftWall.isTrigger = true;
        rightWall.isTrigger = true;

        player1.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, player1.position.y);
        player2.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x, player2.position.y);

        //pauseButton.position = new Vector3(pauseButton.position.x, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height - 500f, 0f)).y, 0);
        pauseButton.position = new Vector3(pauseButton.position.x, Screen.height - 50f, 0);
        volumeSlider.position = new Vector3(volumeSlider.position.x, 50f, 0);
        // volumeSlider.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - Screen.width/5, 0f, 0f)).x, volumeSlider.position.y);
    }
}
