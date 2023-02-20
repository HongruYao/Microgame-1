using UnityEngine;

public class EgamMicrogameHelper : MonoBehaviour
{
    // Instance prefabs 
    [HideInInspector][SerializeField] private EgamMicrogameInstance _instancePrefab = null;

    // Game values
    [SerializeField] private string _gameCommand = "Command!";
    [SerializeField] private float _gameDuration = 10f;
    public WinLose _timeoutResult = WinLose.Lose;
    public EgamMicrogameInstance instance;
    public enum WinLose
    {
        Win,
        Lose
    }

    void Awake()
    {
        // Make sure an instance exists!
        instance = GameObject.FindObjectOfType<EgamMicrogameInstance>();
        if (instance == null)
        {
            instance = GameObject.Instantiate<EgamMicrogameInstance>(_instancePrefab);
        }

        // Apply the values
        instance.StartGame(_gameCommand, _gameDuration, _timeoutResult);
    }
}
