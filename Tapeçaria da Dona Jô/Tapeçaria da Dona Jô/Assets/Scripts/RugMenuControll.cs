using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RugMenuControll : MonoBehaviour
{
    [SerializeField] private Button ButtonRug_One;
    [SerializeField] private Button ButtonRug_Two;
    [SerializeField] private Button ButtonRug_Three;
    [SerializeField] private Button ButtonMainMenu;

    private void Awake()
    {
        ButtonMainMenu.onClick.AddListener(OnButtonMainMenuClick);
        ButtonRug_One.onClick.AddListener(OnButtonRugOneClick);
        ButtonRug_Two.onClick.AddListener(OnButtonRugTwoClick);
        ButtonRug_Three.onClick.AddListener(OnButtonRugThreeClick);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonMainMenuClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        SceneManager.LoadScene(0);
    }

    void OnButtonRugOneClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        SceneManager.LoadScene(2);
    }

    void OnButtonRugTwoClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        SceneManager.LoadScene(3);
    }

    void OnButtonRugThreeClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        SceneManager.LoadScene(4);
    }
}
