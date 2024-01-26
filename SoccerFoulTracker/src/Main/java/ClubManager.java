package your.package.name; // replace with your actual package name

import java.util.ArrayList;
import java.util.List;

public class ClubManager {
    private List<Team> teams = new ArrayList<>();

    public void addTeam(Team team) {
        teams.add(team);
    }

    public Team getTeam(String name) {
        for (Team team : teams) {
            if (team.getTeamName().equals(name)) {
                return team;
            }
        }
        return null; // or throw an exception if a team is expected to always be found
    }

    public List<Team> getTeams() {
        return teams;
    }

    // Additional methods as needed
}
