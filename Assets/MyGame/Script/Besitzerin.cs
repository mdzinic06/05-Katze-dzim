using UnityEngine;

public class Besitzerin : MonoBehaviour
{
    [SerializeField] private string besitzerinName;
    [SerializeField] private Katze haustier;
    private void Start()
    {
        RufeKatze();
    }
    public void RufeKatze()
    {
        Debug.Log(besitzerinName + " ruft " + haustier.gameObject.name);
        haustier.Miauen();
    }
}
