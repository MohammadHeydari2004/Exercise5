///// Mohammad Heydari /////////
////// Shamsipour Technical and Vocational College (2023) //////////////


using System.Globalization;
string input;
int keyboard;
do {
    Console.WriteLine("Please enter your grade :");
    if (int.TryParse(Console.ReadLine(), out keyboard) == true) {
        switch (keyboard) {
            case <= 10:
                Gradefalse();
                break;
            case <= 15:
                GradeC();
                break;
            case <= 17:
                GradeB();
                break;
            case <= 20:
                GradeA();
                break;
            case > 20:
                Another();
                break;
        }
    }
    else { Console.WriteLine("Error"); }
    Console.WriteLine();
    Console.WriteLine("Do you want to continue? Press Y or N: ");
    do {
        input = Console.ReadKey(true).KeyChar.ToString();
    }
    while (input.ToUpper() != "Y" && input.ToUpper() != "N");

} while (input.ToUpper() == "Y");

end();

#region Methods
void GradeA() {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("You are rank A");
    Console.ResetColor();
    Console.Write(keyboard * 100 / 20);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" Percent");
    Console.ResetColor();
}
void GradeB() {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You are rank B");
    Console.WriteLine();
    Console.ResetColor();
    Console.Write(keyboard * 100 / 20);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" Percent");
    Console.ResetColor();
}
void GradeC() {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("You are rank C");
    Console.WriteLine();
    Console.ResetColor();
    Console.Write(keyboard * 100 / 20);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" Percent");
    Console.ResetColor();
}

void Gradefalse() {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You are rejected");
    Console.WriteLine();
    Console.ResetColor();
    Console.Write(keyboard * 100 / 20);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" Percent");
    Console.ResetColor();
}
void Another() {

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine();
    Console.WriteLine("please enter another number");
    Console.ResetColor();

}
void end() {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine();
    Console.WriteLine("Thanks for using this app");
    Console.ResetColor();
}


#endregion
