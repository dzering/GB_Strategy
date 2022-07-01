using UnityEngine;
using Abstracts;
using InputSystem;
using System.Collections;
using System;

namespace InputSystem
{
    public class CommandButtonsPresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue selectableValue;
        [SerializeField] private CommandButtonView view;

        private ISelectable currentSelectable;

        private void Start()
        {
            selectableValue.OnSelected += onSelected;
            onSelected(selectableValue.CurrentSelection);
            view.OnClick += onButtonCklick;
        }

        private void onSelected(ISelectable obj)
        {
            throw new System.NotImplementedException();
        }

        private void onButtonCklick(ICommandExecutor obj)
        {
            throw new NotImplementedException();
        }

    }

}


