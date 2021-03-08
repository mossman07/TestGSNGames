using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventPopupCloseBehavior : MonoBehaviour
{
    
    #region Private Variables

        [SerializeField]
        private GameObject _gameObjectToEnable = null;
        
        [SerializeField]
        private GameObject _gameObjectToDisable = null;

    #endregion

    #region Main Methods

    #endregion


    #region Utility Methods

        public void EndAnimationEvent(){
            _gameObjectToEnable.SetActive(true);
            _gameObjectToDisable.SetActive(false);
        }

    #endregion


    #region Utility Events

    #endregion
}
