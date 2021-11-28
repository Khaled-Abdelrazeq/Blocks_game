using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] float slowTime = 10;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void EndGame()
    {
        print("Ending Game");
        StartCoroutine(RestartLevelCoroutine());
    }

    private IEnumerator RestartLevelCoroutine()
    {
        Time.timeScale = Time.timeScale / slowTime;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowTime;

        yield return new WaitForSeconds(1 / slowTime);

        Time.timeScale = Time.timeScale / slowTime;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowTime;


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
