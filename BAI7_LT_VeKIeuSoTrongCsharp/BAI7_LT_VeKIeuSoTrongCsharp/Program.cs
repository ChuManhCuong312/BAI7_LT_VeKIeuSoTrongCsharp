using System;

namespace BT7_LT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("a. Tính tổng 2 số nguyên không dấu" +
                    "\nb. Tính diện tích và chu vi HCN (2byte)" +
                    "\nc. Kiểm tra tính chẵn lẻ (4byte)" +
                    "\nd. Tính tổng 2 số nguyên có dấu (1byte)" +
                    "\ne. Tính tổng dãy số từ 1 đến n (4byte)" +
                    "\ng. Tính diện tích và chu vi hình chữ nhật (8byte)" +
                    "\nh. Tìm số lớn nhất trong 3 số" +
                    "\nk. Tính giai thừa số nguyên không âm n" +
                    "\nl. Kiểm tra số nguyên tố của số nguyên n" +
                    "\nm. Kiểm tra số hoàn hảo" +
                    "\nq. Thoát");
                Console.Write("Chọn bài tập (a-m hoặc q để thoát): ");
                char choice = Convert.ToChar(Console.ReadLine().ToLower());
                Console.WriteLine("---------------------------------------------");

                switch (choice)
                {
                    case 'a':
                        // Tính tổng 2 số nguyên không dấu
                        SumUnsignedIntegers();
                        break;

                    case 'b':
                        // Tính diện tích và chu vi HCN (2byte)
                        CalculateRectangle();
                        break;

                    case 'c':
                        // Kiểm tra tính chẵn lẻ (4byte)
                        CheckEvenOrOdd();
                        break;

                    case 'd':
                        // Tính tổng 2 số nguyên có dấu (1byte)
                        SumSignedIntegers();
                        break;

                    case 'e':
                        // Tính tổng dãy số từ 1 đến n (4byte)
                        SumFrom1ToN();
                        break;

                    case 'g':
                        // Tính diện tích và chu vi hình chữ nhật (8byte)
                        CalculateRectangleDouble();
                        break;

                    case 'h':
                        // Tìm số lớn nhất trong 3 số
                        FindLargestNumber();
                        break;

                    case 'k':
                        // Tính giai thừa số nguyên không âm n
                        CalculateFactorial();
                        break;

                    case 'l':
                        // Kiểm tra số nguyên tố của số nguyên n
                        CheckPrimeNumber();
                        break;

                    case 'm':
                        // Kiểm tra số hoàn hảo
                        CheckPerfectNumber();
                        break;

                    case 'q':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // a. Tính tổng 2 số nguyên không dấu
        static void SumUnsignedIntegers()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên không dấu thứ nhất: ");
                    uint num1 = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Nhập số nguyên không dấu thứ hai: ");
                    uint num2 = Convert.ToUInt32(Console.ReadLine());
                    uint sum = num1 + num2;
                    Console.WriteLine($"Tổng của {num1} và {num2} là {sum}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // b. Tính diện tích và chu vi HCN (2byte)
        static void CalculateRectangle()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập chiều dài hình chữ nhật: ");
                    ushort length = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Nhập chiều rộng hình chữ nhật: ");
                    ushort width = Convert.ToUInt16(Console.ReadLine());
                    uint area = (uint)length * width;
                    uint perimeter = 2 * ((uint)length + width);
                    Console.WriteLine($"Diện tích hình chữ nhật: {area}");
                    Console.WriteLine($"Chu vi hình chữ nhật: {perimeter}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // c. Kiểm tra tính chẵn lẻ (4byte)
        static void CheckEvenOrOdd()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên không dấu: ");
                    uint num = Convert.ToUInt32(Console.ReadLine());
                    if (num % 2 == 0)
                        Console.WriteLine("Số chẵn.");
                    else
                        Console.WriteLine("Số lẻ.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // d. Tính tổng 2 số nguyên có dấu (1byte)
        static void SumSignedIntegers()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên có dấu thứ nhất: ");
                    sbyte num1 = Convert.ToSByte(Console.ReadLine());
                    Console.Write("Nhập số nguyên có dấu thứ hai: ");
                    sbyte num2 = Convert.ToSByte(Console.ReadLine());
                    sbyte sum = (sbyte)(num1 + num2);
                    Console.WriteLine($"Tổng của {num1} và {num2} là {sum}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // e. Tính tổng dãy số từ 1 đến n (4byte)
        static void SumFrom1ToN()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên không dấu n: ");
                    uint n = Convert.ToUInt32(Console.ReadLine());
                    ulong sum = 0;
                    for (uint i = 1; i <= n; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Tổng các số từ 1 đến {n} là {sum}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // g. Tính diện tích và chu vi hình chữ nhật (8byte)
        static void CalculateRectangleDouble()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập chiều dài hình chữ nhật: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhập chiều rộng hình chữ nhật: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double area = length * width;
                    double perimeter = 2 * (length + width);
                    Console.WriteLine($"Diện tích hình chữ nhật: {area}");
                    Console.WriteLine($"Chu vi hình chữ nhật: {perimeter}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // h. Tìm số lớn nhất trong 3 số
        static void FindLargestNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số thứ nhất: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhập số thứ hai: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhập số thứ ba: ");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    int max = Math.Max(num1, Math.Max(num2, num3));
                    Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // k. Tính giai thừa số nguyên không âm n
        static void CalculateFactorial()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên không âm n: ");
                    uint n = Convert.ToUInt32(Console.ReadLine());
                    ulong factorial = 1;
                    for (uint i = 1; i <= n; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Giai thừa của {n} là {factorial}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // l. Kiểm tra số nguyên tố của số nguyên n
        static void CheckPrimeNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên không âm n: ");
                    uint n = Convert.ToUInt32(Console.ReadLine());
                    if (n < 2)
                    {
                        Console.WriteLine($"{n} không phải là số nguyên tố.");
                        return;
                    }
                    bool isPrime = true;
                    for (uint i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                        Console.WriteLine($"{n} là số nguyên tố.");
                    else
                        Console.WriteLine($"{n} không phải là số nguyên tố.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }

        // m. Kiểm tra số hoàn hảo
        static void CheckPerfectNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num <= 0)
                    {
                        Console.WriteLine($"{num} không phải là số hoàn hảo.");
                        return;
                    }
                    int sum = 0;
                    for (int i = 1; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            sum += i;
                        }
                    }
                    if (sum == num)
                        Console.WriteLine($"{num} là số hoàn hảo.");
                    else
                        Console.WriteLine($"{num} không phải là số hoàn hảo.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}. Vui lòng thử lại.");
                }
            }
        }
    }
}
