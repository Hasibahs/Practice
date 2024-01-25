// No package declaration

public class CardManager {
    private static final double FINE_YELLOW = 18.32;
    private static final double FINE_RED = 41.60;
    private static final double FINE_BLACK = 349.76;

    public void addYellowCard(Player player) {
        player.addYellowCard();
    }

    public void addRedCard(Player player) {
        player.addRedCard();
    }

    public void addBlackCard(Player player) {
        player.addBlackCard();
    }

    public double calculateFine(Player player) {
        return player.getYellowCards() * FINE_YELLOW +
                player.getRedCards() * FINE_RED +
                player.getBlackCards() * FINE_BLACK;
    }
}
