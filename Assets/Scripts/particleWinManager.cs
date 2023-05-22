using UnityEngine;

public class particleWinManager : MonoBehaviour
{
    private ParticleSystem confettis;
    public static bool canPlay;
    void Start()
    {
        confettis = GetComponent<ParticleSystem>();
        canPlay = false;
    }
    void Update()
    {
        if (canPlay == true)
        {
            confettis.Play();
        }
    }
}
