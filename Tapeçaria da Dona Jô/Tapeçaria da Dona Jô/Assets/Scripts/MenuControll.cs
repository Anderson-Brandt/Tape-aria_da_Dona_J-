using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControll : MonoBehaviour
{
    [SerializeField] private GameObject CulturePainel;
    [SerializeField] private GameObject HistoryPainel;
    [SerializeField] private GameObject ObjetivoPainel;

    [SerializeField] private Button ButtonCulture;
    [SerializeField] private Button ButtonNext;
    [SerializeField] private Button ButtonBack;
    [SerializeField] private Button ButtonCloseCulture;
    [SerializeField] private Button ButtonPlay;


    private void Awake()
    {
        ButtonCulture.onClick.AddListener(OnButtonCulturePainelClick);
        ButtonNext.onClick.AddListener(OnButtonNextClick);
        ButtonBack.onClick.AddListener(OnButtonBackClick);
        ButtonCloseCulture.onClick.AddListener(OnButtonCloseCultureClick);
        ButtonPlay.onClick.AddListener(OnButtonPlayClick);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonCulturePainelClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        CulturePainel.SetActive(true);
    }
    void OnButtonCloseCultureClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        CulturePainel.SetActive(false);
    }

    void OnButtonBackClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        ObjetivoPainel.SetActive(false);
        HistoryPainel.SetActive(true);
    }
    void OnButtonNextClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        ObjetivoPainel.SetActive(true);
        HistoryPainel.SetActive(false);
    }

    private void OnButtonPlayClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        SceneManager.LoadScene(1);
    }
}
