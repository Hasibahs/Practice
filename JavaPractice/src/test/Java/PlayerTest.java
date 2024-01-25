package test;

import main.Player;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class PlayerTest {
    private Player player;

    @BeforeEach
    void setUp() {
        player = new Player("John Doe");
    }

    @Test
    void testAddYellowCard() {
        player.addYellowCard();
        assertEquals(1, player.getYellowCards());
    }

    @Test
    void testAddRedCard() {
        player.addRedCard();
        assertEquals(1, player.getRedCards());
    }

    @Test
    void testAddBlackCard() {
        player.addBlackCard();
        assertTrue(player.isDisqualified());
    }

    // Add more tests for other methods in Player class
}
