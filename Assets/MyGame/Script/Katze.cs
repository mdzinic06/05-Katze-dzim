using UnityEngine;

public class Katze : Tier
{
    [SerializeField] private string katzenName;
    public void Miauen()
    {
        Debug.Log(katzenName + " miaut leise!");
    }

}
