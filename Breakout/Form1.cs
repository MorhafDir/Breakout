namespace Breakout;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        switch (keyData)
        {
            case Keys.Left:
                MoveLeft();
                return true;

            case Keys.Right:
                MoveRight(); 
                return true;

            default:
        return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    int PaddleSpeed = 50;

    private void MoveRight()
    {
        var oldLocation = paddle.Location;
        var maxX = Width - paddle.Width - 20;
        paddle.Location = new Point(Math.Min(oldLocation.X + PaddleSpeed,maxX), oldLocation.Y);
    }

    private void MoveLeft()
    {
        var oldLocation = paddle.Location;
        paddle.Location = new Point(Math.Max(oldLocation.X - PaddleSpeed, 0), oldLocation.Y);
    }
}