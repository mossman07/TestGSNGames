using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablerBehavior : MonoBehaviour
{
    
    #region Private Variables

        [SerializeField]
        private bool _mode = true;

        [SerializeField]
        private List<GameObject> _gameObjectsToEnable = new List<GameObject>();

    #endregion

    #region Main Methods
        
    #endregion


    #region Utility Methods

        public void EnableObject(int index)
        {
            if (_mode == true)
            {
                _gameObjectsToEnable[index].SetActive(true);
            }
            else{
                _gameObjectsToEnable[index].SetActive(false);
            }
        }

        public void EnableAllObjects()
        {
            for (int i = 0; i < _gameObjectsToEnable.Count; i++)
            {
                if (_mode == true)
                {
                    _gameObjectsToEnable[i].SetActive(true);
                }
                else{
                    _gameObjectsToEnable[i].SetActive(false);
                }
            }
        }

    #endregion


    #region Utility Events

    #endregion
}
