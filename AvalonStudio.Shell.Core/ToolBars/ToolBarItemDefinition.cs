using System;
using Avalonia.Input;
using AvalonStudio.Shell.Core.Commands;

namespace AvalonStudio.Shell.Core.ToolBars
{
	public abstract class ToolBarItemDefinition
	{
		public ToolBarItemGroupDefinition Group { get; }

		public int SortOrder { get; }

		public ToolBarItemDisplay Display { get; }

		public abstract string Text { get; }
		public abstract Uri IconSource { get; }
		public abstract KeyGesture KeyGesture { get; }
		public abstract CommandDefinitionBase CommandDefinition { get; }

		protected ToolBarItemDefinition(ToolBarItemGroupDefinition group, int sortOrder, ToolBarItemDisplay display)
		{
			Group = group;
			SortOrder = sortOrder;
			Display = display;
		}
	}

	public enum ToolBarItemDisplay
	{
		IconOnly,
		IconAndText
	}
}