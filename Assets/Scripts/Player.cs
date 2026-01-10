using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;
  

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
       _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
    private void Update()
    {
        Movement();
        PlantSeed();
    }
    private void Movement()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(movex, movey);
        _playerTransform.Translate(movement * _speed * Time.deltaTime);
    }


    public void PlantSeed ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _numSeedsLeft > 0) { Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            _numSeedsLeft--;
                _numSeedsPlanted++;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}
