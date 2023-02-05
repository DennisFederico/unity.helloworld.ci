using UnityEngine;

public class Manager : MonoBehaviour {
    [SerializeField] private Transform[] wordPrefabs;

    private readonly int _replaceTime = 2;
    private float _totalTime;
    private int _currentIndex;
    private int _totalWords;

    private void Awake() {
        _totalWords = wordPrefabs.Length;
        wordPrefabs[_currentIndex].gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update() {
        _totalTime += Time.deltaTime;
        if (_totalTime < _replaceTime) return;
        _totalTime = 0;
        wordPrefabs[_currentIndex++ % _totalWords].gameObject.SetActive(false);
        wordPrefabs[_currentIndex % _totalWords].gameObject.SetActive(true);
    }
}