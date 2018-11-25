import java.util.Scanner;

public class BoatRaceSimulator {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("Enter a character for the 1st boat: ");
            String firstBoat = scanner.nextLine().toLowerCase();
            while (firstBoat.length() > 1 ||
                    "0".equals(firstBoat) || "1".equals(firstBoat) ||
                    "2".equals(firstBoat) || "3".equals(firstBoat) || "4".equals(firstBoat) ||
                    "5".equals(firstBoat) || "6".equals(firstBoat) || "7".equals(firstBoat) ||
                    "8".equals(firstBoat) || "9".equals(firstBoat) ||
                    "a".equals(firstBoat) || "b".equals(firstBoat) || "c".equals(firstBoat) ||
                    "d".equals(firstBoat) || "e".equals(firstBoat) || "f".equals(firstBoat) ||
                    "g".equals(firstBoat) || "h".equals(firstBoat) || "i".equals(firstBoat) ||
                    "j".equals(firstBoat) || "k".equals(firstBoat) || "l".equals(firstBoat) ||
                    "m".equals(firstBoat) || "n".equals(firstBoat) || "o".equals(firstBoat) ||
                    "p".equals(firstBoat) || "q".equals(firstBoat) || "r".equals(firstBoat) ||
                    "s".equals(firstBoat) || "t".equals(firstBoat) || "u".equals(firstBoat) ||
                    "v".equals(firstBoat) || "w".equals(firstBoat) || "x".equals(firstBoat) ||
                    "y".equals(firstBoat) || "z".equals(firstBoat)) {
                System.out.printf("Invalid inpit. Try againg - character cant be a letter or number: ");
                firstBoat = scanner.nextLine().toLowerCase();
            }

            System.out.print("Enter a character for the 2nd boat: ");
            String secondBoat = scanner.nextLine();
            while (secondBoat.length() > 1 ||
                    "0".equals(secondBoat) || "1".equals(secondBoat) ||
                    "2".equals(secondBoat) || "3".equals(secondBoat) || "4".equals(secondBoat) ||
                    "5".equals(secondBoat) || "6".equals(secondBoat) || "7".equals(secondBoat) ||
                    "8".equals(secondBoat) || "9".equals(secondBoat) ||
                    "a".equals(secondBoat) || "b".equals(secondBoat) || "c".equals(secondBoat) ||
                    "d".equals(secondBoat) || "e".equals(secondBoat) || "f".equals(secondBoat) ||
                    "g".equals(secondBoat) || "h".equals(secondBoat) || "i".equals(secondBoat) ||
                    "j".equals(secondBoat) || "k".equals(secondBoat) || "l".equals(secondBoat) ||
                    "m".equals(secondBoat) || "n".equals(secondBoat) || "o".equals(secondBoat) ||
                    "p".equals(secondBoat) || "q".equals(secondBoat) || "r".equals(secondBoat) ||
                    "s".equals(secondBoat) || "t".equals(secondBoat) || "u".equals(secondBoat) ||
                    "v".equals(secondBoat) || "w".equals(secondBoat) || "x".equals(secondBoat) ||
                    "y".equals(secondBoat) || "z".equals(secondBoat)) {
                System.out.printf("Invalid inpit. Try againg - character cant be a letter or number: ");
                secondBoat = scanner.nextLine().toLowerCase();
            }

            System.out.print("Enter number of texts that will be received below (1-20): ");
            int number = Integer.parseInt(scanner.nextLine());
            while (number < 1 || number > 20) {
                System.out.print("Invalid number of texts. It must be between 1 and 20: ");
                number = Byte.parseByte(scanner.nextLine());
            }

            int speedFirstBoat = 0;
            int speedSecondBoat = 0;
            char firstBoatChar = firstBoat.charAt(0);
            char secondBoatChar = secondBoat.charAt(0);

            for (int i = 1; i <= number; i++) {
                System.out.printf("Enter text #%d (max 100 characters): ", i);
                String speed = scanner.nextLine().toUpperCase();
                while (speed.length() > 100 || speed.length() == 0) {
                    System.out.printf("Too long text. It must contain maximum 100 characters." +
                            "\nEnter again text #%d: ", i);
                    speed = scanner.nextLine().toUpperCase();
                }

                if (i % 2 != 0) {
                    speedFirstBoat += speed.length();
                } else if (i % 2 == 0) {
                    speedSecondBoat += speed.length();
                }

                if ("UPGRADE".equals(speed)) {
                    firstBoatChar += (char) 3;
                    secondBoatChar += (char) 3;
                }

                if (speedFirstBoat >= 50 || speedSecondBoat >= 50) {
                    break;
                }
            }

            if (speedFirstBoat >= speedSecondBoat) {
                System.out.print("The character representation of the winning boat is: ");
                System.out.println(firstBoatChar);
            } else if (speedSecondBoat > speedFirstBoat) {
                System.out.print("The character representation of the winning boat is: ");
                System.out.println(secondBoatChar);
            }

        } catch (Exception ex) {
            System.out.println("Invalid input! Start from the beginning!");
        }
    }
}