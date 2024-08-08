namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0, left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 55;
                    buttons[i, j].Height = 55;
                    // sola yazdırma izşlemini yaptık
                    buttons[i, j].Left = left;
                    left += 55; // Boyutu kadar arttırıyorum ki yan yana dizilip sütun oluştursun
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                //left = 0; // döngü bir kez çalışınca dursun diye topın altına yazmalıyım ki alt satıra yazabilsin 
                top += 55; // boyunu tanımlıyorumki  satır oluşsun
                left = 0; // döngü bir kez çalışınca dursun diye
            }

        }
    }
}
