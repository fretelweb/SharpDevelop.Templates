﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

using ${StandardNamespace}.ViewModels.Interfaces;

namespace ${StandardNamespace}.Views
{

	public partial class ${FileNameWithoutExtension}View
	{

		public ${FileNameWithoutExtension}View(I${FileNameWithoutExtension}ViewModel viewModel)
		{
			InitializeComponent();
			viewModel.View = this;
		}

	}

}