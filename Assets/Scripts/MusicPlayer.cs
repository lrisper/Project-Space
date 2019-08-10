using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public void Awake()
    {

        int numOfMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;

        if (numOfMusicPlayers > 1)
        {
            Destroy(gameObject);

        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }
}
