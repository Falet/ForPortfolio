using UnityEngine;

public class PointerForCharacterIcon : MonoBehaviour, IRaycastedObjectOneTap, IRaycastedObjectDoubleTap
{
    public void OneTap()
    {
        Debug.Log("Action On OneTap");
    }

    public void DoubleTap()
    {
        Debug.Log("Action On DoubleTap");
    }
}
