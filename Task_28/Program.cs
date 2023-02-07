//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
                                                          Console.Clear();
                                                            int a = int.Parse(Console.ReadLine());

                                                            int Count(int a)
                                                            {
                                                                int k = 1;
                                                                for (int i = 1; i <= a; i++)
                                                                {
                                                                    k = k * i;
                                                                    
                                                                }
                                                                return k;
                                                            }

int b = Count(a);
Console.WriteLine(b);