namespace Lab7.Purple
{
    public class Task2
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int _distance;
            private int[] _marks;

            public string Name => _name;
            public string Surname => _surname;
            public int Distance => _distance;
            public int[] Marks => _marks.ToArray();
            public int Result
            {
                get
                {
                    if (_marks == null || _marks.Length == 0)
                        return 0;

                    for (int i = 0; i < _marks.Length; i++)
                    {
                        for (int j = 1; j < _marks.Length; j++)
                        {
                            if (_marks[j - 1] > _marks[j])
                            {
                                (_marks[j - 1], _marks[j]) = (_marks[j], _marks[j - 1]);
                            }

                        }
                    }

                    int sum = 0;
                    for (int i = 1; i < _marks.Length - 1; i++)
                    {
                        sum += _marks[i];
                    }

                    int distance = (_distance - 120) * 2 + 60;
                    if (distance < 0)
                        distance = 0;

                    int result = sum + distance;
                    return result;
                }
            }

            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _distance = 0;
                _marks = new int[5];
            }

            public void Jump(int distance, int[] marks)
            {
                if (marks == null || marks.Length != 5)
                    return;

                _distance = distance;
                _marks = marks;
            }
            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0)
                    return;
                
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 1; j < array.Length; j++)
                    {
                        if (array[j - 1].Result < array[j].Result)
                        {
                            (array[j - 1], array[j]) = (array[j], array[j - 1]);
                        }
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"Participant: {Name} {Surname}");
                Console.WriteLine($"Result: {Result}");
            }
        }
    }
}
