using System;
using enemyAndPlayer;

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

        //TODO: choose your role and race

        printSameLine("Please enter your character name: ");
        String name = readLine();
        Character player = new Player(name);
        //TODO: no we need to implement the floors and every floor will have atleast 1 enemy and every 5/20 floors atleast 1 boss will spawn
    }

    private static void loadGame() {
        printNewLine("Not implemented yet...");
    }

    private static string readLine() {
        return Console.ReadLine();
    }

    private static void printNewLine(String text) {
        Console.WriteLine(text);
    }
    private static void printSameLine(String text) {
        Console.Write(text);
    }
}