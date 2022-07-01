using System;
using System.Collections.Generic;
using UnityEngine;
using Abstracts;
using UnityEngine.UI;

namespace InputSystem
{

	public class CommandButtonView : MonoBehaviour
	{
		public Action<ICommandExecutor> OnClick;

		[SerializeField] private GameObject produceUnitButton;
		[SerializeField] private GameObject attacButton;
		[SerializeField] private GameObject moveButton;
		[SerializeField] private GameObject patrolButton;
		[SerializeField] private GameObject stopButton;

		private Dictionary<Type, GameObject> buttonByExecutorType;

		private void Start()
		{
			buttonByExecutorType = new Dictionary<Type, GameObject>();
			buttonByExecutorType.Add(typeof(CommandExecutorBase<IAttackCommand>), attacButton);
			buttonByExecutorType.Add(typeof(CommandExecutorBase<IProduceUnitCommand>), produceUnitButton);
			buttonByExecutorType.Add(typeof(CommandExecutorBase<IPatrolCommand>), patrolButton);
			buttonByExecutorType.Add(typeof(CommandExecutorBase<IStopCommand>), stopButton);
			buttonByExecutorType.Add(typeof(CommandExecutorBase<IMoveCommand>), moveButton);
		}

		public void MakeLayout(ICommandExecutor[] commandExecutors)
		{
			for (int i = 0; i < commandExecutors.Length; i++)
			{
				foreach (var keyValuePair in buttonByExecutorType)
				{
					if (keyValuePair.Key.IsAssignableFrom(commandExecutors[i].GetType()))
					{
						GameObject gameObject = keyValuePair.Value;
						gameObject.SetActive(true);
						Button button = gameObject.GetComponent<Button>();
						button.onClick.AddListener(() => OnClick?.Invoke(commandExecutors[i]));
						continue;
					}
				}

			}
		}

		public void Clear()
		{
			foreach (var keyValuePair in buttonByExecutorType)
			{
				keyValuePair.Value.GetComponent<Button>().onClick.RemoveAllListeners();
				keyValuePair.Value.SetActive(false);
			}
		}

	}
}

