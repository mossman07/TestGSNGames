using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPopupCloseBehavior : MonoBehaviour, IPointerClickHandler
{
    
    #region Private Variables

        [SerializeField]
        private Animator _popupAnimator = null;

    #endregion

    #region Main Methods

        public void OnPointerClick(PointerEventData aEventData)
        {
            _popupAnimator.SetTrigger("Out"); 
        }
        
    #endregion


    #region Utility Methods

    #endregion


    #region Utility Events

    #endregion
}
