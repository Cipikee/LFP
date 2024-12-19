using Godot;
using System;

public partial class ProductHighlight : Window
{
	private void OnCloseRequested()
	{
		this.Hide();
		GetParent().RemoveChild(this);
	}
}
