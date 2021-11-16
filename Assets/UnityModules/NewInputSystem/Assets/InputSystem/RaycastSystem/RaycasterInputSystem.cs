using UnityEngine;

public class RaycasterInputSystem : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float distanceCast = 50f;
    private void Awake()
    {
        inputManager.OneTapedIgnoredDoubleTap += OnOneTapedIgnoredDoubleTap;
        inputManager.DoubleTaped += OnDoubleTaped;
    }
    
    //TODO rework Пускать ОДИН для всех эвентов луч по координатам мышки,если вызван хотя бы один эвент
    private void OnDoubleTaped(object sender, Vector2 e)
    {
        RaycastHit2D[] hits = GetRayCastHits(e);
        for (int i = 0; i < hits.Length; i++)
        {
            var raycastedObject = hits[i].collider.gameObject.GetComponent<IRaycastedObjectDoubleTap>();
            raycastedObject?.DoubleTap();
        }
    }

    private void OnOneTapedIgnoredDoubleTap(object sender, Vector2 e)
    {
        RaycastHit2D[] hits = GetRayCastHits(e);
        
        for (int i = 0; i < hits.Length; i++)
        {
            var raycastedObject = hits[i].collider.gameObject.GetComponent<IRaycastedObjectOneTap>();
            raycastedObject?.OneTap();
        }
    }

    private RaycastHit2D[] GetRayCastHits(Vector2 e)
    {
        Ray ray = Camera.main.ScreenPointToRay (e);
        return Physics2D.GetRayIntersectionAll (ray, distanceCast);
    }
}
