using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Kaç tane tribonacci sayısı görmek istiyorsunuz?");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] dizi = new int[n];
    dizi[0] = 0;
    dizi[1] = 1;
    dizi[2] = 1;
    dizi[3] = 2;
    Console.Write("n-1 n-4 ile: ");
    for (int j = 4; j < n; j++) {
        dizi[j] = dizi[j-1] * 2 - dizi[j-4];
        Console.Write(dizi[j]+" ");
    }
  }
}
