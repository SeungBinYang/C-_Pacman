namespace pacMan
{
    public partial class Form1 : Form
    {
        private int pacmanX = 50;
        private int pacmanY = 50;
        private int step = 5;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnKeyDown);
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    pacmanY -= step;
                    break;
                case Keys.Down:
                    pacmanY += step;
                    break;
                case Keys.Left:
                    pacmanX -= step;
                    break;
                case Keys.Right:
                    pacmanX += step;
                    break;
            }
            this.Invalidate(); // 폼을 다시 그립니다.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillEllipse(Brushes.Yellow, pacmanX, pacmanY, 20, 20); // 팩맨을 그립니다.
        }
    }
}