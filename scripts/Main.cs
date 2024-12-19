using Godot;
using System;

public partial class Main : Control
{

	[Export]
	private PackedScene _add_product,_highlight_product;

	[Export]
	private NodePath _Card_Container;
	
	/// <summary>
	/// Termék hozzáadása ablak megnyitása
	/// </summary>
	private void _On_Add_Product_Pressed()
	{
		if (!LoginManager.IsLoggedIn())
		{
			return;
		}

		var add_product =  _add_product.Instantiate();
		AddChild(add_product);
	}

	private void _On_Highlight_Pressed()
	{
		var higlight = _highlight_product.Instantiate();
		AddChild(higlight);
	}

	private void _On_Top_Product_Pressed()
	{
		var pc = GetNode<ProductContainer>(_Card_Container);
		pc.sorted = true;
		pc.Update();
	}
}
