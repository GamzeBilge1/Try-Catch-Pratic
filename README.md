# README - Sayının Karesini Hesaplama Programı

Bu program, kullanıcının girdiği bir sayının karesini hesaplar. Hatalı giriş durumunda kullanıcıdan tekrar doğru bir sayı girmesi istenir. Program, doğru bir giriş yapılana kadar çalışmaya devam eder.

## Nasıl Çalışır?
1. Program, başlangıçta `isValidInput` adında bir `bool` değişkeni `false` olarak tanımlar.
2. `while` döngüsü, kullanıcı geçerli bir giriş yapana kadar devam eder.
3. Döngü içerisinde:
   - Kullanıcıdan bir sayı girmesi istenir.
   - Girilen değer bir tam sayıya (`int`) dönüştürülmeye çalışılır.
   - Eğer dönüşüm başarılı olursa:
     - Sayının karesi hesaplanır ve ekrana yazdırılır.
     - Döngü sonlandırılır.
   - Eğer dönüşüm başarısız olursa, hata yakalanır ve kullanıcıya hata mesajı gösterilir.


