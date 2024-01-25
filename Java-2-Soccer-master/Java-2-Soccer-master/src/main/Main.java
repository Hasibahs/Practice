package main;

public class Main {
    public static void main(String[] args) {
        // Create a club
        Club club = new Club("Champions FC");

        // Create teams
        Team seniorTeam = new Team("Senior Warriors");
        Team juniorTeam = new Team("Junior Strikers");

        // Create players
        Player player1 = new Player("Leo Messi");
        Player player2 = new Player("Cristiano Ronaldo");
        Player player3 = new Player("Neymar Jr");

        // Add players to teams
        seniorTeam.addPlayer(player1);
        juniorTeam.addPlayer(player2);
        juniorTeam.addPlayer(player3);

        // Issue cards to players
        player1.addCard(Card.YELLOW);
        player2.addCard(Card.RED);
        player3.addCard(Card.BLACK);

        // Add teams to club
        club.addTeam(seniorTeam);
        club.addTeam(juniorTeam);

        // Display the total fine for the club
        System.out.println("Total fine for " + club.getName() + " is: " + club.calculateTotalClubFine());

        // Identify and display the fair play award winners
        System.out.println("Fair Play Award Winners in the club:");
        for (Player winner : club.getClubFairplayAwardWinners()) {
            System.out.println(winner.getName());
        }

        // You can also add functionality to remove players or handle other club/team/player operations
        // ...
    }
}
