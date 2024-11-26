using System;
using System.Globalization;
class HelloWorld {
  static void Main() {
    Console.Write("Bir Tarih Giriniz: ");
    string input = Console.ReadLine();
    DateTime tarih = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture);
    Console.WriteLine($"Girdiğiniz Tarih: {tarih.ToString("dd MM yyyy")}");
  }
}
