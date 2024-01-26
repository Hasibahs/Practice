public class Player {
    // Attributes
    private String name; // Name of the player
    private int yellowCards = 0;
    private int redCards = 0;
    private int blackCards = 0;
    private boolean isDisqualified = false;

    // Constructor
    public Player(String name) {
        this.name = name;
    }

    // Method to return the total number of cards
    public int getTotalCards() {
        return yellowCards + redCards + blackCards;
    }

    // Method to add a card based on type
    public void addCard(String cardType) {
        switch (cardType) {
            case "YELLOW":
                yellowCards++;
                break;
            case "RED":
                redCards++;
                break;
            case "BLACK":
                blackCards++;
                disqualify(); // Assuming a black card disqualifies the player
                break;
        }
    }

    // Method to get the count of a specific type of card
    public int getCardCount(String cardType) {
        return switch (cardType) {
            case "YELLOW" -> yellowCards;
            case "RED" -> redCards;
            case "BLACK" -> blackCards;
            default -> 0;
        };
    }

    // Method to disqualify the player
    public void disqualify() {
        isDisqualified = true;
    }

    // Getter for disqualification status
    public boolean isDisqualified() {
        return isDisqualified;
    }

    // Getter for the player's name
    public String getPlayerName() {
        return name;
    }
}