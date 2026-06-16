using Godot;

public partial class Player : Sprite2D
{
	private const float Speed = 100.0f;
	public override void _Process(double delta)
	{
		Vector2 direction = Vector2.Zero;

		if (Input.IsActionPressed("ui_right"))
			direction.X += 1;
		if (Input.IsActionPressed("ui_left"))
			direction.X -= 1;
		if (Input.IsActionPressed("ui_down"))
			direction.Y += 1;
		if (Input.IsActionPressed("ui_up"))
			direction.Y -= 1;

		if (direction != Vector2.Zero)
		{
			direction = direction.Normalized();
			Position += direction * Speed * (float)delta;
		}
	}
}
