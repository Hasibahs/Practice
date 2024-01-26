public class CardManager {
    private static final double FINE_YELLOW = 18.32;
    private static final double FINE_RED = 41.60;
    private static final double FINE_BLACK = 349.76;

    public void addYellowCard(Player player) {
        player.addCard("YELLOW");
        // You might also update the fine amount here, depending on how you've structured your Player class.
    }

    public void addRedCard(Player player) {
        player.addCard("RED");
        // You might also update the fine amount here, depending on how you've structured your Player class.
    }

    public void addBlackCard(Player player) {
        player.addCard("BLACK");
        // This card also disqualifies the player.
        player.disqualify();
    }

    public double calculateFine(Player player) {
        // Calculate the total fine based on the number of each type of cards the player has.
        int yellowCards = player.getCardCount("YELLOW");
        int redCards = player.getCardCount("RED");
        int blackCards = player.getCardCount("BLACK");

        return (yellowCards * FINE_YELLOW) + (redCards * FINE_RED) + (blackCards * FINE_BLACK);
    }

    // Assuming you need a method to calculate the total fine for a team
    public double calculateTotalTeamFine(Team team) {
        double totalFine = 0.0;
        for (Player player : team.getPlayers()) {
            totalFine += calculateFine(player);
        }
        return totalFine;
    }
}
