
bool isValidInput = false; // isValidInput false olduğu sürece döngüye girilir

while (!isValidInput)
{
    try
    {
        Console.WriteLine("Lütfen bir sayı giriniz");
        int input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("sayının karesi: " + input * input);

        isValidInput = true; // Eğer dönüşüm başarılı olursa, isValidInput true yapılır
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hatalı giriş yaptınız.Lütfen bir sayı giriniz"); // Eğer hata olursa, catch çalışır
    }
}
