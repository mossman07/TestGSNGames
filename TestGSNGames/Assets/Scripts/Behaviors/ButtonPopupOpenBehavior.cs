using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPopupOpenBehavior : MonoBehaviour, IPointerClickHandler
{
    
    #region Private Variables

        [SerializeField]
        private GameObject _gameObjectToEnable = null;
        
        [SerializeField]
        private GameObject _gameObjectToDisable = null;

    #endregion

    #region Main Methods

        public void OnPointerClick(PointerEventData aEventData)
        {
            _gameObjectToEnable.SetActive(true);
            _gameObjectToDisable.SetActive(false);
        }
        
    #endregion


    #region Utility Methods

    #endregion


    #region Utility Events

    #endregion
}
