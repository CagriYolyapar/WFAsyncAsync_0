namespace WFAsyncAsync_0
{
    public partial class Form1 : Form
    {

        //Delegate : Delegate birden fazla metodu veya bir metodu kapsülleyen ve tetiklemenizi saglayan bir yapıdır...

        //Action Delegate : Bir tipte parametre alır (veya almaz) geriye bir deger döndürmez


        delegate void TestDelegate();


        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSim_Click(object sender, EventArgs e)
        {
            #region DelegateNotlari
            //TestDelegate testDelegate = new TestDelegate(Selamla); //BUrada dikkat edin : Selamla isimli metodu cagırmıyoruz. O yüzden parantezlerini vermiyoruz... Metodu bir yapı olarak Delegate'e veriyoruz.

            //testDelegate += Sor; //Eger olusturulan bir Delegate'e baska bir metot daha eklemek isterseniz += operatorunu kullanırsınız...

            //testDelegate.Invoke();

            //Action myAction = new Action(Selamla);
            //myAction += Sor;
            //myAction.Invoke();

            //Action<int> action2 = new Action<int>(KareAl); //Dikkat ederseniz burada Action'inimiz generic'ine int alarak olusturulmustur. Yani int parametre alan metotları destekleyecektir (ve tabii ki Action oldugu icin geriye deger döndürmeyen metotları kabul edecektir)
            //action2.Invoke(3);


            //Action action = new Action(() =>
            //    {
            //        MessageBox.Show("Hello World");
            //    });

            //action += Sor;

            //Action<int> action2 = new Action<int>(x =>
            //{

            //    Text = (x * x).ToString();
            //});

            //action2.Invoke(2); 
            #endregion

            await SelamlaAsync();
            MessageBox.Show("Test");

        }


        public void Selamla()
        {
            Thread.Sleep(10000);
            MessageBox.Show("Hello World");
        }

        public void Sor()
        {

            MessageBox.Show("Ne haber");
        }

        void KareAl(int sayi)
        {
            Text = (sayi * sayi).ToString();
        }


        //Bir metodun asenkron calısabilmesini istiyorsanız o metot geriye deger döndürse de döndürmese de önce Task tipi ile yaratılmalıdır... Task tipi yaratıldıktan sonra metot eger geriye döndürmeyecekse Task'e baska bir sey yazılmaz...Eger geriye deger döndürecekse o deger tipi Task'e generic olarak verilir...

        // Task SelamlaAsync()
        //{
        //    return Task.Run(
        //          () =>
        //          {
        //              Thread.Sleep(20000);
        //              MessageBox.Show("Async olarak cagrılmıstım görevim simdi bitti ama kimseyi engellemedim");
        //          });
        //}


        async Task SelamlaAsync()
        {
            await Task.Run(() =>
            {

                Thread.Sleep(10000);
                //Denetimlere erişime ulasmadan önce o erişimi ana iş parcacgına tasımanız lazım...
                this.Invoke(() =>
                {

                    Text = "Async olarak cagrıldım";
                });

            });
        }



    }
}