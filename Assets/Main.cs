using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {
	public Text infoText;
	public SpriteRenderer hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = gameObject.transform.position;
		Vector3 dir = -gameObject.transform.right;
		// public static Collider2D OverlapPoint(Vector2 point, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity); 
		RaycastHit2D ray = Physics2D.Raycast(pos, dir);
		if (ray.collider) {
			infoText.text = ray.collider.name;
			hit.enabled = true;
			Vector2 hitPos = ray.point;
			hit.gameObject.transform.position = new Vector3(hitPos.x, hitPos.y, 0);
		} else {
			infoText.text = "No data";
			hit.enabled = false;
		}
		transform.Rotate(new Vector3(0, 0, -Input.GetAxisRaw("Horizontal")*Time.deltaTime*50.0f));
	}
}
