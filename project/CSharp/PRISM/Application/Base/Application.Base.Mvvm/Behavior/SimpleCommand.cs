﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ${SolutionName}.Base.Mvvm.Behavior
{

	public class SimpleCommand : ICommand

	{
		public Predicate<object> CanExecuteDelegate { get; set; }
		public Action<object> ExecuteDelegate { get; set; }


		public bool CanExecute(object parameter)
		{
			if (CanExecuteDelegate != null)
				return CanExecuteDelegate(parameter);
			return true;
		}


		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}


		public void Execute(object parameter)
		{
			if (ExecuteDelegate != null)
				ExecuteDelegate(parameter);
		}

	}

}
