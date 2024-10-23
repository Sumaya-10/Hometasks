using System.Linq.Expressions;

namespace Indexertask;

class ListInt
{
    private int[] array;
    private int count;
    public ListInt()
    {
        array = new int[0];
        count = 0;
    }
    public int this[int index]
    {
        get
        {
            if (index > 0 || index < count)
                return array[index];
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (value > 0 || value < count)
                array[index] = value;
            else
                throw new IndexOutOfRangeException();
        }
    }
    public void Add(int num)
    {
         Array.Resize(ref array, count + 1);
        array[count] = num;
        count++;
    }
    public void Add(params int[] nums)   //- Göndərilən parametrləri arraya daxil edir.
    {
        int Count = count;
        count += nums.Length;
        Array.Resize(ref array, count);
        Array.Copy(nums, 0, array, Count, nums.Length);
    }
    public bool Contains(int num)  //Göndərilən ədəd array-da varsa true yoxdursa false qaytarır.
    {
        for (int i = 0; i < count; i++) 
        {
            if (array[i] == num) 
            {
                return true; 
            }
        }
        return false; 

    }
    public int Pop()     // - Array-ın sonuncu elementini arraydan silir və həmin elementi geri qaytarır.
    {
        if (count == 0)
            Console.WriteLine("array bosdur");
        Array.Resize(ref array, count - 1);
        int son = array[count - 1];
        count--;
        return son;
    }
    public int Sum()
    {
        int cem = 0; 
        for (int i = 0; i < count; i++) 
        {
            cem += array[i];
        }
        return cem; 
    }
    public override string ToString()
    {
        return string.Join(", ", array);
    }
    
    
}
