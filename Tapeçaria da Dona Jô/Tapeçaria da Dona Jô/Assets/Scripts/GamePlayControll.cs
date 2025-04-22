using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayControll : MonoBehaviour
{
    public static GamePlayControll instance;

    public List<GameObject> BlocksList = new List<GameObject>();

    // Lista para saber a quantidade de blocos para cada número

    [SerializeField] private List<GameObject> NumberOneList = new List<GameObject>();
    [SerializeField] private List<GameObject> NumberTwoList = new List<GameObject>();
    [SerializeField] private List<GameObject> NumberThreeList = new List<GameObject>();
    [SerializeField] private List<GameObject> NumberFourList = new List<GameObject>();
    [SerializeField] private List<GameObject> NumberFiveList = new List<GameObject>();

    // Butões 

    [SerializeField] private Button ButtonClosePainelComplete;
    [SerializeField] private Button ButtonReturn;

    // UI

    [SerializeField] private GameObject CompletePainel;
    [SerializeField] private GameObject BlurPainel;

    // Variáveis

    public int blockNumber;
    public int totalNumberBlocksCount;

    [SerializeField] private int totalNumberOneCount;
    [SerializeField] private int totalNumberTwoCount;
    [SerializeField] private int totalNumberThreeCount;
    [SerializeField] private int totalNumberFourCount;
    [SerializeField] private int totalNumberFiveCount;

    private bool numberOne = false;
    private bool numberTwo = false;
    private bool numberThree = false;
    private bool numberFour = false;
    private bool numberFive = false;
    

    private bool painel = false;

    // Objetos com os números normais

    [SerializeField] private GameObject NumberOne;
    [SerializeField] private GameObject NumberTwoPanel;
    [SerializeField] private GameObject NumberThreePanel;
    [SerializeField] private GameObject NumberFourPanel;
    [SerializeField] private GameObject NumberFivePanel;

    // Objetos com os números falsos (barreiras)

    [SerializeField] private GameObject NumberTwoBarrier;
    [SerializeField] private GameObject NumberThreeBarrier;
    [SerializeField] private GameObject NumberFourBarrier;
    [SerializeField] private GameObject NumberFiveBarrier;

    private void Awake()
    {
        ButtonClosePainelComplete.onClick.AddListener(OnButtonCloseClick);
        ButtonReturn.onClick.AddListener(OnButtonReturnClick);

    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        totalNumberBlocksCount = BlocksList.Count;

        totalNumberOneCount = NumberOneList.Count;
        totalNumberTwoCount = NumberTwoList.Count;
        totalNumberThreeCount = NumberThreeList.Count;
        totalNumberFourCount = NumberFourList.Count;
        totalNumberFiveCount = NumberFiveList.Count;
    }

    // Update is called once per frame
    void Update()
    {
 
        CompleteBlock();
    }

    void OnButtonCloseClick()
    {
        AudioControll.current.ChangecloseCompletePainelMscBGM();
        CompletePainel.SetActive(false);
    }

    private void OnButtonReturnClick()
    {
        AudioControll.current.PlayMusic(AudioControll.current.ButtonClick);
        SceneManager.LoadScene(1);
    }


    public void CompleteBlock()
    {
        if (!painel && blockNumber >= totalNumberBlocksCount)
        {
            CompletePainel.SetActive(true);
            BlurPainel.SetActive(false);
            AudioControll.current.ChangeCompleteMscBGM();
            painel = true;
        }

     
        if(!numberTwo && blockNumber >= totalNumberOneCount)
        {
            NumberTwoPanel.SetActive(true);
            NumberTwoBarrier.SetActive(false);
            numberTwo = true;
        }

        if (!numberThree && blockNumber >= totalNumberTwoCount + totalNumberOneCount)
        {
            NumberThreePanel.SetActive(true);
            NumberThreeBarrier.SetActive(false);
            numberThree = true;
        }

        if (!numberFour && blockNumber >= totalNumberThreeCount + totalNumberTwoCount + totalNumberOneCount)
        {
            NumberFourPanel.SetActive(true);
            NumberFourBarrier.SetActive(false);
            numberFour = true;

        }

        if (!numberFive && blockNumber >= totalNumberFourCount + totalNumberThreeCount + totalNumberTwoCount + totalNumberOneCount)
        {
            NumberFivePanel.SetActive(true);
            NumberFiveBarrier.SetActive(false);
            numberFive = true;
        }
    }
}
