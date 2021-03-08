using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemStopActionBehavior : MonoBehaviour
{
    #region Private Variables

        [SerializeField]
        private bool _mode = true;

        [SerializeField]
        private GameObject _gameObjectToEnable = null;

    #endregion

    #region Main Methods

        void Start()
        {
            var main = GetComponent<ParticleSystem>().main;
            main.stopAction = ParticleSystemStopAction.Callback;
        }

        void OnParticleSystemStopped()
        {
            EnableObject();
        }
        
    #endregion


    #region Utility Methods

        public void EnableObject()
        {
            if (_mode == true)
            {
                _gameObjectToEnable.SetActive(true);
            }
            else{
                if(_gameObjectToEnable.activeInHierarchy == true)
                {
                    _gameObjectToEnable.SetActive(false);
                }
            }
        }

    #endregion


    #region Utility Events

    #endregion
}
