import java.util.Scanner;

public class BoatRaceSimulator {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("Enter a character for the 1st boat: ");
            char firstBoat = scanner.nextLine().charAt(0);
            System.out.print("Enter a character for the 2nd boat: ");
            char secondBoat = scanner.nextLine().charAt(0);

            //input and check the input for the number of the strings
            System.out.print("Enter number of texts that will be received below (1-20): ");
            int number = Integer.parseInt(scanner.nextLine());
            while (number < 1 || number > 20) {
                System.out.print("Invalid number of texts. It must be between 1 and 20: ");
                number = Byte.parseByte(scanner.nextLine());
            }

            int speedFirstBoat = 0;
            int speedSecondBoat = 0;

            for (int i = 1; i <= number; i++) {

                //input and check for the length of the given strings
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
                    firstBoat += (char) 3;
                    secondBoat += (char) 3;
                }

                if (speedFirstBoat >= 50 || speedSecondBoat >= 50) {
                    break;
                }
            }

            if (speedFirstBoat >= speedSecondBoat) {
                System.out.print("The character representation of the winning boat is: ");
                System.out.println(firstBoat);
            } else if (speedSecondBoat > speedFirstBoat) {
                System.out.print("The character representation of the winning boat is: ");
                System.out.println(secondBoat);
            }

        } catch (Exception ex) {
            System.out.println("Invalid input! Start from the beginning!");
        }
    }
}