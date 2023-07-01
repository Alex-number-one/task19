//На вход подаётся одно целое число - количество бит. Переведите данное количество информации в килобайты. Результат округлите до сотых.
// 1 kb = 8000 bit
Console.WriteLine("Введите целое количество бит");
int bit = Convert.ToInt32(Console.ReadLine());
int kb = bit / 8000;
Console.WriteLine($" {bit} bit = {kb} kb ");