using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
	#region Field Declarations

	[Header("UI Components")]
    [Space]
	public Text scoreText;
    public StatusText statusText;
    public Button restartButton;

    [Header("Ship Counter")]
    [SerializeField]
    [Space]
	private Image[] shipImages;
	private GameSceneController gameController;
    #endregion

    #region Startup

    private void Awake()
    {
        statusText.gameObject.SetActive(false);
    }
    
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		gameController = FindObjectOfType<GameSceneController>();
		gameController.ScoreUpdatedOnKill += UpdateScore;
		gameController.LifeLost += HideShip;
	}

    #endregion

    #region Public methods

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString("D5");
    }

    public void ShowStatus(string newStatus)
    {
        statusText.gameObject.SetActive(true);
        StartCoroutine(statusText.ChangeStatus(newStatus));
    }

    public void HideShip(int imageIndex)
    {
        shipImages[imageIndex].gameObject.SetActive(false);
    }

    public void ResetShips()
    {
        foreach (Image ship in shipImages)
            ship.gameObject.SetActive(true);
    }

    #endregion
}
