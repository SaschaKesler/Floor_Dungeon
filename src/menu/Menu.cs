using System;
public class Menu {
    public static void Main(string[] args) {
        Menu.startMenu();
    }

    private static string GAME_NAME = "Floor Dungeon";

    private static void startMenu() {
        printNewLine("Starting " + GAME_NAME + "...");
        
        String inputLine = null;
        do {
            printNewLine("1) Create new game");
            printNewLine("2) Load game");
            printNewLine("3) Exit");

            printSameLine("Please enter a number: ");            
            inputLine = Console.ReadLine();

            //TODO: implement the game
            if("1".Equals(inputLine)) {

                createNewGame();
            } else if("2".Equals(inputLine)) {

                loadGame();
            } else if("3".Equals(inputLine)) {

            } else {

                printNewLine("Please write a number between 1 and 3");
            }

        } while(! "3".Equals(inputLine));

        printNewLine("Good Bye!");
    }

    private static void createNewGame() {
        printSameLine("Please enter your character name: ");
        Character player = new Player();
    }

    private static void loadGame() {
        printNewLine("Not implemented yet...");
    }

    private static void printNewLine(String text) {
        Console.WriteLine(text);
    }
    private static void printSameLine(String text) {
        Console.Write(text);
    }
}