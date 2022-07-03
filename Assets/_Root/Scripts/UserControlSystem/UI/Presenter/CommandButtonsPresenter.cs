using UnityEngine;
using Abstracts;
using System.Collections.Generic;
using System;

namespace InputSystem
{
    public class CommandButtonsPresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue selectableValue;
        [SerializeField] private CommandButtonView view;
        [SerializeField] private AssetContext context;

        private ISelectable currentSelectable;

        private void Start()
        {
            selectableValue.OnSelected += onSelected;
            onSelected(selectableValue.CurrentSelection);
            view.OnClick += onButtonClick;
        }

        private void onSelected(ISelectable selectable)
        {
            if (currentSelectable == selectable)
                return;

            currentSelectable = selectable;
            view.Clear();

            if (selectable != null)
            {
                List<ICommandExecutor> commandExecutors = new List<ICommandExecutor>();
                commandExecutors.AddRange((selectable as Component).GetComponentsInParent<ICommandExecutor>());
                view.MakeLayout(commandExecutors);
            }
        }

        private void onButtonClick(ICommandExecutor commandExecutor)
        {
            CommandExecutorBase<IProduceUnitCommand> produceUnit = commandExecutor as CommandExecutorBase<IProduceUnitCommand>;
            if (produceUnit != null)
            {
                produceUnit.ExecuteSpecificCommand(context.Inject(new ProduceUnitCommand()));
                return;

            }
            throw new ApplicationException($"{nameof(CommandButtonsPresenter)}.{nameof(onButtonClick)}:" +
                $" Unknown type of commands executor: {commandExecutor.GetType().FullName}!");

        }

    }

}


