using UnityEngine;
using System.Collections;

public class SpawnPointGizmo : MonoBehaviour
{

    private SpawnPoint spawnPoint;

    void Awake()
    {
        spawnPoint = GetComponent<SpawnPoint>();
    }

#if UNITY_EDITOR
    [SerializeField] private Color _color;
	void OnDrawGizmos()
	{
        // Gizmo rengini, Spawn point kullanima acik ise yesil, degil ise kirmizi renge set et.
        if (spawnPoint)
        {
            if (spawnPoint.SpawnTimer <= 0)
            {
                Gizmos.color = new Color(0,1,0,0.5f);
            }
            else
            {
                Gizmos.color = new Color(1, 0, 0, 0.5f);
            }
        }
        else
            Gizmos.color = _color;

        // Draw spawn point gizmo  
        Vector3 startPoint = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
		Gizmos.DrawSphere(startPoint, 1);

        
	}
#endif
}