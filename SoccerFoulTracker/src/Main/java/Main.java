public class Main {
    public static void main(String[] args) {
        TeamManager teamManager = new TeamManager();
        CardManager cardManager = new CardManager();

        // Assuming "FC Emmen" has multiple teams, you could loop to create them or create them individually.
        Team fcEmmenTeam = new Team("FC Emmen - Team A");

        // Assume you have a method to populate the team with players and assign cards.
        populateTeamWithTestData(fcEmmenTeam, cardManager);

        // Calculating total fine for the team
        double totalFine = teamManager.calculateTotalTeamFine(fcEmmenTeam);
        System.out.println("Total fine for " + fcEmmenTeam.getTeamName() + " is: €" + String.format("%.2f", totalFine));

        // Determining the player with the least amount of cards for the Fair Play Award
        Player fairPlayPlayer = teamManager.getFairPlayAwardPlayer(fcEmmenTeam);

        // Outputting the Fair Play Award winner
        System.out.println("Fair Play Award Winner in the team:");
        if (fairPlayPlayer != null) {
            System.out.println(fairPlayPlayer.getPlayerName());
        } else {
            System.out.println("No player is eligible for the Fairplay Award in this team.");
        }
    }

    private static void populateTeamWithTestData(Team team, CardManager cardManager) {
        // Creating players with predefined names and cards
        Player player1 = new Player("Nico");
        Player player2 = new Player("Alex");
        Player player3 = new Player("Jadyn");

        // Assigning predefined cards to players
        for (int i = 0; i < 2; i++) {
            cardManager.addYellowCard(player1);
        }
        cardManager.addRedCard(player2);
        cardManager.addBlackCard(player3); // Adding a black card, player3 gets disqualified

        // Adding players to the team
        team.addPlayer(player1);
        team.addPlayer(player2);
        team.addPlayer(player3);
    }

}
