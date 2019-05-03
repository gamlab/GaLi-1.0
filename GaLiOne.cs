using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GaLiOne {

    /// <summary>To use this, Assign abstract properties : 1.List of string as dialogue, 2.Boolean that control the moving of the dialogue, and Then just call setActive()
    /// </summary>
    public abstract class DialogueManager : MonoBehaviour {
        private Image dialogueBackground;
        private Text dialogueText;
        private int listLength;
        private int iterator;

        //using linked list will not be a bad idea
        /// <summary>List of string will be use as the dialogue texts.
        /// </summary>
        abstract public List<string> listString { get; }
        /// <summary>Give the trigger value that control the moving of the dialogue.
        /// </summary>
        abstract public bool getTriggerButtonValue();


        void checkComponent() {
            dialogueBackground = gameObject.GetComponent<Image>();
            dialogueText = gameObject.GetComponentInChildren<Text>();
            if (dialogueBackground == null) {
                Debug.LogError("Can't Find Image in gameObject Component !");
            }
            if (dialogueText == null) {
                Debug.LogError("Can't Find Text Component in gameObject Children !");
            }
        }

        void clear() {
            gameObject.SetActive(false);
        }
        public void setActive() {
            dialogueText.text = listString[0];
            listLength = listString.Count;
            iterator = 1;
            gameObject.SetActive(true);
        }

        // Use this for initialization
        void Start() {
            checkComponent();
            clear();
        }

        // Update is called once per frame
        void Update() {
            if (getTriggerButtonValue()) {
                if (iterator == listLength) {
                    clear();
                    return;
                }
                dialogueText.text = listString[iterator++];
            }
        }
    }
}