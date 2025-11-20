using UnityEngine;
using UnityEngine. Events;
public class LevelAnimation : MonoBehaviour
{
    [SerializeField]

    private string readySoundName = "Ready";
    [SerializeField]

    private string goSoundName = "GO!";
    [SerializeField]

    private string LevelAnimationName = "LevelAnimation";
    [SerializeField]

    private UnityEvent onStartGame;
    [SerializeField]

    private Animator animator;

    private void Start()
    {
        animator.Play(LevelAnimationName, 0 , 0f);
    
    }

    public void ReadyEvent()
    {
        SoundManager.instance.Play(readySoundName);

    }

    public void GoEvent()
    {
        SoundManager.instance.Play(goSoundName);
    }


    public void StartGame()
    {
        onStartGame?.Invoke();
    }



}
