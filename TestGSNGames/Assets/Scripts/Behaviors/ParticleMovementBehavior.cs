using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////https://answers.unity.com/questions/1001895/i-am-trying-to-implement-a-magnetic-field-with-par.html?_ga=2.184444582.1022382025.1615121203-391755865.1605882140
[RequireComponent(typeof(ParticleSystem))]
public class ParticleMovementBehavior : MonoBehaviour {

	#region Private Variables

		[SerializeField]
		private Transform _target = null;

		[SerializeField]
		private float _speed = 1;

		[SerializeField]
		private float _lifeTime = 1;

		//[SerializeField]
		//private AnimationCurve _sizeOverLifeTimeMultiplier;

        private ParticleSystem _myParticleSystem;

		private ParticleSystem.MainModule _myMainModule;
		
		//private ParticleSystem.SizeOverLifetimeModule _sizeOverLifetimeModule;

		//private float _timer = 0.0f;

		private ParticleSystem.Particle[] _particles = new ParticleSystem.Particle[1000];
    #endregion


    #region Main Methods

		void Awake() {
			_myParticleSystem = gameObject.GetComponent<ParticleSystem>();
		}

		void Start() {
			_myMainModule = _myParticleSystem.main;
			//_sizeOverLifetimeModule = _myParticleSystem.sizeOverLifetime;
		}

		void LateUpdate() {
			_myMainModule.startLifetime = _lifeTime;
			
			if (_myParticleSystem.isPlaying) {
                int _particleCount = _myParticleSystem.GetParticles(_particles);
     
                for (int i = 0; i < _particleCount; i++)
				{ 
                	_particles[i].position = _particles[i].position + (_target.position - _particles[i].position) / _particles[i].remainingLifetime * Time.deltaTime * _speed;					
                }

                _myParticleSystem.SetParticles(_particles, _particleCount);


				/*_timer += Time.deltaTime;
				float _evaluationTime = _timer / _lifeTime;
			
				_sizeOverLifetimeModule.xMultiplier = _sizeOverLifeTimeMultiplier.Evaluate(_evaluationTime);

				if (_timer > _lifeTime)
				{
					_timer = 0;
				}*/
             }			
		}

	#endregion


    #region Utility Methods

    #endregion


    #region Utility Events

    #endregion
}