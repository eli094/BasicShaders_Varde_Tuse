using UnityEngine;

public class HologramSpawner : MonoBehaviour
{
    public GameObject unityPrefab;  
    public Transform spawnPoint;     
    public Material hologramMaterial; 

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newUnity = Instantiate(unityPrefab, spawnPoint.position, spawnPoint.rotation);

            Renderer unidadRenderer = newUnity.GetComponent<Renderer>();
            if (unidadRenderer != null)
            {
                unidadRenderer.material = hologramMaterial;
            }
        }
    }
}

