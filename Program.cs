//Atama ve işlemli atama
Console.WriteLine("***Atama ve işlemli atama***");
int x=3;
int y=3;
y=y+2;
Console.WriteLine(y);
y+=2; //işlemli atama
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x=x*=2;
Console.WriteLine(x);

//Mantıksal operatörler

// ||(veya) , &&(ve)
Console.WriteLine("***Mantıksal operatörler***");
bool isSuccess=true;
bool isCompleted=false;

if(isSuccess && isCompleted)
    Console.WriteLine("Perfect");

if(isSuccess || isCompleted)
    Console.WriteLine("Great");

if(isSuccess && !isCompleted) //!değil
    Console.WriteLine("Good");

    //ilişkisel operatörler
    //<, >, <=, >=, ==, !=
Console.WriteLine("***ilişkisel operatörler***");

    int a = 3;
    int b = 4;
    bool sonuc = a<b;
    Console.WriteLine(sonuc);
    sonuc = a>b;
    Console.WriteLine(sonuc);
    sonuc = a >= b;
    Console.WriteLine(sonuc);
    sonuc = a<=b;
    Console.WriteLine(sonuc);
    sonuc = a==b;
    Console.WriteLine(sonuc);
    sonuc = a!=b;
    Console.WriteLine(sonuc);

Console.WriteLine("***Aritmatik operatörler***");

// /, * ,+ ,- % (mod almak-kalan)
//x++ ifadesinde x değişkeni önce işleme tabi tutulur ve daha sonra değeri bir artırılır. ++x ifadesinde ise önce değişkeninin değeri bir artırılır ve x yeni değeri kullanılarak işleme tabi tutulur

int sayı1 = 10;
int sayı2 = 5;
int toplama = sayı1+sayı2;
int cıkarma = sayı1-sayı2;
int carpma = sayı1*sayı2;
int bolme = sayı1/sayı2;
int deneme = ++sayı1;
float mod = sayı1%3;

Console.WriteLine("Toplama: " +toplama +" Çıkarma: " +cıkarma +" Çarpma: " +carpma +" Bölme: " +bolme +" Deneme: " +deneme +" Mod: " +mod);

int xx = 5;
Console.WriteLine(xx++); //önce yazdırdı sonra arttırdı
Console.WriteLine(x);//arttırılmış değeri yazdı
Console.WriteLine(++x);//önce arttırdı sonra yazdırdı