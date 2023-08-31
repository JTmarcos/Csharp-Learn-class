using System;

namespace ThirdProject {
    internal class Program {
        static void Main() {

            Rooms[] Vec = new Rooms[10];
            for (int i = 0; i < 10; i++) {
                Vec[i] = new Rooms();
            }
            int AlreadyRent = 0;
            int MaxRent = 10;
            int sair = 0;
            while (sair == 0) {
                Console.WriteLine("Quantos quartos serão alugados?(Se deseja sair digite 0)");
                int RentNow = int.Parse(Console.ReadLine()!);
                if (RentNow <= MaxRent - AlreadyRent && RentNow != 0) {
                    int cont = 0;
                    int[] Alugados = new int[RentNow];
                    while (cont < RentNow) {

                        Console.WriteLine("Qual número deseja alugar?");
                        int RoomRent = int.Parse(Console.ReadLine()!) - 1;
                        if (RoomRent <= 10 && RoomRent >= 1) {
                            if (Vec[RoomRent].Rent == false) {
                                Vec[RoomRent].Rent = true;
                                Console.WriteLine("Digite o nome do Alugador");
                                string Name = Console.ReadLine()!;
                                Console.WriteLine("Digite o E-mail do alugar");
                                string Email = Console.ReadLine()!;
                                Vec[RoomRent].Name = Name;
                                Vec[RoomRent].Email = Email;
                                Vec[RoomRent].RoomId = RoomRent;
                                Alugados[cont] = RoomRent;
                                cont++;
                                AlreadyRent++;
                                Console.WriteLine("Quarto cadastrado");

                            } else {
                                Console.WriteLine("Quarto ja ocupado");
                                Console.Write("Quartos vagos: ");
                                for (int i = 0; i < MaxRent; i++) {
                                    if (Vec[i].Rent == false) {
                                        Console.Write($"{i + 1} ");
                                        Console.WriteLine("\n");

                                    }
                                }
                            }

                        } else {
                            Console.WriteLine("Este quarto não está presente no nosso sistema, possuímos do quarto 1 ao 10\n");
                        }


                    }
                    for (int i = 0; i < RentNow; i++) {
                        Console.WriteLine($"Rent #{i + 1}");
                        Console.WriteLine(Vec[Alugados[i]].ToString());
                        Console.WriteLine("\n");

                    }





                } else if (RentNow > MaxRent - AlreadyRent) {
                    Console.WriteLine($"Impossivel alugar esta quantidade de quartos, disponível {MaxRent - AlreadyRent} ");
                } else if (RentNow == 0) {
                    sair = 1;
                }

            }
            for (int i = 0; i < MaxRent; i++) {
                if (Vec[i].Rent == true) {
                    Console.WriteLine(Vec[i].ToString());
                }
                Console.WriteLine("\n");
            }






        }
    }
}