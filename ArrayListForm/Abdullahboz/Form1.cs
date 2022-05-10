namespace Abdullahboz
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        /*Tek bir Form ekran�nda yap�lacak bir �devdir. 25 elemanl� 1-100 aras�nda rastgele tamsay�lardan olu�an bir dizi tan�mlanmal�d�r.
        Soru1: Olu�turulan diziyi Listbox�ta yazd�r�n.Listbox i�indeki eleman boyutunu Label�e yazd�r�n. (5 puan)
        Soru2: 50�den k���k say�lar� Listbox�ta yazd�r�n.Listbox i�indeki eleman boyutunu Label�e yazd�r�n. (5 puan)
        Soru3: T�m say�lar�n ortalamas�n� Listbox�ta yazd�r�n. (10 puan)
        Soru4: �retilen say�lardan en b�y��� Listbox�ta yazd�r�n. (�zel Fonksiyon kullan�m� yasakt�r! Algoritmik ��z�m ile yap�lmal�d�r.) (25 puan)
        Soru5: Dizi i�indeki asal say�lar� Listbox�ta yazd�r�n.Listbox i�indeki eleman boyutunu Label�e yazd�r�n. (30 puan)*/

        
        Random rnd = new Random();
        int[] numbers = new int[25];
        // Rastgele dizemizi metotlar�n d���nda olu�turup her yerden ula��labilir olmas�n� sa�lad�k.
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }
            // for d�ng�m�z� form uygulamam�z� �al��t�rd���m�zda direk dizi olu�turmas� i�in burada kulland�k.
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                listBox1.Items.Add(numbers[i]);
            }
            // for d�ng�m�zle dizimizin indexleri i�erisinde dola�arak
            // dizimizin i�inde olu�an say�lar� listbox'a ekledik.
            int numbersSize = listBox1.Items.Count;
            // say� boyutunu tan�mlay�p 'Count' ile dizideki eleman say�s�n� numbersSize de�i�kenine atad�k.
            label1.Text = numbersSize.ToString();
            //NumbersSize' daki adet miktar�n� label1'e yazd�rd�k.
            //NumbersSize int oldu�u i�in onu string'e �evirdik.
            //Label1.Text string yap�dad�r.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // listbox'�m�z� temizledik.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 50)
                    listBox1.Items.Add(numbers[i]);
            }
            //Say�lar dizimizin i�erisinde dola�arak,
            //50'den k���k olan say�lar� temizledi�imiz listbox'a ekledik.
            int numbersSize = listBox1.Items.Count;
            label1.Text = numbersSize.ToString();
            // say� boyutunu tan�mlay�p 'Count' ile dizideki eleman say�s�n� numbersSize de�i�kenine atad�k.
            //NumbersSize' daki adet miktar�n� label1'e yazd�rd�k.
            //NumbersSize int oldu�u i�in onu string'e �evirdik.
            //Label1.Text string yap�dad�r.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //listbox'�m�z� bir daha temizledik.
            int sum = 0;
            int avg;
            // toplam ve ortalamay� tutacak de�i�kenlerimizi tan�mlad�k.
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            // dizimin i�inde dola�arak,
            // sum = sum + number[i] i�lemli atama yapt�k.
            avg = sum / numbers.Length;
            // ortalamam�z� bulduk. 
            // dizimin i�indeki say�lar� toplam��t�k ve sum'a atam��t�k.
            // toplanan say�lar�, dizi i�indeki say� adetine b�ld�k.
            listBox1.Items.Add(avg);
            // ortalamay� listbox'a ekledik.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max=0;
            // b�y�k say� bulmak i�in 0 de�erli bir de�i�ken olu�turduk.

            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                // max say�y� bulmak i�in dizimizde dola��yoruz.
                // 0. index'teki say�y� max'a atad�k.
                // 0. index'teki say� di�er indextekilerden k���k olana kadar d�ng� devam eder.
                // b�y�k olan say� bu sefer max de�i�kenine atan�r.
                // Dize boyutu bitene kadar d�ng� devam eder ve en son max'a atanan say� d��ar� ��kar.
            

            }
            listBox1.Items.Clear();
            // En b�y�k say�y� rahat g�rmek i�in listeyi temizledik.
            listBox1.Items.Add(max);
            // En son atanan say�y� listeye ekledik.
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Listeyi temizliyoruz.
            
            for (int i = 1; i < numbers.Length; i++)    
            {   
                int counter = 0;
                for (int j = 1; j <= numbers[i]; j++)
                { 
                  
                    if ((numbers[i] % j) == 0)
                    {
                        counter++;
                    }
                    
                }
                if (counter == 2)
                    listBox1.Items.Add(numbers[i].ToString());
                
            }
            
            

            int numbersSize = listBox1.Items.Count;
            label1.Text = numbersSize.ToString();
        }
    }
}