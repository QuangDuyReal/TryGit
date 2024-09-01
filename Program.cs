using System;
using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    struct Timkiemnhiphan
    {
        public List<int> Bs;
        public Timkiemnhiphan(List<int> bs)
        {
            Bs = bs;
        }
    }

    static void binarySearch(int[] arr, int key)            // ham tim kiem nhi phan
    {
        int l = 0;
        int r = arr.Length - 1;
        int mid = (l + r) / 2;
        int cnt = 0;                                        // dem so lan chia doi mang
        Timkiemnhiphan mang = binaArr(arr, l, r);
        while (l <= r)
        {
            if (key < arr[mid]) r = mid - 1;
            else if (key > arr[mid]) l = mid + 1;
            else
            {
                Console.WriteLine($"So lan chia doi day la {cnt}");
                Console.Write($"Vi tri cua gia tri {key} can tim la: ");
                Console.WriteLine(mid);
                return;
            }
            mang = binaArr(arr, l, r);
            Console.WriteLine($"Mang sau khi chia doi lan thu {cnt + 1} la: {string.Join(" ", mang.Bs)}");
            cnt++;
            mid = (l + r) / 2;
        }
        Console.WriteLine("Khong tim thay");
    }

    static Timkiemnhiphan binaArr(int[] arr, int l, int r)  // ham in ra mang sau khi chia doi
    {
        List<int> bs = new List<int>();
        for(int i = l; i <= r; i++)
        {
            bs.Add(arr[i]);
        }
        return new Timkiemnhiphan(bs);
    }
    static void Main(string[] args)                         // ham main
    {
        Console.WriteLine("Nhap so phan tu cua mang:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        Console.WriteLine("Nhap gia tri can tim");
        int key = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1} cua mang:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        binarySearch(arr, key);
    }
}