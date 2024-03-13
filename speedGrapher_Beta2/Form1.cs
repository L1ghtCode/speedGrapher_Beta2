using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace speedGrapher_Beta2
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // свойство формы чтобы убрать ее мерцание
        }
        public Form1(bool a) // конструктор формы под кнопку изменить уровень(сразу в меню бех кнопки с названием)
        {
            InitializeComponent();
            foreach (Control control in this.Controls) // перебераем каждый элемент управления и делаем его видимым(изначалаьно стоит false)
            {
                control.Visible = true;
            }
            labelMain.Visible = false; // скрываем кнопку с названием
        }

        int speed = 1000;  // прописываем переменные которые передадим на 2 форму
        double vidSpeed = 1;
        int volume = 20;
        int lvl;
        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            switch (nudSpeed.Value)  // устанавливаем нужные параметры скорости
            {
                case 1: speed = 1200; vidSpeed = 0.8; break;
                case 2: speed = 1100; vidSpeed = 0.9; break;
                case 3: speed = 1000; vidSpeed = 1; break;
                default: speed = 1000; break;
            }
        }

        //public int getSpeed()
        //{
        //    return speed;
        //}
        //public double getVidSpeed()
        //{
        //    return vidSpeed;
        //}
        //public bool isAutoSpace()
        //{
        //    return autoSpace.Checked;
        //}

        private void l1_Click(object sender, EventArgs e)
        {
            lvl = 0;  // устанавливаем нужный уровень
            goToForm2();
        }
        private void l2_Click(object sender, EventArgs e)
        {
            lvl = 1;
            goToForm2();
        }

        private void l3_Click(object sender, EventArgs e)
        {
            lvl = 2;
            goToForm2();
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Yellow;
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }

        public void goToForm2() // пропишем отдельный метод для сокращения кода
        {
            this.Visible = false;  // скрываем эту форму, так как при ее закрытии программа закроется
            form2 = new Form2(lvl, speed, vidSpeed, autoSpace.Checked, (int)nudLive.Value, volume);  // выгружаем нужные данные
            form2.Show();  // открываем форму с игрой
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                Добро пожаловть в игру SpeedGrapher\n\nВ этой игре вам предстоит поспевать за текстом, сейчас вы находитесь в главном меню, где можете настроить нужные вам параметры. После настройки выберете один из уровней и можете начинать. Жизнь отнимается за каждый промах. Очки начисляются за любое нажатие(верное или ошибочное), однако комбо растет только при верных нажатиях и сбрасывается при ошибочных.\nУдачи и HF");
        }

        private void nudVolume_ValueChanged(object sender, EventArgs e)
        {
            volume = (int)nudVolume.Value;
        }

        private void autoSpace_MouseEnter(object sender, EventArgs e)
        {
            (sender as CheckBox).ForeColor = Color.Yellow;
        }

        private void autoSpace_MouseLeave(object sender, EventArgs e)
        {
            (sender as CheckBox).ForeColor = Color.White;
        }

        private const string SoundHello = "hello.wav";

        private void labelMain_Click(object sender, EventArgs e)
        {
            
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
            Thread.Sleep(1000);
            labelMain.Visible = false;
            string addPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (addPath == null) return;
            var path = System.IO.Path.Combine(addPath, SoundHello);
            SoundPlayer sp1 = new SoundPlayer(path);
            sp1.Play();
        }

        private void lExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 180); // устанавливаем начальное положение формы
        }
    }
}
