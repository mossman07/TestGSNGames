using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonBuyAllBehavior : MonoBehaviour, IPointerClickHandler
{
    
    #region Private Variables

        [SerializeField]
        private GameObject _gameObjectToEnable = null;

    #endregion

    #region Main Methods

        public void OnPointerClick(PointerEventData aEventData)
        {
            _gameObjectToEnable.SetActive(true);
        }
        
    #endregion


    #region Utility Methods

    #endregion


    #region Utility Events

    #endregion
}
