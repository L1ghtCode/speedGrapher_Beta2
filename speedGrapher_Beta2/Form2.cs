using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Reflection.Emit;

namespace speedGrapher_Beta2
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        int level;
        public string[] level1;
        private string VideoName;
        int[] timming;
        int curr = 0;
        int str = 0;
        int score = 0;
        int combo = 1;
        int maxcombo = 0;
        int startLive;
        int live;
        int volume = 1;
        bool autoSpace;
        bool isPlaying = false;
        public Form2(int lvl, int spd, double vspd, bool spc, int live, int volume)  // с помощью конструктора вытаскиваем данные из 1 формы
        {
            InitializeComponent();
            this.DoubleBuffered = true; // свойство формы чтобы убрать ее мерцание
            // забираем нужные данные из первой формы
            labelSong.Visible = false;
            timer1.Interval = spd;
            axWindowsMediaPlayer1.settings.rate = vspd;
            this.volume = volume; // сохраняем чтобы подключить после включения видео
            level = lvl;
            autoSpace = spc;
            level1 = createSong();  // при старте создаем нужную песню
            startLive = live;
            this.live = live;
            this.labelLive.Text = "x" + live;
            //timer1.Interval = 100; //for tests
            //MessageBox.Show(Convert.ToString(spd)); проверка передачи данных из 1 формы
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 180); // устанавливаем начальное положение формы
            labelSong.Text = level1[0];  // устанавливаем начальный текст
            axWindowsMediaPlayer1.uiMode = "None";  // настраиваем видеоплеер
            axWindowsMediaPlayer1.settings.volume = 1;
            pictureBox1.Visible = false;
            labelLive.Visible = false;
        }

        void nextStr()  // метод перехода на новую строчку в тексте
        {
            textBox1.Text = "";  // очищаем текстбокс
            curr = 0;  // обнуляем позицию
            str++;  // прибавляем строчку
            if (str == level1.GetLength(0)) { str = 0; };  // чтобы не выйти за границу массива
            labelSong.Text = level1[str];
        }
        string[] createSong()  // генерация уровня(тайминг и текст)
        {
            string cuplet1;
            string cuplet2;
            string cuplet3;
            string pripev;
            string text;
            if (level == 0)
            {
                int[] timmingLvl0 = {
                    6,10,15,23,34,38,43,48,57,
                    63,67,72,81,86,91,97,106,
                    130,134,139,144,150,154,158,163,171,173,178,
                    183,187,197
                };
                timming = timmingLvl0;
                VideoName = "level0v.mp4";
                cuplet1 = "Мы шли по старым улицам вдвоём\r\nНе замечая линии дорожные\r\nСлова сплетались, мысли об одном\r\nМы будто разгадали что-то сложное\r c тобой\r\nБросали взгляды на ряды домов\r\nИх окна занавешенные сонные\r\nИ в каждом было что-нибудь своё\r\nЛишь рамы одинаковы оконные\r и всё\n";
                cuplet2 = "Дышали лёгким смогом прошлых дней\r\nВдыхали едкий дым ночной свободы\r\nИ точно знали, улицам видней\r\nА мы простые мимо-пешеходы\r\nКричали эти строки в небеса\r\nИ ждали, что нам кто-нибудь ответит\r\nДержали наши руки у лица\r\nА улица казалась целым светом нам\r тогда\n";
                pripev = "Мы вышли поговорить и понеслось\r\nСпустя часы мы на другом краю города\r\nИ я не знаю отчего светло\r\nОт солнца или это разговоры всё\r с тобой\n";
                text = pripev + "...\n" + cuplet1 + pripev + "...\n" + cuplet2 + "...\n" + pripev;
            }

            else if(level == 1){
                int[] timmingLvl1 = {
                    24, 31, 37, 43, 50, 56, 62,
                    68, 75, 82, 88, 94, 101, 107, 114
                };
                timming = timmingLvl1;
                VideoName = "level1.mp4";
                cuplet1 = "Мой мир огромен, а я так скромен\r\nВся жизнь — спектакль, я в ней актёр\r\nАктёр-лицедей, добряк и злодей\r\nНе ради людей, а ради искусства\n";
                cuplet3 = "По жизни играю, я все секреты ваши знаю\r\nВы в зале сидите и ваши нервы, словно нити\r\nНадёжно пришиты к пальцам моим\n";
                cuplet2 = "Вас обманули, в грязь окунули\r\nОб этом вскоре узнают все\r\nПридворный актёр — умён и хитёр\r\nЯ тут с давних пор, насквозь я вас вижу\n";
                //cuplet3 = "Я роль — вы сюжет, прольём миру свет\r\nКто прав, а кто нет — пусть судят други\n"
                pripev = "Угрозы, насмешки, короны примеряют пешки\r\nНа лицах отметки, что все они марионетки\r\nЭй, куклы, бегите, ешьте меня, вот он я\n";
                text = "...\n" + cuplet1 + cuplet3 + cuplet2 + pripev;
            }
            else
            {
                int[] timmingLvl1 = {
                    4, 11, 16, 18, 22, 24, 27, 30, 33,
                    36, 39, 43, 46, 51, 54, 57, 59, 63,
                    69, 74, 77, 83, 86, 88, 92, 94, 97//, 101,
                };
                timming = timmingLvl1;
                VideoName = "level2.mp4";
                cuplet1 = "My heart broke, it's been a while since we spoke\r\nI lost hope, now I'm feeling like a joke\r\nYou're not there\r\nWho the hell said life was fair?\r\nYou're not there\r\nThis is more than I can bear\n";
                cuplet2 = "I walk through the darkest alleyway\r\nBury my body in a shallow grave\r\nI can't help but feel out of place\n";
                cuplet3 = "My life sucks, since I lost you, life's been rough\r\nThat door shut, like I lost a million bucks\r\nYou're not there\r\nYou're not there\n";
                pripev = "You're not there\r\nWho the hell said life was fair?\r\nYou're not there\r\nThis is more than I can bear\n";
                text = "...\n" + cuplet1 + pripev + cuplet2 + pripev + cuplet3 + "...\n" + pripev;
            }
            text = text.Replace("\r", "");
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            //text = text.Replace("-", "");
            return text.Split('\n');
        }

        //if (level1[str][curr] == char.ToLower((char)e.KeyValue)) автобольшаябувка
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  // событие отвечающее за механику игры
        {
            {
                if (textBox1.Text == level1[str]) { return; } // если уже написали строчку на учитываем случайные нажатия
                if (level1[str][curr] == ' ')
                { 
                    if (autoSpace) // проверка на автопробел
                    { 
                        textBox1.Text += level1[str][curr]; 
                        curr++; 
                    }
                }  
                if (level1[str][curr] == e.KeyChar)  // если верная то +комбо и +текст
                {
                    textBox1.Text += level1[str][curr];
                    score += combo;
                    combo++;
                    //switch(combo)
                    //{
                    //    case 11: labelCombo.ForeColor = Color.Yellow; break;
                    //    case 21: labelCombo.ForeColor = Color.Orange; break;
                    //    case 31: labelCombo.ForeColor = Color.Red; break;
                    //    default: labelCombo.ForeColor = Color.White; break;
                    //}
                    if (combo > 10) labelCombo.ForeColor = Color.Yellow;
                    if (combo > 20) labelCombo.ForeColor = Color.Orange;
                    if (combo > 30) labelCombo.ForeColor = Color.Red;
                    if (combo > maxcombo) maxcombo = combo;
                    labelScore.Text = "Очки: " + score;
                    labelCombo.Text = "Комбо: " + combo;
                }
                else  // если не верная то обнуляем комбо и +текст
                {
                    live--;
                    if(live < 10){ labelLive.ForeColor = Color.Orange; }
                    if(live < 5) { labelLive.ForeColor = Color.Red; }
                    if (live <= 0) { isPlaying = false; MessageBox.Show("Ваши жизни кончились :(\n Попробуйте еще раз. Уровень начнется через 3 секунды после закрытия этого окна"); Restart(); Thread.Sleep(3000); isPlaying = true; }
                    this.labelLive.Text = "x" + live;
                    textBox1.Text += level1[str][curr];
                    combo = 1;
                    labelCombo.ForeColor = Color.White;
                    score++;
                    labelScore.Text = "Очки: " + score;
                    labelCombo.Text = "Комбо: " + combo;
                }
                curr++;
            }
        }

        DateTime time = new DateTime(0, 0);  // время
        int t = 0;  // тайминг
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                t++;  // инкремент перемнной отвечающий за тайминги
                if (timming[str] == t) nextStr();  // если тайминг следующей строчки то переходим на некст строку
                if (str == timming.GetLength(0))
                {
                    timer1.Stop();
                    double totalScore = ((20.0 / startLive) * score);
                    MessageBox.Show("Поздравляем с прохождением уровня, вы набрали: " + Convert.ToString(Math.Round(totalScore)) + ", максимальное комбо: " + maxcombo);
                }  // при завершении уровня оповещаем игрока
                time = time.AddSeconds(1);  // добавляем секунду к таймеру
                this.labelTime.Text = "Время: " + time.ToString("mm:ss"); // записываем ее в таймер
            }
        }

        //private void nudSpeed_ValueChanged(object sender, EventArgs e)
        //{
        //    switch (nudSpeed.Value)
        //    {
        //        case 1: timer1.Interval = 1200; axWindowsMediaPlayer1.settings.rate = 0.8; break;
        //        case 2: timer1.Interval = 1100; axWindowsMediaPlayer1.settings.rate = 0.9; break;
        //        case 3: timer1.Interval = 1000; axWindowsMediaPlayer1.settings.rate = 1; break;
        //        default: timer1.Interval = 1000; break;
        //    }
        //    if (nudSpeed.Value == 3) { timer1.Interval = 1000; }
        //}

        //private string SoundName = "level1.mp3"; музыкальный файл
        private void labelStart_Click(object sender, EventArgs e)
        {
            isPlaying = true;
            this.KeyPreview = true;
            Thread.Sleep(1500);
            //метод получения адресса исполняемой программы, чтобы не указывать весь путь вручную до
            //музыкального файла, чтобы работало у всех
            string addPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (addPath == null) return;
            //var path = System.IO.Path.Combine(addPath, SoundName); // указываем путь к аудио
            var path2 = System.IO.Path.Combine(addPath, VideoName); // указываем путь к видео
            //запуск музыки
            //WindowsMediaPlayer player = new WindowsMediaPlayer();
            //player.URL = path;
            //player.settings.volume = 1;
            //player.controls.play();
            this.Text = "Играем...";
            timer1.Start(); // запускаем таймер
            labelStart.Enabled = false; // делаем кнопку старта более неактивной
            labelStart.Visible = false; // скрываем кнопку старта из вида
            labelSong.Visible = true;  // открываем лейбл с текстом песни
            pictureBox1.Visible = true; // открываем жизни
            labelLive.Visible = true;
            axWindowsMediaPlayer1.URL = path2;  // подключаем видео
            axWindowsMediaPlayer1.settings.volume = volume; // подключаем тут для текущего видео
        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void Restart()
        {
            timer1.Stop();  // стопаем таймер
            this.labelTime.Text = "Время: 0";  // обнуляем параметры
            this.labelCombo.Text = "Комбо: 0";
            this.labelScore.Text = "Очки: 0";
            live = startLive;
            this.labelLive.Text = "x" + live;
            this.textBox1.Text = "";
            this.labelLive.ForeColor = Color.Green;
            curr = 0;
            score = 0;
            combo = 1;
            str = 0;
            this.labelSong.Text = level1[str];
            t = 0;
            time = new DateTime(0, 0);
            axWindowsMediaPlayer1.close();
            string addPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (addPath == null) return;
            var path2 = System.IO.Path.Combine(addPath, VideoName);
            axWindowsMediaPlayer1.URL = path2;
            timer1.Start();  // запусакаем таймер
        }
        private void labelExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();  // явно прописываем этот метод чтобы небыло неявного обращения
        }

        private void labelChangeLvl_Click(object sender, EventArgs e)
        {
            this.Close();  // закрываем форму с плеером
            Form1 form1 = new Form1(true);
            form1.Show(); // открывакм стартовую форму
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            (sender as System.Windows.Forms.Label).ForeColor = Color.Yellow;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            (sender as System.Windows.Forms.Label).ForeColor = Color.White;
        }
    }
}
