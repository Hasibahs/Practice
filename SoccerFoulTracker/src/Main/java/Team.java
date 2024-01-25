// Ensure this import statement is present to use the List interface
import java.util.ArrayList;
import java.util.List; // This was missing from your code snippet and is necessary.

public class Team {
    private String teamName;
    private List<Player> players; // Removed the 'com.soccer.' prefix

    public Team(String name) {
        this.teamName = name;
        this.players = new ArrayList<>();
    }

    public void addPlayer(Player player) { // Removed the 'com.soccer.' prefix
        this.players.add(player);
    }

    public Player getFairPlayAwardPlayer() { // Removed the 'com.soccer.' prefix
        Player fairPlayPlayer = null;
        int minCards = Integer.MAX_VALUE;
        for (Player player : players) { // Removed the 'com.soccer.' prefix
            if (!player.isDisqualified()) {
                int totalCards = player.getTotalCards();
                if (totalCards < minCards) {
                    minCards = totalCards;
                    fairPlayPlayer = player;
                }
            }
        }
        return fairPlayPlayer;
    }

    @Override
    public String toString() {
        return "Team{" +
                "teamName='" + teamName + '\'' +
                ", players=" + players +
                '}';
    }

    public String getTeamName() {
        return teamName;
    }

    public List<Player> getPlayers() { // Removed the 'com.soccer.' prefix
        return new ArrayList<>(players);
    }
}
