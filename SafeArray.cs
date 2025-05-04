// Варіант 1 Явон Ярослав 123
/*Варіант 1 Клас інкапсулює одновимірний масив з елементів цілого типу. Створити
індексатор, що запобігає порушенню границі масиву. Створити властивість,
доступну для читання закритого елементу-даного, що контролює доступ до
змінної довжини масиву*/

using System;

namespace Homework
{
    public class SafeArray
    {
        private int[] data;

        public SafeArray(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Розмір масиву > 0");
            data = new int[size];
        }

        public int Length
        {
            get => data.Length;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Розмір масиву > 0");

                Array.Resize(ref data, value);
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    throw new IndexOutOfRangeException($"Індекс {index} виходить за межі масиву");
                return data[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                    throw new IndexOutOfRangeException($"Індекс {index} виходить за межі масиву");
                data[index] = value;
            }
        }
    }
}
