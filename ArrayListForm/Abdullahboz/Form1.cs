namespace Abdullahboz
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        /*Tek bir Form ekranýnda yapýlacak bir ödevdir. 25 elemanlý 1-100 arasýnda rastgele tamsayýlardan oluþan bir dizi tanýmlanmalýdýr.
        Soru1: Oluþturulan diziyi Listbox’ta yazdýrýn.Listbox içindeki eleman boyutunu Label’e yazdýrýn. (5 puan)
        Soru2: 50’den küçük sayýlarý Listbox’ta yazdýrýn.Listbox içindeki eleman boyutunu Label’e yazdýrýn. (5 puan)
        Soru3: Tüm sayýlarýn ortalamasýný Listbox’ta yazdýrýn. (10 puan)
        Soru4: Üretilen sayýlardan en büyüðü Listbox’ta yazdýrýn. (Özel Fonksiyon kullanýmý yasaktýr! Algoritmik çözüm ile yapýlmalýdýr.) (25 puan)
        Soru5: Dizi içindeki asal sayýlarý Listbox’ta yazdýrýn.Listbox içindeki eleman boyutunu Label’e yazdýrýn. (30 puan)*/

        
        Random rnd = new Random();
        int[] numbers = new int[25];
        // Rastgele dizemizi metotlarýn dýþýnda oluþturup her yerden ulaþýlabilir olmasýný saðladýk.
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }
            // for döngümüzü form uygulamamýzý çalýþtýrdýðýmýzda direk dizi oluþturmasý için burada kullandýk.
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                listBox1.Items.Add(numbers[i]);
            }
            // for döngümüzle dizimizin indexleri içerisinde dolaþarak
            // dizimizin içinde oluþan sayýlarý listbox'a ekledik.
            int numbersSize = listBox1.Items.Count;
            // sayý boyutunu tanýmlayýp 'Count' ile dizideki eleman sayýsýný numbersSize deðiþkenine atadýk.
            label1.Text = numbersSize.ToString();
            //NumbersSize' daki adet miktarýný label1'e yazdýrdýk.
            //NumbersSize int olduðu için onu string'e çevirdik.
            //Label1.Text string yapýdadýr.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // listbox'ýmýzý temizledik.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 50)
                    listBox1.Items.Add(numbers[i]);
            }
            //Sayýlar dizimizin içerisinde dolaþarak,
            //50'den küçük olan sayýlarý temizlediðimiz listbox'a ekledik.
            int numbersSize = listBox1.Items.Count;
            label1.Text = numbersSize.ToString();
            // sayý boyutunu tanýmlayýp 'Count' ile dizideki eleman sayýsýný numbersSize deðiþkenine atadýk.
            //NumbersSize' daki adet miktarýný label1'e yazdýrdýk.
            //NumbersSize int olduðu için onu string'e çevirdik.
            //Label1.Text string yapýdadýr.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //listbox'ýmýzý bir daha temizledik.
            int sum = 0;
            int avg;
            // toplam ve ortalamayý tutacak deðiþkenlerimizi tanýmladýk.
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            // dizimin içinde dolaþarak,
            // sum = sum + number[i] iþlemli atama yaptýk.
            avg = sum / numbers.Length;
            // ortalamamýzý bulduk. 
            // dizimin içindeki sayýlarý toplamýþtýk ve sum'a atamýþtýk.
            // toplanan sayýlarý, dizi içindeki sayý adetine böldük.
            listBox1.Items.Add(avg);
            // ortalamayý listbox'a ekledik.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max=0;
            // büyük sayý bulmak için 0 deðerli bir deðiþken oluþturduk.

            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                // max sayýyý bulmak için dizimizde dolaþýyoruz.
                // 0. index'teki sayýyý max'a atadýk.
                // 0. index'teki sayý diðer indextekilerden küçük olana kadar döngü devam eder.
                // büyük olan sayý bu sefer max deðiþkenine atanýr.
                // Dize boyutu bitene kadar döngü devam eder ve en son max'a atanan sayý dýþarý çýkar.
            

            }
            listBox1.Items.Clear();
            // En büyük sayýyý rahat görmek için listeyi temizledik.
            listBox1.Items.Add(max);
            // En son atanan sayýyý listeye ekledik.
            
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