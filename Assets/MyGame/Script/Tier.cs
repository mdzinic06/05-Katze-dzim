using UnityEngine;

public class Tier : MonoBehaviour
{
    [SerializeField] private string art; 
    
    public void Fressen()
    {
        Debug.Log(art + " frisst!");
    }
}
