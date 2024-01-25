public class Player {
    private String playerName;
    private int yellowCards;
    private int redCards;
    private int blackCards;
    private boolean isDisqualified;

    public Player(String name) {
        this.playerName = name;
        this.yellowCards = 0;
        this.redCards = 0;
        this.blackCards = 0;
        this.isDisqualified = false;
    }

    public void addYellowCard() {
        this.yellowCards++;
    }

    public void addRedCard() {
        this.redCards++;
    }

    public void addBlackCard() {
        this.blackCards++;
        this.isDisqualified = true;
    }

    public boolean isDisqualified() {
        return this.isDisqualified;
    }

    public int getTotalCards() {
        return this.yellowCards + this.redCards + this.blackCards;
    }

    public String getPlayerName() {
        return this.playerName;
    }

    public int getYellowCards() {
        return yellowCards;
    }

    public int getRedCards() {
        return redCards;
    }

    public int getBlackCards() {
        return blackCards;
    }

    @Override
    public String toString() {
        return "Player{" +
                "playerName='" + playerName + '\'' +
                ", yellowCards=" + yellowCards +
                ", redCards=" + redCards +
                ", blackCards=" + blackCards +
                ", isDisqualified=" + isDisqualified +
                '}';
    }
}
