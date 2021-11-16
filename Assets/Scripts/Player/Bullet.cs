using UnityEngine;

public class Bullet : MonoBehaviour, IDamageableBullet
{
    [SerializeField] private GameObject mainObject;//TODO Сделать пулы объектов и не удалять, а выключать
    public void Caught()
    {
        Destroy(mainObject);
    }
}