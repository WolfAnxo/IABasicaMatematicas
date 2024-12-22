using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;

    void Start() {

        this.transform.Translate(6, 0, 2);
    }

    private void Update() {

    }
}
