using System;

namespace Lab1
{
    class Program
    {
        public static char[,] VigenereTable = new char[,] {
            { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
            { 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A' },
            { 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B' },
            { 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C' },
            { 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D' },
            { 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E' },
            { 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F' },
            { 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G' },
            { 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' },
            { 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' },
            { 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' },
            { 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K' },
            { 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L' },
            { 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' },
            { 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N' },
            { 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O' },
            { 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P' },
            { 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q' },
            { 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R' },
            { 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S' },
            { 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T' },
            { 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U' },
            { 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V' },
            { 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W' },
            { 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X' },
            { 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y' } };

        static string RailWayEncrypt(string InpStr, int Key)
        {
            string OutStr = "";

            for (int i = Key - 1; i >= 0; i--)
            {
                for (int j = 0; j < InpStr.Length; j++)
                {
                    if (Math.Abs(j % ((Key - 1) * 2) - (Key - 1)) == i)
                    {
                        OutStr += InpStr[j];
                    }
                }
            }
            return OutStr;
        }

        static string RailWayDecrypt(string InpStr, int Key)
        {
            string OutStr = "";
            int[] SubStringLen = new int[Key];
            int[] SubStringInd = new int[Key];
            string[] SubStrings = new string[Key];

            for (int i = Key - 1; i >= 0; i--)
            {
                for (int j = 0; j < InpStr.Length; j++)
                {
                    if (Math.Abs(j % ((Key - 1) * 2) - (Key - 1)) == i)
                    {
                        SubStringLen[i]++;
                    }
                }
            }

            int StartIndex = 0;
            for(int i = Key - 1; i >= 0; i--)
            {
                SubStrings[i] = InpStr.Substring(StartIndex, SubStringLen[i]);
                StartIndex += SubStringLen[i];
            }

            int KeyInd;
            for(int i = 0; i < InpStr.Length; i++)
            {
                KeyInd = Math.Abs(i % ((Key - 1) * 2) - (Key - 1));
                OutStr += SubStrings[KeyInd].Substring(SubStringInd[KeyInd], 1);
                SubStringInd[KeyInd]++;
            }

            return OutStr;
        }

        static int[] MakeOrder(string Key)
        {
            var Order = new int[Key.Length];
            var KeyToChange = (Key.ToUpper()).ToCharArray();

            for (int i = 0; i < Key.Length; i++)
            {
                char Min = 'ぁ';
                int Index = 0;
                for (int j = 0; j < Key.Length; j++)
                {
                    if (Min > KeyToChange[j])
                    {
                        Min = KeyToChange[j];
                        Index = j;
                    }
                }
                KeyToChange[Index] = 'ぁ';
                Order[i] = Index;
            }
            return Order;
        }

        static string TableEncrypt(string InpStr, string Key)
        {
            string OutStr = "";
            int NumOfRow = (int) Math.Ceiling((double)InpStr.Length / Key.Length);
            int i = 0, j = 0, k = 0;
            var Matrix = new char[NumOfRow, Key.Length];
            var Order = new int[Key.Length];

            while (k < InpStr.Length)
            {
                Matrix[i, j] = InpStr[k];
                if (j + 1 < Key.Length)
                    j++;
                else
                {
                    j = 0;
                    i ++;
                }
                k++;
            }

            Order = MakeOrder(Key);

            for(j = 0; j < Key.Length; j++)
            {
                i = 0;
                while(i < NumOfRow)
                {   
                    if(Matrix[i, Order[j]] != 0)
                        OutStr += Matrix[i, Order[j]];
                    i++;
                }
            }
            return OutStr;
        }

        static string TableDecrypt(string InpStr, string Key)
        { 
            string OutStr = "";
            int NumOfRow = (int) Math.Ceiling((double)InpStr.Length / Key.Length);
            int i = 0, j = 0, k = 0;
            var Matrix = new char[NumOfRow, Key.Length];
            var Order = new int[Key.Length];

            Order = MakeOrder(Key);
            for(j = 0; j < Key.Length; j++)
            {
                i = 0;
                while(i < NumOfRow)
                {
                    if ((i * Key.Length + Order[j]) < InpStr.Length)
                    {
                        Matrix[i, Order[j]] = InpStr[k];
                        k++;
                    }
                    i++;
                }
            }
            k = 0;
            i = 0;
            j = 0;
            while (k < InpStr.Length)
            {
                OutStr += Matrix[i, j];
                if (j + 1 < Key.Length)
                    j++;
                else
                {
                    j = 0;
                    i++;
                }
                k++;
            }
            return OutStr;
        }

        static string GridEncrypt(string InpStr)
        {
            string OutStr = "";
            string FillStr = "secrete massege to fullfill free spase";
            char[] InpStrCopy = new char[37];
            char[,] Matrix = new char[6, 6];
            int[,] Index = { {0, 0}, {4, 0}, {2, 5}, {0, 3}, {5, 1}, {4, 4}, {3, 1}, {1, 3}, {3, 3},
                             {0, 5}, {0, 1}, {5, 3}, {3, 5}, {1, 0}, {4, 1}, {1, 2}, {3, 4}, {3, 2},
                             {5, 5}, {1, 5}, {3, 0}, {5, 2}, {0, 4}, {1, 1}, {2, 4}, {4, 2}, {2, 2},
                             {5, 0}, {5, 4}, {0, 2}, {2, 0}, {4, 5}, {1, 4}, {4, 3}, {2, 1}, {2, 3}};

            if (InpStr.Length < 36)
            {
                for (int i = 0; i < InpStr.Length; i++)
                    InpStrCopy[i] = InpStr[i];
                FillStr.CopyTo(0, InpStrCopy, InpStr.Length, 37 - InpStr.Length);
            }
            for (int i = 0; i < 36; i++)
                Matrix[Index[i, 0], Index[i, 1]] = InpStrCopy[i];
            for(int i = 0; i < 6; i++)
                for(int j = 0; j < 6; j++)
                    OutStr += Matrix[i, j];
            OutStr += (char)('а' + InpStr.Length);
            return OutStr;
        }

        static string GridDecrypt(string InpStr)
        {
            string OutStr = "";
            char[,] Matrix = new char[6, 6];
            int[,] Index = { {0, 0}, {4, 0}, {2, 5}, {0, 3}, {5, 1}, {4, 4}, {3, 1}, {1, 3}, {3, 3},
                             {0, 5}, {0, 1}, {5, 3}, {3, 5}, {1, 0}, {4, 1}, {1, 2}, {3, 4}, {3, 2},
                             {5, 5}, {1, 5}, {3, 0}, {5, 2}, {0, 4}, {1, 1}, {2, 4}, {4, 2}, {2, 2},
                             {5, 0}, {5, 4}, {0, 2}, {2, 0}, {4, 5}, {1, 4}, {4, 3}, {2, 1}, {2, 3}};

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    Matrix[i, j] = InpStr[i * 6 + j];

            for (int i = 0; i < (InpStr[36] - 'а'); i++)
                OutStr += Matrix[Index[i, 0], Index[i, 1]];
            return OutStr;
        }

        static string VigenereEncrypt(string InpStr, string Key)
        {
            string Str = InpStr.ToUpper().Replace(" ", "");
            string OutStr = "";
            string UpdateKey = Key.ToUpper().Replace(" ", "");
            char[] WideKey = new char[256];
            Array.Copy(UpdateKey.ToCharArray(), WideKey, UpdateKey.Length);

            if(UpdateKey.Length < InpStr.Length) 
            {
                int k = 1;

                while (UpdateKey.Length * k < InpStr.Length)
                {
                    UpdateKey.ToUpper().CopyTo(0, WideKey, UpdateKey.Length * k, UpdateKey.Length);
                    k++;
                }
            }

            for(int i = 0; i < Str.Length; i++)
            {
                OutStr += VigenereTable[WideKey[i] - 'A', Str[i] - 'A'];
            }

            return OutStr;
        }

        static string VigenereDecrypt(string InpStr, string Key)
        {
            string OutStr = "";
            string UpdateKey = Key.ToUpper().Replace(" ", "");
            char[] WideKey = new char[256];
            Array.Copy(UpdateKey.ToCharArray(), WideKey, UpdateKey.Length);

            if (UpdateKey.Length < InpStr.Length)
            {
                int k = 1;

                while (UpdateKey.Length * k < InpStr.Length)
                {
                    UpdateKey.ToUpper().CopyTo(0, WideKey, UpdateKey.Length * k, UpdateKey.Length);
                    k++;
                }
            }

            for (int i = 0; i < InpStr.Length; i++)
            {
                int num = 0;

                while(VigenereTable[WideKey[i] - 'A', num] != InpStr[i])
                {
                    num++;
                }
                OutStr += (char) (num + 'A');
            }

            return OutStr;
        }

        static void Main(string[] args)
        {
            int Answer = 1;
            string Massege;
            string EncryptMassege;
            string WordKey;
            int IntKey;

            while (Answer != 0)
            {
                Console.WriteLine("Выберете вид шифрования:\n" +
                    "1 - Шифрование методом Железнодорожная изгородь\n" +
                    "2 - Шифрование Столбцовым методом\n" +
                    "3 - Шифрование методом поворачивающейся решётки\n" +
                    "4 - Шифрование методом Виженера\n" +
                    "0 - Выход\n");

                Answer = Int32.Parse(Console.ReadLine());

                switch (Answer)
                {
                    case 1:
                        Console.WriteLine("Введите сообщение:");
                        Massege = Console.ReadLine();
                        Console.WriteLine("Введите числовой ключ:");
                        IntKey = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Зашифрованное сообщение:");
                        EncryptMassege = RailWayEncrypt(Massege, IntKey);
                        Console.WriteLine(EncryptMassege);

                        Console.WriteLine("Расшифрованное сообщение:");
                        EncryptMassege = RailWayDecrypt(EncryptMassege, IntKey);
                        Console.WriteLine(EncryptMassege);
                        break;

                    case 2:
                        Console.WriteLine("Введите сообщение:");
                        Massege = Console.ReadLine();
                        Console.WriteLine("Введите строковый ключ:");
                        WordKey = Console.ReadLine();

                        Console.WriteLine("Зашифрованное сообщение:");
                        EncryptMassege = TableEncrypt(Massege, WordKey);
                        Console.WriteLine(EncryptMassege);

                        Console.WriteLine("Расшифрованное сообщение:");
                        EncryptMassege = TableDecrypt(EncryptMassege, WordKey);
                        Console.WriteLine(EncryptMassege);
                        break;

                    case 3:
                        Console.WriteLine("Введите сообщение:");
                        Massege = Console.ReadLine();

                        Console.WriteLine("Зашифрованное сообщение:");
                        EncryptMassege = GridEncrypt(Massege);
                        Console.WriteLine(EncryptMassege);

                        Console.WriteLine("Расшифрованное сообщение:");
                        EncryptMassege = GridDecrypt(EncryptMassege);
                        Console.WriteLine(EncryptMassege);
                        break;

                    case 4:
                        Console.WriteLine("Введите сообщение:");
                        Massege = Console.ReadLine();
                        Console.WriteLine("Введите строковый ключ:");
                        WordKey = Console.ReadLine();

                        Console.WriteLine("Зашифрованное сообщение:");
                        EncryptMassege = VigenereEncrypt(Massege, WordKey);
                        Console.WriteLine(EncryptMassege);

                        Console.WriteLine("Расшифрованное сообщение:");
                        EncryptMassege = VigenereDecrypt(EncryptMassege, WordKey);
                        Console.WriteLine(EncryptMassege);
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
