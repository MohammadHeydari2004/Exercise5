///// Mohammad Heydari /////////
////// Shamsipour Technical and Vocational College (2023) //////////////

#region variables
string input;
int number;
#endregion

#region codes
do {
    Console.WriteLine();
    Console.WriteLine("Please enter your grade :");
    number = Convert.ToInt16(Console.ReadLine());
    switch (number) {
        case < 0:
            Another();
            break;
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
    Console.WriteLine();
    Console.WriteLine("Do you want to continue? Press Y or N: ");
    do {
        input = Console.ReadKey(true).KeyChar.ToString();
    }
    while (input.ToUpper() != "Y" && input.ToUpper() != "N");
}
while (input.ToUpper() == "Y");

end();
#endregion

#region Methods
void GradeA() {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("You are rank A");
    Console.ResetColor();
    Console.Write(number * 100 / 20);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" Percent");
    Console.ResetColor();
}
void GradeB() {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You are rank B");
    Console.WriteLine();
    Console.ResetColor();
    Console.Write(number * 100 / 20);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" Percent");
    Console.ResetColor();
}
void GradeC() {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("You are rank C");
    Console.WriteLine();
    Console.ResetColor();
    Console.Write(number * 100 / 20);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" Percent");
    Console.ResetColor();
}

void Gradefalse() {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You are rejected");
    Console.WriteLine();
    Console.ResetColor();
    Console.Write(number * 100 / 20);
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