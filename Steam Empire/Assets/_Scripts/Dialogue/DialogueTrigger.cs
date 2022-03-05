using UnityEngine;

namespace _Scripts.Dialogue
{
    public class DialogueTrigger : MonoBehaviour
    {
        [Header("Visual Cue")]
        [SerializeField] private GameObject visualCue;

        [Header("Ink JSON")]
        [SerializeField] private TextAsset inkJson;

        private bool _playerInRange;

        private void Awake() 
        {
            _playerInRange = false;
            visualCue.SetActive(false);
        }

        private void Update() 
        {
            if (_playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying) 
            {
                visualCue.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E)) 
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJson);
                }
            }
            else 
            {
                visualCue.SetActive(false);
            }
        }

        private void OnTriggerEnter(Collider col) 
        {
            if (col.gameObject.CompareTag("Player"))
            {
                _playerInRange = true;
            }
        }

        private void OnTriggerExit(Collider col) 
        {
            if (col.gameObject.CompareTag("Player"))
            {
                _playerInRange = false;
            }
        }
    }
}
