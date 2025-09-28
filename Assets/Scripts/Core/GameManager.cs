using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    private void Awake() { Instance = this; }
    public void Victory() { Debug.Log("Victory!"); }
    public void Failure() { Debug.Log("Failure!"); }
}
