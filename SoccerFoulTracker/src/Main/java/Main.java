public class Main {
    public static void main(String[] args) {
        InputHandler inputHandler = new InputHandler();
        TeamManager teamManager = new TeamManager();
        CardManager cardManager = new CardManager();

        Team team = inputHandler.createTeam();
        Player player = inputHandler.createPlayer();

        inputHandler.assignCardsToPlayer(cardManager, player);
        teamManager.addPlayerToTeam(team, player);

        double totalFine = teamManager.calculateTotalTeamFine(team);
        Player fairPlayPlayer = teamManager.getFairPlayAwardPlayer(team);

        System.out.println("Total fine for the team: €" + totalFine);
        if (fairPlayPlayer != null) {
            System.out.println("Fairplay Award goes to: " + fairPlayPlayer.getPlayerName());
        } else {
            System.out.println("No player is eligible for the Fairplay Award in this team.");
        }
    }
}